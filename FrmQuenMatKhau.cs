using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_chi_tieu_sinh_vien
{
    public partial class FrmQuenMatKhau : Form
    {
        // Khai báo biến lưu tài khoản để sử dụng ở cả nút Xác thực lẫn nút Lưu mật khẩu
        private string authenticatedUsername = "";

        public FrmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacThuc_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenTK.Text.Trim();
            string email = txtEmail.Text.Trim();
            if(string.IsNullOrEmpty(tenTK))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTK.Focus();
                return;
            }
            if(string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            try
            {
                DatabaseProcessing db = new DatabaseProcessing();
                // Chú ý: Cột trong CSDL là TenDangNhap (không phải TenTK)
                string sql = $"SELECT * FROM TaiKhoan WHERE TenDangNhap = N'{tenTK}' AND Email = N'{email}' AND TrangThai = 1";
                DataTable dt = db.ReadData(sql);

                if (dt.Rows.Count > 0)
                {
                    authenticatedUsername = tenTK;
                    MessageBox.Show("Xác thực thông tin tài khoản thành công!\nVui lòng nhập mật khẩu mới phía dưới.",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenTK.Enabled = false;
                    txtEmail.Enabled = false;
                    btnXacThuc.Enabled = false;

                    txtMKM.Enabled = true;
                    txtXNMKM.Enabled = true;
                    txtMKM.Focus();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc email không đúng. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuMKM_Click(object sender, EventArgs e)
        {
            string matKhauMoi = txtMKM.Text.Trim();
            string xacNhanMatKhauMoi = txtXNMKM.Text.Trim();
            if(string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhanMatKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(matKhauMoi != xacNhanMatKhauMoi)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXNMKM.Clear();
                txtXNMKM.Focus();
                return;
            }
            if(matKhauMoi.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có ít nhất 6 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMKM.Focus();
                return;
            }

            try
            {
                DatabaseProcessing db = new DatabaseProcessing();
                string sqlUpdate = $"UPDATE TaiKhoan SET MatKhau = N'{matKhauMoi}' " +
                                   $"WHERE TenDangNhap = N'{authenticatedUsername}'";
                db.ChangeData(sqlUpdate);
                MessageBox.Show("Đặt lại mật khẩu thành công!\nBạn có thể đăng nhập bằng mật khẩu mới.",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật mật khẩu:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
