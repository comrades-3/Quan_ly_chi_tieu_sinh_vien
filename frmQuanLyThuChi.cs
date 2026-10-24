using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quan_ly_chi_tieu_sinh_vien
{
    public partial class FrmQuanLyThuChi : Form
    {
        private DatabaseProcessing db = new DatabaseProcessing();
        private bool isLoaded = false;

        public FrmQuanLyThuChi()
        {
            InitializeComponent();
            InitData();
            isLoaded = true;
            LoadData();
        }

        private void InitData()
        {
            cB_thang.Items.Clear();
            cB_thang.Items.Add("Tất cả");
            for (int i = 1; i <= 12; i++)
            {
                cB_thang.Items.Add(i.ToString());
            }
            cB_thang.SelectedIndex = 0;

            cB_nam.Items.Clear();
            cB_nam.Items.Add("Tất cả");
            int namHienTai = DateTime.Now.Year;
            for (int i = namHienTai - 3; i <= namHienTai + 1; i++)
            {
                cB_nam.Items.Add(i.ToString());
            }
            cB_nam.SelectedIndex = 0;

            cB_giaodich.Items.Clear();
            cB_giaodich.Items.Add("Tất cả");
            cB_giaodich.Items.Add("THU");
            cB_giaodich.Items.Add("CHI");
            cB_giaodich.SelectedIndex = 0;
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT g.MaGiaoDich AS [Mã GD], d.TenDanhMuc AS [Danh mục], g.LoaiGiaoDich AS [Loại GD], g.SoTien AS [Số tiền], g.NgayGiaoDich AS [Ngày GD], g.GhiChu AS [Ghi chú] " +
                               "FROM GiaoDich g JOIN DanhMuc d ON g.MaDanhMuc = d.MaDanhMuc WHERE 1=1";

                if (cB_thang.SelectedIndex > 0)
                {
                    query += " AND MONTH(g.NgayGiaoDich) = " + cB_thang.SelectedItem.ToString();
                }

                if (cB_nam.SelectedIndex > 0)
                {
                    query += " AND YEAR(g.NgayGiaoDich) = " + cB_nam.SelectedItem.ToString();
                }

                if (cB_giaodich.SelectedIndex > 0)
                {
                    query += " AND g.LoaiGiaoDich = N'" + cB_giaodich.SelectedItem.ToString() + "'";
                }

                if (!string.IsNullOrWhiteSpace(TimKiem.Text))
                {
                    query += " AND (d.TenDanhMuc LIKE N'%" + TimKiem.Text.Trim() + "%' OR g.GhiChu LIKE N'%" + TimKiem.Text.Trim() + "%')";
                }

                query += " ORDER BY g.NgayGiaoDich DESC";

                DataTable dt = db.ReadData(query);
                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns["Số tiền"] != null)
                {
                    dataGridView1.Columns["Số tiền"].DefaultCellStyle.Format = "N0";
                }

                if (dataGridView1.Columns["Ngày GD"] != null)
                {
                    dataGridView1.Columns["Ngày GD"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                TinhTong(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void TinhTong(DataTable dt)
        {
            decimal tongThu = 0;
            decimal tongChi = 0;

            foreach (DataRow row in dt.Rows)
            {
                decimal soTien = 0;
                decimal.TryParse(row["Số tiền"].ToString(), out soTien);

                string loai = row["Loại GD"].ToString();
                if (loai == "THU")
                {
                    tongThu += soTien;
                }
                else if (loai == "CHI")
                {
                    tongChi += soTien;
                }
            }

            tongThuLabel.Text = tongThu.ToString("N0") + " đ";
            tongChiLabel.Text = tongChi.ToString("N0") + " đ";
            label10.Text = (tongThu - tongChi).ToString("N0") + " đ";
        }

        private void LoadDataGridView()
        {
            LoadData();
        }

        private void cB_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                LoadData();
            }
        }

        private void cB_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                LoadData();
            }
        }

        private void cB_giaodich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                LoadData();
            }
        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                LoadData();
            }
        }

        private void b_timkiem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void b_them_Click(object sender, EventArgs e)
        {
            FrmThemSuaGiaoDich frm = new FrmThemSuaGiaoDich();
            frm.ShowDialog();
            LoadData();
        }

        private void b_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["Mã GD"].Value != null)
            {
                FrmThemSuaGiaoDich frm = new FrmThemSuaGiaoDich();
                frm.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giao dịch cần sửa!");
            }
        }

        private void b_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["Mã GD"].Value != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa giao dịch này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string maGD = dataGridView1.CurrentRow.Cells["Mã GD"].Value.ToString();
                        db.ChangeData("DELETE FROM GiaoDich WHERE MaGiaoDich = " + maGD);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giao dịch cần xóa!");
            }
        }

        private void b_load_Click(object sender, EventArgs e)
        {
            cB_thang.SelectedIndex = 0;
            cB_nam.SelectedIndex = 0;
            cB_giaodich.SelectedIndex = 0;
            TimKiem.Text = "";
            LoadData();
        }

        private void b_csv_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo");
                return;
            }

            string tenFile = "GiaoDich";
            if (cB_thang.SelectedIndex > 0)
            {
                tenFile += "_T" + cB_thang.SelectedItem.ToString();
            }
            if (cB_nam.SelectedIndex > 0)
            {
                tenFile += "_" + cB_nam.SelectedItem.ToString();
            }
            if (cB_giaodich.SelectedIndex > 0)
            {
                tenFile += "_" + cB_giaodich.SelectedItem.ToString();
            }
            tenFile += "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = tenFile;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            sw.Write(dataGridView1.Columns[i].HeaderText);
                            if (i < dataGridView1.Columns.Count - 1)
                            {
                                sw.Write(",");
                            }
                        }
                        sw.WriteLine();

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                                {
                                    string val = row.Cells[i].Value != null ? row.Cells[i].Value.ToString().Replace(",", " ") : "";
                                    sw.Write(val);
                                    if (i < dataGridView1.Columns.Count - 1)
                                    {
                                        sw.Write(",");
                                    }
                                }
                                sw.WriteLine();
                            }
                        }
                    }
                    MessageBox.Show("Xuất file CSV thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất file CSV: " + ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void tongThuLabel_Click(object sender, EventArgs e)
        {
        }

        private void tongChiLabel_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
