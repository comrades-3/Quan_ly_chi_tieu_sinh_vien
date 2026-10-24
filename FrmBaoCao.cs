using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Quan_ly_chi_tieu_sinh_vien
{
    /*
     * CÁC CONTROL CẦN CÓ TRÊN FORM (đặt đúng tên - Name):
     *   cboThang      ComboBox  (DropDownStyle = DropDownList)
     *   cboNam        ComboBox  (DropDownStyle = DropDownList)
     *   btnXuatExcel  Button
     *   lblTongThu    Label     (hiện tổng thu)
     *   lblTongChi    Label     (hiện tổng chi)
     *   lblChenhLech  Label     (hiện chênh lệch)
     *   dgvDanhMuc    DataGridView  (bảng tổng hợp theo danh mục)
     *   chartChi      Chart     (biểu đồ: thống kê chi tiêu theo danh mục)
     *   chartThu      Chart     (biểu đồ: thống kê thu nhập theo danh mục)
     *
     * Các sự kiện (Load, SelectedIndexChanged, Click) được gắn bằng code trong
     * constructor, nên KHÔNG double-click vào control để tạo sự kiện (tránh bị gắn 2 lần).
     */
    public partial class FrmBaoCao : Form
    {
        private readonly DatabaseProcessing db = new DatabaseProcessing();
        private static readonly CultureInfo VN = new CultureInfo("vi-VN");
        private bool dangKhoiTao = true;

        private static readonly Color MauThu = Color.FromArgb(25, 135, 84);
        private static readonly Color MauChi = Color.FromArgb(220, 53, 69);
        private static readonly Color MauXanh = Color.FromArgb(13, 110, 253);

        public FrmBaoCao()
        {
            InitializeComponent();

            this.Load += FrmBaoCao_Load;
            cboThang.SelectedIndexChanged += BoLoc_Changed;
            cboNam.SelectedIndexChanged += BoLoc_Changed;
            btnXuatExcel.Click += btnXuatExcel_Click;
        }

        /// <summary>
        /// TODO: thay bằng mã tài khoản của người đang đăng nhập (lấy từ FrmDangNhap).
        /// Tạm thời trả về 1 = tài khoản test sinhvien01.
        /// </summary>
        private int LayMaTaiKhoan()
        {
            return 1;
        }

        // ======================= KHỞI TẠO =======================

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            // Tháng: 0 = cả năm, 1..12 = từng tháng
            cboThang.Items.Add("Cả năm");
            for (int m = 1; m <= 12; m++)
                cboThang.Items.Add("Tháng " + m);

            int namHienTai = DateTime.Now.Year;
            for (int y = namHienTai; y >= namHienTai - 5; y--)
                cboNam.Items.Add(y);

            cboThang.SelectedIndex = DateTime.Now.Month;   // mặc định: tháng hiện tại
            cboNam.SelectedIndex = 0;                      // mặc định: năm hiện tại

            CauHinhBang();

            dangKhoiTao = false;
            TaiBaoCao();
        }

        private void BoLoc_Changed(object sender, EventArgs e)
        {
            if (dangKhoiTao) return;
            TaiBaoCao();
        }

        private void CauHinhBang()
        {
            dgvDanhMuc.ReadOnly = true;
            dgvDanhMuc.AllowUserToAddRows = false;
            dgvDanhMuc.AllowUserToDeleteRows = false;
            dgvDanhMuc.RowHeadersVisible = false;
            dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ======================= TRUY VẤN =======================

        // Tổng tiền theo từng danh mục (cả THU lẫn CHI) trong kỳ đã chọn
        private DataTable LayTongHopTheoDanhMuc(int thang, int nam)
        {
            SqlCommand cmd = new SqlCommand(
                @"SELECT dm.MaDanhMuc, dm.TenDanhMuc, gd.LoaiGiaoDich, SUM(gd.SoTien) AS TongTien
                  FROM GiaoDich gd
                  INNER JOIN DanhMuc dm ON gd.MaDanhMuc = dm.MaDanhMuc
                  WHERE gd.MaTaiKhoan = @tk
                    AND YEAR(gd.NgayGiaoDich) = @nam
                    AND (@thang = 0 OR MONTH(gd.NgayGiaoDich) = @thang)
                  GROUP BY dm.MaDanhMuc, dm.TenDanhMuc, gd.LoaiGiaoDich
                  ORDER BY TongTien DESC");
            cmd.Parameters.Add("@tk", SqlDbType.Int).Value = LayMaTaiKhoan();
            cmd.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
            cmd.Parameters.Add("@thang", SqlDbType.Int).Value = thang;
            return db.ReadData(cmd);
        }

        // Danh sách giao dịch chi tiết (dùng để xuất file)
        private DataTable LayChiTietGiaoDich(int thang, int nam)
        {
            SqlCommand cmd = new SqlCommand(
                @"SELECT NgayGiaoDich, LoaiGiaoDich, TenDanhMuc, SoTien, GhiChu
                  FROM vw_GiaoDich
                  WHERE MaTaiKhoan = @tk
                    AND YEAR(NgayGiaoDich) = @nam
                    AND (@thang = 0 OR MONTH(NgayGiaoDich) = @thang)
                  ORDER BY NgayGiaoDich, MaGiaoDich");
            cmd.Parameters.Add("@tk", SqlDbType.Int).Value = LayMaTaiKhoan();
            cmd.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
            cmd.Parameters.Add("@thang", SqlDbType.Int).Value = thang;
            return db.ReadData(cmd);
        }

        // ======================= HIỂN THỊ BÁO CÁO =======================

        private void TaiBaoCao()
        {
            if (cboNam.SelectedItem == null || cboThang.SelectedIndex < 0) return;

            int thang = cboThang.SelectedIndex;               // 0 = cả năm
            int nam = Convert.ToInt32(cboNam.SelectedItem);

            try
            {
                DataTable dt = LayTongHopTheoDanhMuc(thang, nam);

                decimal tongThu = TinhTong(dt, "THU");
                decimal tongChi = TinhTong(dt, "CHI");
                decimal chenhLech = tongThu - tongChi;

                lblTongThu.Text = DinhDangTien(tongThu);
                lblTongChi.Text = DinhDangTien(tongChi);
                lblChenhLech.Text = DinhDangTien(chenhLech);
                lblTongThu.ForeColor = MauThu;
                lblTongChi.ForeColor = MauChi;
                lblChenhLech.ForeColor = chenhLech >= 0 ? MauXanh : MauChi;

                HienBangDanhMuc(dt, tongThu, tongChi);
                VeBieuDoTron(chartChi, dt, "CHI", thang, nam);   // thống kê chi tiêu theo danh mục
                VeBieuDoTron(chartThu, dt, "THU", thang, nam);   // thống kê thu nhập theo danh mục
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được báo cáo:\n" + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static decimal TinhTong(DataTable dt, string loai)
        {
            decimal tong = 0;
            foreach (DataRow r in dt.Rows)
            {
                if (r["LoaiGiaoDich"].ToString() == loai)
                    tong += Convert.ToDecimal(r["TongTien"]);
            }
            return tong;
        }

        private static string DinhDangTien(decimal soTien)
        {
            return string.Format(VN, "{0:N0} đ", soTien);
        }

        // Bảng: Loại | Danh mục | Số tiền | Tỷ lệ (%)
        private void HienBangDanhMuc(DataTable dt, decimal tongThu, decimal tongChi)
        {
            DataTable hienThi = new DataTable();
            hienThi.Columns.Add("Loại", typeof(string));
            hienThi.Columns.Add("Danh mục", typeof(string));
            hienThi.Columns.Add("Số tiền", typeof(decimal));
            hienThi.Columns.Add("Tỷ lệ (%)", typeof(double));

            foreach (DataRow r in dt.Select("", "LoaiGiaoDich ASC, TongTien DESC"))
            {
                bool laThu = r["LoaiGiaoDich"].ToString() == "THU";
                decimal tien = Convert.ToDecimal(r["TongTien"]);
                decimal tong = laThu ? tongThu : tongChi;
                double tyLe = tong > 0 ? Math.Round((double)(tien / tong) * 100, 1) : 0;
                hienThi.Rows.Add(laThu ? "Thu" : "Chi", r["TenDanhMuc"].ToString(), tien, tyLe);
            }

            dgvDanhMuc.DataSource = hienThi;

            if (dgvDanhMuc.Columns.Contains("Số tiền"))
            {
                dgvDanhMuc.Columns["Số tiền"].DefaultCellStyle.Format = "N0";
                dgvDanhMuc.Columns["Số tiền"].DefaultCellStyle.FormatProvider = VN;
                dgvDanhMuc.Columns["Số tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvDanhMuc.Columns["Tỷ lệ (%)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        /// <summary>
        /// Vẽ biểu đồ tròn cơ cấu theo danh mục.
        /// loai = "CHI" -> thống kê chi tiêu; loai = "THU" -> thống kê thu nhập.
        /// (Muốn đổi dạng biểu đồ: sửa SeriesChartType.Pie thành Doughnut hoặc Bar.)
        /// </summary>
        private void VeBieuDoTron(Chart chart, DataTable dt, string loai, int thang, int nam)
        {
            ChuanBiChart(chart);

            bool laChi = loai == "CHI";
            string ky = thang == 0 ? "năm " + nam : "tháng " + thang + "/" + nam;

            Series s = new Series(loai);
            s.ChartType = SeriesChartType.Pie;
            s.Label = "#PERCENT{P1}";
            s.LegendText = "#VALX";
            s["PieLabelStyle"] = "Outside";
            s["PieLineColor"] = "Gray";
            if (!laChi) s.Palette = ChartColorPalette.SeaGreen;   // thu nhập: tông xanh lá

            foreach (DataRow r in dt.Select("LoaiGiaoDich = '" + loai + "'", "TongTien DESC"))
                s.Points.AddXY(r["TenDanhMuc"].ToString(), Convert.ToDouble(r["TongTien"]));

            chart.Series.Add(s);

            if (s.Points.Count > 0)
                chart.Titles.Add("Cơ cấu " + (laChi ? "chi tiêu" : "thu nhập") + " theo danh mục, " + ky);
            else
                chart.Titles.Add("Chưa có khoản " + (laChi ? "chi" : "thu") + " nào trong " + ky);
        }

        // Xóa dữ liệu cũ, đảm bảo chart có ChartArea và Legend
        private static void ChuanBiChart(Chart c)
        {
            c.Series.Clear();
            c.Titles.Clear();
            if (c.ChartAreas.Count == 0) c.ChartAreas.Add(new ChartArea("Area1"));
            if (c.Legends.Count == 0) c.Legends.Add(new Legend("Legend1"));
        }

        // ======================= XUẤT EXCEL (CSV) =======================

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (cboNam.SelectedItem == null) return;

            int thang = cboThang.SelectedIndex;
            int nam = Convert.ToInt32(cboNam.SelectedItem);

            try
            {
                DataTable dt = LayChiTietGiaoDich(thang, nam);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có giao dịch nào trong kỳ này để xuất.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Tệp Excel (CSV)|*.csv";
                    sfd.FileName = thang == 0
                        ? "BaoCao_" + nam
                        : "BaoCao_" + nam + "_" + thang.ToString("00");
                    if (sfd.ShowDialog() != DialogResult.OK) return;

                    decimal tongThu = 0, tongChi = 0;
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("sep=,");   // báo cho Excel biết dấu phân cách là dấu phẩy
                    sb.AppendLine("Ngày,Loại,Danh mục,Số tiền,Ghi chú");

                    foreach (DataRow r in dt.Rows)
                    {
                        bool laThu = r["LoaiGiaoDich"].ToString() == "THU";
                        decimal tien = Convert.ToDecimal(r["SoTien"]);
                        if (laThu) tongThu += tien; else tongChi += tien;

                        sb.AppendLine(string.Join(",", new string[]
                        {
                            Convert.ToDateTime(r["NgayGiaoDich"]).ToString("dd/MM/yyyy"),
                            laThu ? "Thu" : "Chi",
                            CsvEscape(r["TenDanhMuc"].ToString()),
                            tien.ToString("0", CultureInfo.InvariantCulture),
                            CsvEscape(r["GhiChu"] == DBNull.Value ? "" : r["GhiChu"].ToString())
                        }));
                    }

                    sb.AppendLine();
                    sb.AppendLine("Tổng thu,,," + tongThu.ToString("0", CultureInfo.InvariantCulture) + ",");
                    sb.AppendLine("Tổng chi,,," + tongChi.ToString("0", CultureInfo.InvariantCulture) + ",");
                    sb.AppendLine("Chênh lệch,,," + (tongThu - tongChi).ToString("0", CultureInfo.InvariantCulture) + ",");

                    // UTF-8 có BOM để Excel hiển thị đúng tiếng Việt
                    File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));

                    MessageBox.Show("Đã xuất báo cáo thành công.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xuất được file:\n" + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string CsvEscape(string s)
        {
            if (s.IndexOfAny(new char[] { ',', '"', '\r', '\n' }) >= 0)
                return "\"" + s.Replace("\"", "\"\"") + "\"";
            return s;
        }
    }
}