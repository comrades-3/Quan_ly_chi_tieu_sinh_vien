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
        private bool menuphongto = false;
        private const int MENU_BAN_DAU = 210;  
        private const int MENU_PHONG_TO = 265;

        public FrmDashboard()
        {
            InitializeComponent();
            btnMenu.IconChar = IconChar.Bars;
            btnMenu.IconColor = Color.White;
            btnMenu.IconSize = 22;
            btnMenu.Text = "";
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.BackColor = Color.FromArgb(23, 108, 165);
            pnlSidebar.Width = MENU_BAN_DAU;

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
            LoadForm(new FrmTongQuan());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuphongto = !menuphongto;
            pnlSidebar.Width = menuphongto ? MENU_PHONG_TO : MENU_BAN_DAU;
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
            this.Close();

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FrmBaoCao frmBaoCao = new FrmBaoCao();
            frmBaoCao.Show();
            this.Close();
        }

        private void btnTietKiem_Click(object sender, EventArgs e)
        {
            FrmTietKiem frmTietKiem = new FrmTietKiem();
            frmTietKiem.Show();
            this.Close();
        }
    }
}
