using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_chi_tieu_sinh_vien
{
    public partial class FrmDangKy : Form
    {
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenTK.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string xnMK = txtXNMatKhau.Text.Trim();
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(tenTK))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTK.Focus();
                return;
            }
            if (tenTK.Length < 4)
            {
                MessageBox.Show("Tên đăng nhập phải có ít nhất 4 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTK.Focus();
                return;
            }
        
            if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            if (matKhau.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            if (matKhau != xnMK)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXNMatKhau.Clear();
                txtXNMatKhau.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(email))
            {
                // Kiểm tra định dạng email đơn giản
                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Email không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }
            }

            try
            {
                DatabaseProcessing db = new DatabaseProcessing();

             
                string sqlCheck = $"SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = N'{tenTK}'";
                DataTable dtCheck = db.ReadData(sqlCheck);
                int count = Convert.ToInt32(dtCheck.Rows[0][0]);
                if (count > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenTK.Focus();
                    return;
                }

                string emailValue = string.IsNullOrEmpty(email) ? "NULL" : $"N'{email}'";
                string sql = $"INSERT INTO TaiKhoan (TenDangNhap, MatKhau, Email) " +
                             $"VALUES (N'{tenTK}', N'{matKhau}', {emailValue})";

                db.ChangeData(sql);

                MessageBox.Show("Đăng ký thành công! Bạn có thể đăng nhập ngay bây giờ.",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // Quay về FrmDangNhap
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
            this.Close();

        }
    }
}
