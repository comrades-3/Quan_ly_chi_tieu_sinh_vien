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
        public string TenDangNhapMoi { get; private set; } = "";

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
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không đúng định dạng (ví dụ: sinhvien@gmail.com).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
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

                string sqlCheckEmail = $"SELECT COUNT(*) FROM TaiKhoan WHERE Email = N'{email}'";
                DataTable dtCheckEmail = db.ReadData(sqlCheckEmail);
                if (Convert.ToInt32(dtCheckEmail.Rows[0][0]) > 0)
                {
                    MessageBox.Show("Email này đã được đăng ký. Vui lòng sử dụng email khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                string sql = $"INSERT INTO TaiKhoan (TenDangNhap, MatKhau, Email) " +
                             $"VALUES (N'{tenTK}', N'{matKhau}', N'{email}')";

                db.ChangeData(sql);

                TenDangNhapMoi = tenTK;
                this.DialogResult = DialogResult.OK;

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
            if (this.Modal)
            {
                this.Close();
            }
            else
            {
                FrmDangNhap frmDangNhap = new FrmDangNhap();
                frmDangNhap.Show();
                this.Close();
            }
        }
    }
}
