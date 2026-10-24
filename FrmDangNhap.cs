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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtTK.Text.Trim();
            string matKhau = txtMK.Text.Trim();

            if (string.IsNullOrEmpty(TenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTK.Focus();
                return;
            }
            if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMK.Focus();
                return;
            }

            try
            {
                DatabaseProcessing db = new DatabaseProcessing();
          
                string sql = $"SELECT * FROM TaiKhoan " +
                             $"WHERE TenDangNhap = N'{TenDangNhap}' " +
                             $"AND MatKhau = N'{matKhau}' " +
                             $"AND TrangThai = 1";
                DataTable dt = db.ReadData(sql);

                if (dt.Rows.Count > 0)
                {
                    // Lưu thông tin phiên đăng nhập
                    LuuThongTin.MaTaiKhoan = Convert.ToInt32(dt.Rows[0]["MaTaiKhoan"]);
                    LuuThongTin.TenDangNhap = dt.Rows[0]["TenDangNhap"].ToString();
                    LuuThongTin.HoTen = dt.Rows[0]["HoTen"] != DBNull.Value ? dt.Rows[0]["HoTen"].ToString() : dt.Rows[0]["TenDangNhap"].ToString();

                    MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();                  
                    FrmDashboard frmMain = new FrmDashboard();
                    frmMain.ShowDialog();        
                    this.Close();                
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMK.Clear();
                    txtMK.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy frmDangKy = new FrmDangKy();
            frmDangKy.ShowDialog();
            
        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            FrmQuenMatKhau frmQuenMatKhau = new FrmQuenMatKhau();
            frmQuenMatKhau.ShowDialog();
        }
    }
}
