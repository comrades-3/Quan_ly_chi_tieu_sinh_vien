using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_chi_tieu_sinh_vien
{
    public partial class FrmThemSuaGiaoDich : Form
    {
        private int maGiaoDich = -1; // -1: Thêm mới, > 0: Chỉnh sửa
        private DatabaseProcessing db = new DatabaseProcessing();
        private bool isFormatting = false;

        public FrmThemSuaGiaoDich()
        {
            InitializeComponent();
            this.maGiaoDich = -1;
            this.Load += FrmThemSuaGiaoDich_Load;
        }

        public FrmThemSuaGiaoDich(int maGD)
        {
            InitializeComponent();
            this.maGiaoDich = maGD;
            this.Load += FrmThemSuaGiaoDich_Load;
        }

        private void FrmThemSuaGiaoDich_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            cB_danhmuc.DropDownStyle = ComboBoxStyle.DropDownList;

            if (maGiaoDich > 0)
            {
                label1.Text = "Cập Nhật Giao Dịch";
                b_luu.Text = "Lưu";
                this.Text = "Sửa giao dịch";

                LoadThongTinGiaoDich();
            }
            else
            {
                label1.Text = "Thêm Giao Dịch Mới";
                b_luu.Text = "Lưu";
                this.Text = "Thêm giao dịch";

                rB_chitieu.Checked = true;
                LoadDanhMuc("CHI");
                dateTimePicker1.Value = DateTime.Now;
            }
        }


        private void LoadDanhMuc(string loai, int selectMaDanhMuc = -1)
        {
            try
            {
                string sql = "SELECT MaDanhMuc, TenDanhMuc FROM DanhMuc WHERE LoaiDanhMuc = N'" + loai + "' ORDER BY TenDanhMuc ASC";
                DataTable dt = db.ReadData(sql);

                cB_danhmuc.DataSource = dt;
                cB_danhmuc.DisplayMember = "TenDanhMuc";
                cB_danhmuc.ValueMember = "MaDanhMuc";

                if (selectMaDanhMuc > 0)
                {
                    cB_danhmuc.SelectedValue = selectMaDanhMuc;
                }
                else if (dt.Rows.Count > 0)
                {
                    cB_danhmuc.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rB_chitieu_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_chitieu.Checked)
            {
                LoadDanhMuc("CHI");
            }
        }

        private void rB_thunhap_CheckedChanged(object sender, EventArgs e)
        {
            if (rB_thunhap.Checked)
            {
                LoadDanhMuc("THU");
            }
        }

        private void LoadThongTinGiaoDich()
        {
            try
            {
                string sql = "SELECT MaGiaoDich, MaDanhMuc, LoaiGiaoDich, SoTien, NgayGiaoDich, GhiChu FROM GiaoDich WHERE MaGiaoDich = " + maGiaoDich;
                DataTable dt = db.ReadData(sql);
                if (dt.Rows.Count > 0)
                {
                    DataRow r = dt.Rows[0];
                    string loai = r["LoaiGiaoDich"].ToString();
                    int maDM = Convert.ToInt32(r["MaDanhMuc"]);
                    decimal soTien = Convert.ToDecimal(r["SoTien"]);
                    DateTime ngayGD = Convert.ToDateTime(r["NgayGiaoDich"]);
                    string ghiChu = r["GhiChu"] != DBNull.Value ? r["GhiChu"].ToString() : "";

                    if (loai == "THU")
                    {
                        rB_thunhap.Checked = true;
                    }
                    else
                    {
                        rB_chitieu.Checked = true;
                    }

                    LoadDanhMuc(loai, maDM);

                    isFormatting = true;
                    tB_sotien.Text = string.Format("{0:N0}", soTien);
                    isFormatting = false;

                    dateTimePicker1.Value = ngayGD;
                    tb_ghichu.Text = ghiChu;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy giao dịch cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp dữ liệu giao dịch: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tB_sotien_TextChanged(object sender, EventArgs e)
        {
            if (isFormatting) return;

            string raw = tB_sotien.Text.Replace(",", "").Replace(".", "").Trim();
            if (string.IsNullOrEmpty(raw)) return;

            if (decimal.TryParse(raw, out decimal val))
            {
                isFormatting = true;
                tB_sotien.Text = string.Format("{0:N0}", val);
                tB_sotien.SelectionStart = tB_sotien.Text.Length;
                isFormatting = false;
            }
        }


        private void b_luu_Click(object sender, EventArgs e)
        {

            if (cB_danhmuc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục giao dịch!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cB_danhmuc.Focus();
                return;
            }

            string rawTien = tB_sotien.Text.Replace(",", "").Replace(".", "").Trim();
            if (string.IsNullOrWhiteSpace(rawTien) || !decimal.TryParse(rawTien, out decimal soTien) || soTien <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ (> 0 VNĐ)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_sotien.Focus();
                return;
            }

            string loaiGD = rB_chitieu.Checked ? "CHI" : "THU";
            int maDM = Convert.ToInt32(cB_danhmuc.SelectedValue);
            DateTime ngayGD = dateTimePicker1.Value;
            string ghiChu = tb_ghichu.Text.Trim();
            int maTK = LuuThongTin.MaTaiKhoan;

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    if (maGiaoDich > 0)
                    {
                        cmd.CommandText = @"UPDATE GiaoDich 
                                            SET MaDanhMuc = @MaDanhMuc, 
                                                LoaiGiaoDich = @LoaiGiaoDich, 
                                                SoTien = @SoTien, 
                                                NgayGiaoDich = @NgayGiaoDich, 
                                                GhiChu = @GhiChu, 
                                                NgayCapNhat = GETDATE() 
                                            WHERE MaGiaoDich = @MaGiaoDich";
                        cmd.Parameters.AddWithValue("@MaGiaoDich", maGiaoDich);
                    }
                    else
                    {
                        cmd.CommandText = @"INSERT INTO GiaoDich (MaTaiKhoan, MaDanhMuc, LoaiGiaoDich, SoTien, NgayGiaoDich, GhiChu, NgayTao, NgayCapNhat) 
                                            VALUES (@MaTaiKhoan, @MaDanhMuc, @LoaiGiaoDich, @SoTien, @NgayGiaoDich, @GhiChu, GETDATE(), GETDATE())";
                        cmd.Parameters.AddWithValue("@MaTaiKhoan", maTK);
                    }

                    cmd.Parameters.AddWithValue("@MaDanhMuc", maDM);
                    cmd.Parameters.AddWithValue("@LoaiGiaoDich", loaiGD);
                    cmd.Parameters.AddWithValue("@SoTien", soTien);
                    cmd.Parameters.AddWithValue("@NgayGiaoDich", ngayGD.Date);
                    cmd.Parameters.AddWithValue("@GhiChu", ghiChu);

                    db.ChangeData(cmd);
                }

                string thongBao = (maGiaoDich > 0) ? "Cập nhật giao dịch thành công!" : "Thêm giao dịch mới thành công!";
                MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu giao dịch:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void b_huy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void cB_danhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tb_ghichu_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
