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
            string sql = $"SELECT * FROM TietKiem WHERE MaTaiKhoan = {LuuThongTin.MaTaiKhoan}";
            DataTable dt = db.ReadData(sql);
            dgvTietKiem.DataSource = dt;

            if (dgvTietKiem.Columns["MaTietKiem"] != null)
            {
                dgvTietKiem.Columns["MaTietKiem"].HeaderText = "Mã TK";
                dgvTietKiem.Columns["MaTietKiem"].FillWeight = 50;
            }
            if (dgvTietKiem.Columns["MaTaiKhoan"] != null)
                dgvTietKiem.Columns["MaTaiKhoan"].Visible = false;
            if (dgvTietKiem.Columns["TenMucTieu"] != null)
            {
                dgvTietKiem.Columns["TenMucTieu"].HeaderText = "Tên mục tiêu";
                dgvTietKiem.Columns["TenMucTieu"].FillWeight = 130;
            }
            if (dgvTietKiem.Columns["SoTienMucTieu"] != null)
            {
                dgvTietKiem.Columns["SoTienMucTieu"].HeaderText = "Mục tiêu (đ)";
                dgvTietKiem.Columns["SoTienMucTieu"].DefaultCellStyle.Format = "N0";
                dgvTietKiem.Columns["SoTienMucTieu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvTietKiem.Columns["SoTienMucTieu"].FillWeight = 100;
            }
            if (dgvTietKiem.Columns["SoTienHienCo"] != null)
            {
                dgvTietKiem.Columns["SoTienHienCo"].HeaderText = "Hiện có (đ)";
                dgvTietKiem.Columns["SoTienHienCo"].DefaultCellStyle.Format = "N0";
                dgvTietKiem.Columns["SoTienHienCo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvTietKiem.Columns["SoTienHienCo"].FillWeight = 100;
            }
            if (dgvTietKiem.Columns["NgayBatDau"] != null)
            {
                dgvTietKiem.Columns["NgayBatDau"].HeaderText = "Ngày bắt đầu";
                dgvTietKiem.Columns["NgayBatDau"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvTietKiem.Columns["NgayBatDau"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvTietKiem.Columns["NgayBatDau"].FillWeight = 85;
            }
            if (dgvTietKiem.Columns["NgayKetThuc"] != null)
            {
                dgvTietKiem.Columns["NgayKetThuc"].HeaderText = "Ngày hạn";
                dgvTietKiem.Columns["NgayKetThuc"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvTietKiem.Columns["NgayKetThuc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvTietKiem.Columns["NgayKetThuc"].FillWeight = 85;
            }
            if (dgvTietKiem.Columns["TrangThai"] != null)
            {
                dgvTietKiem.Columns["TrangThai"].HeaderText = "Trạng thái";
                dgvTietKiem.Columns["TrangThai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvTietKiem.Columns["TrangThai"].FillWeight = 90;
            }
        }

        private void dgvTietKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTietKiem.Rows[e.RowIndex];
                txtMaTietKiem.Text = row.Cells["MaTietKiem"].Value?.ToString() ?? "";
                txtTenMucTieu.Text = row.Cells["TenMucTieu"].Value?.ToString() ?? "";

                decimal tienMucTieu = 0;
                decimal tienHienCo = 0;
                if (row.Cells["SoTienMucTieu"].Value != null && row.Cells["SoTienMucTieu"].Value != DBNull.Value)
                    decimal.TryParse(row.Cells["SoTienMucTieu"].Value.ToString(), out tienMucTieu);

                if (row.Cells["SoTienHienCo"].Value != null && row.Cells["SoTienHienCo"].Value != DBNull.Value)
                    decimal.TryParse(row.Cells["SoTienHienCo"].Value.ToString(), out tienHienCo);

                txtSoTienMucTieu.Text = tienMucTieu.ToString("N0");
                txtSoTienHienCo.Text = tienHienCo.ToString("N0");

                if (row.Cells["NgayBatDau"].Value != null && row.Cells["NgayBatDau"].Value != DBNull.Value)
                    dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["NgayBatDau"].Value);
                if (row.Cells["NgayKetThuc"].Value != null && row.Cells["NgayKetThuc"].Value != DBNull.Value)
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

            if (!decimal.TryParse(txtNapTien.Text.Trim(), out decimal tienNap) || tienNap <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền nạp hợp lệ (> 0)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal tienMucTieu = decimal.Parse(txtSoTienMucTieu.Text, System.Globalization.NumberStyles.Any);
            decimal tienHienCo = decimal.Parse(txtSoTienHienCo.Text, System.Globalization.NumberStyles.Any);
            decimal tienConThieu = tienMucTieu - tienHienCo;
            string tenMucTieu = txtTenMucTieu.Text;

            if (tienNap > tienConThieu)
            {
                MessageBox.Show($"Số tiền nạp ({tienNap:N0}) lớn hơn số tiền còn thiếu ({tienConThieu:N0}). Vui lòng nhập số tiền nhỏ hơn hoặc bằng số còn thiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn nạp {tienNap:N0} vào quỹ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = $"UPDATE TietKiem " +
                             $"SET SoTienHienCo = SoTienHienCo + {tienNap}, " +
                             $"TrangThai = CASE WHEN SoTienHienCo + {tienNap} >= SoTienMucTieu THEN N'Đã hoàn thành' ELSE N'Đang thực hiện' END " +
                             $"WHERE MaTietKiem = {txtMaTietKiem.Text}";

                db.ChangeData(sql);

                if (tienHienCo + tienNap >= tienMucTieu)
                {
                    MessageBox.Show($"Chúc mừng bạn tiết kiệm thành công khoản {tenMucTieu}!", "Hoàn thành mục tiêu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nạp tiền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtNapTien.Clear();
                LoadData();
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
            if (string.IsNullOrWhiteSpace(txtTenMucTieuMoi.Text) || string.IsNullOrWhiteSpace(txtSoTienMucTieuMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtSoTienMucTieuMoi.Text.Trim(), out decimal soTienMT) || soTienMT <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền mục tiêu hợp lệ (> 0)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Xác nhận thêm mục tiêu tiết kiệm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string tenMT = txtTenMucTieuMoi.Text.Trim();
                string ngayBD = DateTime.Now.ToString("yyyy-MM-dd");
                string ngayKT = dtpNgayHanMoi.Value.ToString("yyyy-MM-dd");

                string sql = $"INSERT INTO TietKiem (MaTaiKhoan, TenMucTieu, SoTienMucTieu, SoTienHienCo, NgayBatDau, NgayKetThuc, TrangThai) " +
                             $"VALUES ({LuuThongTin.MaTaiKhoan}, N'{tenMT}', {soTienMT}, 0, '{ngayBD}', '{ngayKT}', N'Đang thực hiện')";

                db.ChangeData(sql);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpThemMoi.Enabled = false;
                txtTenMucTieuMoi.Clear();
                txtSoTienMucTieuMoi.Clear();
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

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
