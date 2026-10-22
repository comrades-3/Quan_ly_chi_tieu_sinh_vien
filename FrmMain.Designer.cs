namespace Quan_ly_chi_tieu_sinh_vien
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.btnDanhMuc = new FontAwesome.Sharp.IconButton();
            this.btnQuanLyThuChi = new FontAwesome.Sharp.IconButton();
            this.btnTongQuan = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.btnDangXuat);
            this.pnlSidebar.Controls.Add(this.btnDanhMuc);
            this.pnlSidebar.Controls.Add(this.btnQuanLyThuChi);
            this.pnlSidebar.Controls.Add(this.btnTongQuan);
            this.pnlSidebar.Controls.Add(this.btnMenu);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.FillColor = System.Drawing.SystemColors.ControlLight;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(220, 628);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnDangXuat.IconColor = System.Drawing.Color.Black;
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangXuat.IconSize = 22;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 578);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(220, 50);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnDanhMuc.IconColor = System.Drawing.Color.Black;
            this.btnDanhMuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDanhMuc.IconSize = 22;
            this.btnDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 145);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(220, 50);
            this.btnDanhMuc.TabIndex = 3;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnQuanLyThuChi
            // 
            this.btnQuanLyThuChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyThuChi.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            this.btnQuanLyThuChi.IconColor = System.Drawing.Color.Black;
            this.btnQuanLyThuChi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuanLyThuChi.IconSize = 22;
            this.btnQuanLyThuChi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyThuChi.Location = new System.Drawing.Point(0, 95);
            this.btnQuanLyThuChi.Name = "btnQuanLyThuChi";
            this.btnQuanLyThuChi.Size = new System.Drawing.Size(220, 50);
            this.btnQuanLyThuChi.TabIndex = 2;
            this.btnQuanLyThuChi.Text = "Quản lý thu chi";
            this.btnQuanLyThuChi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyThuChi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanLyThuChi.UseVisualStyleBackColor = true;
            this.btnQuanLyThuChi.Click += new System.EventHandler(this.btnQuanLyThuChi_Click);
            // 
            // btnTongQuan
            // 
            this.btnTongQuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTongQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongQuan.IconChar = FontAwesome.Sharp.IconChar.Gauge;
            this.btnTongQuan.IconColor = System.Drawing.Color.Black;
            this.btnTongQuan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTongQuan.IconSize = 22;
            this.btnTongQuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongQuan.Location = new System.Drawing.Point(0, 45);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTongQuan.Size = new System.Drawing.Size(220, 50);
            this.btnTongQuan.TabIndex = 1;
            this.btnTongQuan.Text = "Tổng quan";
            this.btnTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongQuan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTongQuan.UseVisualStyleBackColor = true;
            this.btnTongQuan.Click += new System.EventHandler(this.btnTongQuan_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 24;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(220, 45);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(220, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1025, 628);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 628);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng quan";
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlSidebar;
        private FontAwesome.Sharp.IconButton btnDanhMuc;
        private FontAwesome.Sharp.IconButton btnQuanLyThuChi;
        private FontAwesome.Sharp.IconButton btnTongQuan;
        private FontAwesome.Sharp.IconButton btnMenu;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private FontAwesome.Sharp.IconButton btnDangXuat;
    }
}