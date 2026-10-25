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
    public partial class FrmTietKiem : Form
    {

        DatabaseProcessing db = new DatabaseProcessing();

        // Đưa hàm khởi tạo về mặc định (không có tham số)
        public FrmTietKiem()
        {
            InitializeComponent();
        }

        private void FrmTietKiem_Load(object sender, EventArgs e)
        {
            grpThemMoi.Enabled = false;
            LoadData();
        }

        private void LoadData()
        {
            // Lấy trực tiếp MaTaiKhoan từ class LuuThongTin
            string sql = $"SELECT * FROM TietKiem WHERE MaTaiKhoan = {LuuThongTin.MaTaiKhoan}";
            DataTable dt = db.ReadData(sql);
            dgvTietKiem.DataSource = dt;
        }

        private void dgvTietKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTietKiem.Rows[e.RowIndex];
                txtMaTietKiem.Text = row.Cells["MaTietKiem"].Value.ToString();
                txtTenMucTieu.Text = row.Cells["TenMucTieu"].Value.ToString();

                decimal tienMucTieu = Convert.ToDecimal(row.Cells["SoTienMucTieu"].Value);
                decimal tienHienCo = Convert.ToDecimal(row.Cells["SoTienHienCo"].Value);

                txtSoTienMucTieu.Text = tienMucTieu.ToString("N0");
                txtSoTienHienCo.Text = tienHienCo.ToString("N0");

                if (row.Cells["NgayBatDau"].Value != DBNull.Value)
                    dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);
                if (row.Cells["NgayKetThuc"].Value != DBNull.Value)
                    dtpNgayHan.Value = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value);

                decimal tienConThieu = tienMucTieu - tienHienCo;
                txtSoTienConThieu.Text = tienConThieu > 0 ? tienConThieu.ToString("N0") : "0";

                if (tienMucTieu > 0)
                {
                    decimal tienDo = (tienHienCo / tienMucTieu) * 100;
                    txtTienDo.Text = Math.Round(tienDo, 2).ToString();
                }
                else
                {
                    txtTienDo.Text = "0";
                }
            }
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTietKiem.Text))
            {
                MessageBox.Show("Vui lòng chọn một mục tiêu để nạp tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtNapTien.Text, out decimal tienNap) || tienNap <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền nạp hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin từ các textbox hiện tại để tính toán
            decimal tienMucTieu = Convert.ToDecimal(txtSoTienMucTieu.Text);
            decimal tienHienCo = Convert.ToDecimal(txtSoTienHienCo.Text);
            decimal tienConThieu = tienMucTieu - tienHienCo;
            string tenMucTieu = txtTenMucTieu.Text;

            // Yêu cầu 2: Thông báo và chặn nếu số tiền nạp cao hơn số tiền còn thiếu
            if (tienNap > tienConThieu)
            {
                MessageBox.Show($"Số tiền nạp ({tienNap:N0}) lớn hơn số tiền còn thiếu ({tienConThieu:N0}). Vui lòng nhập số tiền nhỏ hơn hoặc bằng số còn thiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn nạp {tienNap:N0} vào quỹ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // Cập nhật CSDL, trạng thái tự động thành 'Đã hoàn thành' nếu số tiền đạt mốc
                string sql = $"UPDATE TietKiem " +
                             $"SET SoTienHienCo = SoTienHienCo + {tienNap}, " +
                             $"TrangThai = CASE WHEN SoTienHienCo + {tienNap} >= SoTienMucTieu THEN N'Đã hoàn thành' ELSE N'Đang thực hiện' END " +
                             $"WHERE MaTietKiem = {txtMaTietKiem.Text}";

                db.ChangeData(sql);

                // Yêu cầu 1: Thông báo chúc mừng khi mục tiêu hoàn thành
                if (tienHienCo + tienNap >= tienMucTieu)
                {
                    MessageBox.Show($"Chúc mừng bạn tiết kiệm thành công khoản {tenMucTieu}!", "Hoàn thành mục tiêu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nạp tiền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtNapTien.Clear();
                LoadData(); // Làm mới lại DataGridView để hiển thị trạng thái mới
            }
        }

        private void btnThemMucTieu_Click(object sender, EventArgs e)
        {
            grpThemMoi.Enabled = true;
            txtTenMucTieuMoi.Clear();
            txtSoTienMucTieuMoi.Clear();
            dtpNgayHanMoi.Value = DateTime.Now;
            txtTenMucTieuMoi.Focus();
        }

        private void btnLuuThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenMucTieuMoi.Text) || string.IsNullOrEmpty(txtSoTienMucTieuMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            DialogResult dr = MessageBox.Show("Xác nhận thêm mục tiêu tiết kiệm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string tenMT = txtTenMucTieuMoi.Text;
                decimal soTienMT = Convert.ToDecimal(txtSoTienMucTieuMoi.Text);
                string ngayBD = DateTime.Now.ToString("yyyy-MM-dd");
                string ngayKT = dtpNgayHanMoi.Value.ToString("yyyy-MM-dd");

                // Lấy MaTaiKhoan từ class LuuThongTin khi insert
                string sql = $"INSERT INTO TietKiem (MaTaiKhoan, TenMucTieu, SoTienMucTieu, SoTienHienCo, NgayBatDau, NgayKetThuc, TrangThai) " +
                             $"VALUES ({LuuThongTin.MaTaiKhoan}, N'{tenMT}', {soTienMT}, 0, '{ngayBD}', '{ngayKT}', N'Đang thực hiện')";

                db.ChangeData(sql);
                MessageBox.Show("Thêm thành công!");
                grpThemMoi.Enabled = false;
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTietKiem.Text))
            {
                MessageBox.Show("Vui lòng chọn một mục tiêu để xóa!");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa mục tiêu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string sql = $"DELETE FROM TietKiem WHERE MaTietKiem = {txtMaTietKiem.Text}";
                db.ChangeData(sql);
                MessageBox.Show("Xóa thành công!");

                txtMaTietKiem.Clear();
                txtTenMucTieu.Clear();
                txtSoTienMucTieu.Clear();
                txtSoTienHienCo.Clear();
                txtSoTienConThieu.Clear();
                txtTienDo.Clear();

                LoadData();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpThemMoi_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
