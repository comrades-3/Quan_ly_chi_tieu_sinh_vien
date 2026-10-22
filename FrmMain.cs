using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Quan_ly_chi_tieu_sinh_vien
{
    public partial class FrmDashboard : Form
    {
        private bool menuThuGon = false;

        public FrmDashboard()
        {
            InitializeComponent();
            btnMenu.IconChar = IconChar.Bars;
            btnMenu.IconColor = Color.White;
            btnMenu.IconSize = 24;
            btnMenu.Text = "";
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.BackColor = Color.FromArgb(23, 108, 165);
            LoadForm(new FrmTongQuan());
        }


        private void LoadForm(Form frm)
        {
            if (frm == this)
                return;

            pnlMain.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(frm);
            frm.Show();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            // Tổng quan là form chính, chỉ cần xóa nội dung panel để về trang chủ
            LoadForm(new FrmTongQuan());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuThuGon = !menuThuGon;

            pnlSidebar.Width = menuThuGon ? 60 : 220;

            btnTongQuan.Text = menuThuGon ? "" : "Tổng quan";
            btnQuanLyThuChi.Text = menuThuGon ? "" : "Quản lý thu chi";
            btnDanhMuc.Text = menuThuGon ? "" : "Danh mục";
            btnDangXuat.Text = menuThuGon ? "" : "Đăng xuất";
        }

        private void btnQuanLyThuChi_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmQuanLyThuChi());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            LoadForm(new FrmDanhMuc());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
            this.Hide();

        }
    }
}
