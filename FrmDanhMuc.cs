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
    public partial class FrmDanhMuc : Form
    {
        private DatabaseProcessing db = new DatabaseProcessing();
        private DataTable dtDanhMuc = new DataTable();

        public FrmDanhMuc()
        {
            InitializeComponent();
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            KhoiTaoComboBox();
            LoadData();
            LamMoi();
        }

        private void KhoiTaoComboBox()
        {
            var listLoai = new[]
            {
                new { Text = "Chi tiêu", Value = "CHI" },
                new { Text = "Thu nhập", Value = "THU" }
            };
            cboLoaiDanhMuc.DisplayMember = "Text";
            cboLoaiDanhMuc.ValueMember = "Value";
            cboLoaiDanhMuc.DataSource = listLoai;

            var listLoc = new[]
            {
                new { Text = "-- Tất cả --", Value = "ALL" },
                new { Text = "Khoản Chi tiêu", Value = "CHI" },
                new { Text = "Khoản Thu nhập", Value = "THU" }
            };
            cboLocLoai.DisplayMember = "Text";
            cboLocLoai.ValueMember = "Value";
            cboLocLoai.DataSource = listLoc;
        }

        private void LoadData()
        {
            try
            {
                string sql = @"
                    SELECT 
                        MaDanhMuc,
                        TenDanhMuc,
                        CASE LoaiDanhMuc 
                            WHEN 'THU' THEN N'Thu nhập' 
                            WHEN 'CHI' THEN N'Chi tiêu' 
                            ELSE LoaiDanhMuc 
                        END AS TenLoaiDanhMuc,
                        LoaiDanhMuc,
                        MoTa,
                        CASE LaMacDinh 
                            WHEN 1 THEN N'Mặc định' 
                            ELSE N'Cá nhân' 
                        END AS LoaiNguon,
                        LaMacDinh,
                        NgayTao
                    FROM DanhMuc
                    ORDER BY LoaiDanhMuc DESC, LaMacDinh DESC, TenDanhMuc ASC";

                dtDanhMuc = db.ReadData(sql);
                ApDungBoLoc();
                DinhDangDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách danh mục:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DinhDangDataGridView()
        {
            if (dgvDanhMuc.Columns.Count == 0) return;

            if (dgvDanhMuc.Columns.Contains("MaDanhMuc"))
            {
                dgvDanhMuc.Columns["MaDanhMuc"].HeaderText = "Mã DM";
                dgvDanhMuc.Columns["MaDanhMuc"].Width = 70;
                dgvDanhMuc.Columns["MaDanhMuc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvDanhMuc.Columns.Contains("TenDanhMuc"))
            {
                dgvDanhMuc.Columns["TenDanhMuc"].HeaderText = "Tên danh mục";
                dgvDanhMuc.Columns["TenDanhMuc"].Width = 170;
            }

            if (dgvDanhMuc.Columns.Contains("TenLoaiDanhMuc"))
            {
                dgvDanhMuc.Columns["TenLoaiDanhMuc"].HeaderText = "Loại";
                dgvDanhMuc.Columns["TenLoaiDanhMuc"].Width = 100;
                dgvDanhMuc.Columns["TenLoaiDanhMuc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvDanhMuc.Columns.Contains("LoaiNguon"))
            {
                dgvDanhMuc.Columns["LoaiNguon"].HeaderText = "Phân loại";
                dgvDanhMuc.Columns["LoaiNguon"].Width = 95;
                dgvDanhMuc.Columns["LoaiNguon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvDanhMuc.Columns.Contains("MoTa"))
            {
                dgvDanhMuc.Columns["MoTa"].HeaderText = "Mô tả";
                dgvDanhMuc.Columns["MoTa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (dgvDanhMuc.Columns.Contains("NgayTao"))
            {
                dgvDanhMuc.Columns["NgayTao"].HeaderText = "Ngày tạo";
                dgvDanhMuc.Columns["NgayTao"].Width = 100;
                dgvDanhMuc.Columns["NgayTao"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvDanhMuc.Columns["NgayTao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvDanhMuc.Columns.Contains("LoaiDanhMuc"))
                dgvDanhMuc.Columns["LoaiDanhMuc"].Visible = false;

            if (dgvDanhMuc.Columns.Contains("LaMacDinh"))
                dgvDanhMuc.Columns["LaMacDinh"].Visible = false;
        }

        private void ApDungBoLoc()
        {
            if (dtDanhMuc == null) return;

            DataView dv = dtDanhMuc.DefaultView;
            string filter = "1=1";

            if (cboLocLoai.SelectedValue != null)
            {
                string loai = cboLocLoai.SelectedValue.ToString();
                if (loai == "THU" || loai == "CHI")
                {
                    filter += $" AND LoaiDanhMuc = '{loai}'";
                }
            }

            string keyword = txtTimKiem.Text.Trim().Replace("'", "''");
            if (!string.IsNullOrEmpty(keyword))
            {
                filter += $" AND (TenDanhMuc LIKE '%{keyword}%' OR MoTa LIKE '%{keyword}%')";
            }

            dv.RowFilter = filter;
            dgvDanhMuc.DataSource = dv;

            CapNhatThongKe(dv);
        }

        private void CapNhatThongKe(DataView dv)
        {
            int tong = dv.Count;
            int countThu = 0;
            int countChi = 0;

            for (int i = 0; i < dv.Count; i++)
            {
                string loai = dv[i]["LoaiDanhMuc"].ToString();
                if (loai == "THU") countThu++;
                else if (loai == "CHI") countChi++;
            }

            lblTongSo.Text = $"Tổng số: {tong} ({countThu} thu, {countChi} chi)";
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhMuc.Rows.Count)
            {
                DataGridViewRow row = dgvDanhMuc.Rows[e.RowIndex];

                txtMaDanhMuc.Text = row.Cells["MaDanhMuc"].Value?.ToString();
                txtTenDanhMuc.Text = row.Cells["TenDanhMuc"].Value?.ToString();

                string loai = row.Cells["LoaiDanhMuc"].Value?.ToString();
                if (!string.IsNullOrEmpty(loai))
                {
                    cboLoaiDanhMuc.SelectedValue = loai;
                }

                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();

                bool laMacDinh = false;
                if (row.Cells["LaMacDinh"].Value != DBNull.Value && row.Cells["LaMacDinh"].Value != null)
                {
                    laMacDinh = Convert.ToBoolean(row.Cells["LaMacDinh"].Value);
                }

                if (laMacDinh)
                {
                    btnXoa.Enabled = false;
                    btnXoa.BackColor = Color.FromArgb(200, 200, 200);
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnXoa.BackColor = Color.FromArgb(220, 53, 69);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenDM = txtTenDanhMuc.Text.Trim();
            if (string.IsNullOrEmpty(tenDM))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDanhMuc.Focus();
                return;
            }

            if (cboLoaiDanhMuc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại danh mục (Chi tiêu hoặc Thu nhập).", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiDanhMuc.Focus();
                return;
            }

            string loaiDM = cboLoaiDanhMuc.SelectedValue.ToString();
            string moTa = txtMoTa.Text.Trim();

            try
            {
                SqlCommand cmdCheck = new SqlCommand(@"
                    SELECT COUNT(*) 
                    FROM DanhMuc 
                    WHERE LOWER(TenDanhMuc) = LOWER(@TenDM) AND LoaiDanhMuc = @LoaiDM");
                cmdCheck.Parameters.AddWithValue("@TenDM", tenDM);
                cmdCheck.Parameters.AddWithValue("@LoaiDM", loaiDM);

                DataTable dtCheck = db.ReadData(cmdCheck);
                int count = Convert.ToInt32(dtCheck.Rows[0][0]);
                if (count > 0)
                {
                    string loaiHienThi = loaiDM == "THU" ? "Thu nhập" : "Chi tiêu";
                    MessageBox.Show($"Danh mục '{tenDM}' đã tồn tại trong nhóm {loaiHienThi}. Vui lòng chọn tên khác!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenDanhMuc.Focus();
                    return;
                }

                SqlCommand cmdInsert = new SqlCommand(@"
                    INSERT INTO DanhMuc (TenDanhMuc, LoaiDanhMuc, MoTa, LaMacDinh)
                    VALUES (@TenDM, @LoaiDM, @MoTa, 0)");
                cmdInsert.Parameters.AddWithValue("@TenDM", tenDM);
                cmdInsert.Parameters.AddWithValue("@LoaiDM", loaiDM);
                cmdInsert.Parameters.AddWithValue("@MoTa", string.IsNullOrEmpty(moTa) ? (object)DBNull.Value : moTa);

                db.ChangeData(cmdInsert);

                MessageBox.Show("Thêm danh mục mới thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm danh mục:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDanhMuc.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn danh mục cần sửa từ danh sách bên phải.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maDM = Convert.ToInt32(txtMaDanhMuc.Text.Trim());
            string tenDM = txtTenDanhMuc.Text.Trim();
            if (string.IsNullOrEmpty(tenDM))
            {
                MessageBox.Show("Tên danh mục không được để trống.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDanhMuc.Focus();
                return;
            }

            string loaiDM = cboLoaiDanhMuc.SelectedValue.ToString();
            string moTa = txtMoTa.Text.Trim();

            try
            {

                SqlCommand cmdCheck = new SqlCommand(@"
                    SELECT COUNT(*) 
                    FROM DanhMuc 
                    WHERE LOWER(TenDanhMuc) = LOWER(@TenDM) AND LoaiDanhMuc = @LoaiDM AND MaDanhMuc <> @MaDM");
                cmdCheck.Parameters.AddWithValue("@TenDM", tenDM);
                cmdCheck.Parameters.AddWithValue("@LoaiDM", loaiDM);
                cmdCheck.Parameters.AddWithValue("@MaDM", maDM);

                DataTable dtCheck = db.ReadData(cmdCheck);
                int count = Convert.ToInt32(dtCheck.Rows[0][0]);
                if (count > 0)
                {
                    string loaiHienThi = loaiDM == "THU" ? "Thu nhập" : "Chi tiêu";
                    MessageBox.Show($"Tên danh mục '{tenDM}' đã trùng với một danh mục khác trong nhóm {loaiHienThi}!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenDanhMuc.Focus();
                    return;
                }

                SqlCommand cmdUpdate = new SqlCommand(@"
                    UPDATE DanhMuc 
                    SET TenDanhMuc = @TenDM, 
                        LoaiDanhMuc = @LoaiDM, 
                        MoTa = @MoTa 
                    WHERE MaDanhMuc = @MaDM");
                cmdUpdate.Parameters.AddWithValue("@TenDM", tenDM);
                cmdUpdate.Parameters.AddWithValue("@LoaiDM", loaiDM);
                cmdUpdate.Parameters.AddWithValue("@MoTa", string.IsNullOrEmpty(moTa) ? (object)DBNull.Value : moTa);
                cmdUpdate.Parameters.AddWithValue("@MaDM", maDM);

                db.ChangeData(cmdUpdate);

                MessageBox.Show("Cập nhật danh mục thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật danh mục:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDanhMuc.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn danh mục cần xóa từ danh sách bên phải.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maDM = Convert.ToInt32(txtMaDanhMuc.Text.Trim());
            string tenDM = txtTenDanhMuc.Text.Trim();

            try
            {
  
                SqlCommand cmdCheckMacDinh = new SqlCommand(@"
                    SELECT LaMacDinh 
                    FROM DanhMuc 
                    WHERE MaDanhMuc = @MaDM");
                cmdCheckMacDinh.Parameters.AddWithValue("@MaDM", maDM);

                DataTable dtMacDinh = db.ReadData(cmdCheckMacDinh);
                if (dtMacDinh.Rows.Count > 0 && Convert.ToBoolean(dtMacDinh.Rows[0]["LaMacDinh"]))
                {
                    MessageBox.Show("Đây là danh mục mặc định của hệ thống, không thể xóa!",
                        "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                SqlCommand cmdCheckGiaoDich = new SqlCommand(@"
                    SELECT COUNT(*) 
                    FROM GiaoDich 
                    WHERE MaDanhMuc = @MaDM");
                cmdCheckGiaoDich.Parameters.AddWithValue("@MaDM", maDM);

                DataTable dtGiaoDich = db.ReadData(cmdCheckGiaoDich);
                int soGiaoDich = Convert.ToInt32(dtGiaoDich.Rows[0][0]);
                if (soGiaoDich > 0)
                {
                    MessageBox.Show($"Danh mục '{tenDM}' hiện đang có {soGiaoDich} giao dịch thu/chi liên quan trong hệ thống.\n\nĐể đảm bảo toàn vẹn dữ liệu thu chi, bạn không thể xóa danh mục này!",
                        "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialog = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa danh mục '{tenDM}' không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM DanhMuc WHERE MaDanhMuc = @MaDM");
                    cmdDelete.Parameters.AddWithValue("@MaDM", maDM);
                    db.ChangeData(cmdDelete);

                    MessageBox.Show("Đã xóa danh mục thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    LamMoi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa danh mục:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            txtMaDanhMuc.Clear();
            txtTenDanhMuc.Clear();
            txtMoTa.Clear();

            if (cboLoaiDanhMuc.Items.Count > 0)
                cboLoaiDanhMuc.SelectedIndex = 0;

            btnXoa.Enabled = true;
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);

            if (dgvDanhMuc.Rows.Count > 0)
                dgvDanhMuc.ClearSelection();

            txtTenDanhMuc.Focus();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ApDungBoLoc();
        }

        private void cboLocLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApDungBoLoc();
        }

        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTongSo_Click(object sender, EventArgs e)
        {

        }
    }
}
