using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_chi_tieu_sinh_vien
{
    public partial class FrmTongQuan : Form
    {
        private DatabaseProcessing db = new DatabaseProcessing();
        private CultureInfo viVn = new CultureInfo("vi-VN");

        public FrmTongQuan()
        {
            InitializeComponent();
        }

        private void FrmTongQuan_Load(object sender, EventArgs e)
        {
            // Hiển thị tên người dùng trên lời chào
            if (!string.IsNullOrEmpty(LuuThongTin.HoTen))
            {
                label1.Text = $"Xin chào, {LuuThongTin.HoTen}! 👋";
            }
            LoadDuLieu();
        }

        public void LoadDuLieu()
        {
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            HienThi4The(thang, nam);
            HienThiBieuDoTron(thang, nam);
            HienThiBieuDoCot();
        }

        private void HienThi4The(int thang, int nam)
        {
            try
            {
                int maTK = LuuThongTin.MaTaiKhoan;

                // Thu tháng của tài khoản hiện tại
                string sqlThu = $"SELECT ISNULL(SUM(SoTien), 0) FROM GiaoDich WHERE LoaiGiaoDich = 'THU' AND MaTaiKhoan = {maTK} AND MONTH(NgayGiaoDich) = {thang} AND YEAR(NgayGiaoDich) = {nam}";
                decimal thu = Convert.ToDecimal(db.ReadData(sqlThu).Rows[0][0]);
                lblThuNhap.Text = thu.ToString("N0", viVn) + " ₫";

                // Chi tháng của tài khoản hiện tại
                string sqlChi = $"SELECT ISNULL(SUM(SoTien), 0) FROM GiaoDich WHERE LoaiGiaoDich = 'CHI' AND MaTaiKhoan = {maTK} AND MONTH(NgayGiaoDich) = {thang} AND YEAR(NgayGiaoDich) = {nam}";
                decimal chi = Convert.ToDecimal(db.ReadData(sqlChi).Rows[0][0]);
                lblChiTieu.Text = chi.ToString("N0", viVn) + " ₫";

                // Tổng Thu và Tổng Chi toàn bộ thời gian của tài khoản hiện tại
                string sqlTongThu = $"SELECT ISNULL(SUM(SoTien), 0) FROM GiaoDich WHERE LoaiGiaoDich = 'THU' AND MaTaiKhoan = {maTK}";
                string sqlTongChi = $"SELECT ISNULL(SUM(SoTien), 0) FROM GiaoDich WHERE LoaiGiaoDich = 'CHI' AND MaTaiKhoan = {maTK}";
                decimal tongThu = Convert.ToDecimal(db.ReadData(sqlTongThu).Rows[0][0]);
                decimal tongChi = Convert.ToDecimal(db.ReadData(sqlTongChi).Rows[0][0]);
                lblSoDu.Text = (tongThu - tongChi).ToString("N0", viVn) + " ₫";

                // Chi bình quân / ngày
                int ngay = DateTime.Now.Day;
                decimal binhQuan = ngay > 0 ? (chi / ngay) : 0;
                lblBinhQuan.Text = binhQuan.ToString("N0", viVn) + " ₫";
            }
            catch
            {
                lblSoDu.Text = "0 ₫";
                lblThuNhap.Text = "0 ₫";
                lblChiTieu.Text = "0 ₫";
                lblBinhQuan.Text = "0 ₫";
            }
        }

        private void HienThiBieuDoTron(int thang, int nam)
        {
            try
            {
                if (chartCoCau.Series.IndexOf("ChiTieu") != -1)
                {
                    chartCoCau.Series["ChiTieu"].Points.Clear();
                    chartCoCau.Series["ChiTieu"]["PieLabelStyle"] = "Disabled";
                    chartCoCau.Series["ChiTieu"].ToolTip = "#VALX: #VALY{N0} ₫ (#PERCENT)";
                }

                int maTK = LuuThongTin.MaTaiKhoan;
                string sql = $@"SELECT dm.TenDanhMuc, SUM(gd.SoTien) AS TongChi
                                FROM GiaoDich gd JOIN DanhMuc dm ON gd.MaDanhMuc = dm.MaDanhMuc
                                WHERE gd.LoaiGiaoDich = 'CHI' AND gd.MaTaiKhoan = {maTK} 
                                  AND MONTH(gd.NgayGiaoDich) = {thang} AND YEAR(gd.NgayGiaoDich) = {nam}
                                GROUP BY dm.TenDanhMuc";
                DataTable dt = db.ReadData(sql);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow r in dt.Rows)
                        chartCoCau.Series["ChiTieu"].Points.AddXY(r["TenDanhMuc"].ToString(), Convert.ToDouble(r["TongChi"]));
                }
                else
                {
                    chartCoCau.Series["ChiTieu"].Points.AddXY("Ăn uống", 1200000);
                    chartCoCau.Series["ChiTieu"].Points.AddXY("Nhà trọ", 1500000);
                    chartCoCau.Series["ChiTieu"].Points.AddXY("Đi lại", 300000);
                }
            }
            catch { }
        }

        private void HienThiBieuDoCot()
        {
            try
            {
           
                string seriesThu = chartThuChi.Series.IndexOf("Thu Nhập") != -1 ? "Thu Nhập" : (chartThuChi.Series.IndexOf("Thu nhập") != -1 ? "Thu nhập" : null);
                string seriesChi = chartThuChi.Series.IndexOf("Chi tiêu") != -1 ? "Chi tiêu" : (chartThuChi.Series.IndexOf("Chi Tiêu") != -1 ? "Chi Tiêu" : null);

                if (seriesThu != null) chartThuChi.Series[seriesThu].Points.Clear();
                if (seriesChi != null) chartThuChi.Series[seriesChi].Points.Clear();

                DateTime now = DateTime.Now;
                int maTK = LuuThongTin.MaTaiKhoan;

                for (int i = 5; i >= 0; i--)
                {
                    DateTime t = now.AddMonths(-i);
                    string thangHienThi = $"T{t.Month}/{t.Year}";
                    decimal thu = 0, chi = 0;
                    try
                    {
                        string sqlThu = $"SELECT ISNULL(SUM(SoTien), 0) FROM GiaoDich WHERE LoaiGiaoDich = 'THU' AND MaTaiKhoan = {maTK} AND MONTH(NgayGiaoDich) = {t.Month} AND YEAR(NgayGiaoDich) = {t.Year}";
                        string sqlChi = $"SELECT ISNULL(SUM(SoTien), 0) FROM GiaoDich WHERE LoaiGiaoDich = 'CHI' AND MaTaiKhoan = {maTK} AND MONTH(NgayGiaoDich) = {t.Month} AND YEAR(NgayGiaoDich) = {t.Year}";
                        thu = Convert.ToDecimal(db.ReadData(sqlThu).Rows[0][0]);
                        chi = Convert.ToDecimal(db.ReadData(sqlChi).Rows[0][0]);
                    }
                    catch { }

                    if (seriesThu != null) chartThuChi.Series[seriesThu].Points.AddXY(thangHienThi, thu);
                    if (seriesChi != null) chartThuChi.Series[seriesChi].Points.AddXY(thangHienThi, chi);
                }
            }
            catch { }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblSodu_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
