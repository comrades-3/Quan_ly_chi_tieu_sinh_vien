namespace Quan_ly_chi_tieu_sinh_vien
{
    partial class FrmTietKiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTietKiem = new System.Windows.Forms.DataGridView();
            this.grpThongTinChung = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenMucTieu = new System.Windows.Forms.TextBox();
            this.txtMaTietKiem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoTienMucTieu = new System.Windows.Forms.TextBox();
            this.txtSoTienHienCo = new System.Windows.Forms.TextBox();
            this.txtSoTienConThieu = new System.Windows.Forms.TextBox();
            this.txtTienDo = new System.Windows.Forms.TextBox();
            this.dtpNgayHan = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNap = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNapTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpThemMoi = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLuuThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpNgayHanMoi = new System.Windows.Forms.DateTimePicker();
            this.txtTenMucTieuMoi = new System.Windows.Forms.TextBox();
            this.txtSoTienMucTieuMoi = new System.Windows.Forms.TextBox();
            this.btnThemMucTieu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTietKiem)).BeginInit();
            this.grpThongTinChung.SuspendLayout();
            this.grpThemMoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(354, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = " Mục Tiêu Tiết Kiệm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvTietKiem
            // 
            this.dgvTietKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTietKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTietKiem.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvTietKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTietKiem.Location = new System.Drawing.Point(24, 417);
            this.dgvTietKiem.Name = "dgvTietKiem";
            this.dgvTietKiem.RowHeadersWidth = 51;
            this.dgvTietKiem.RowTemplate.Height = 24;
            this.dgvTietKiem.Size = new System.Drawing.Size(1028, 134);
            this.dgvTietKiem.TabIndex = 1;
            this.dgvTietKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTietKiem_CellClick);
            // 
            // grpThongTinChung
            // 
            this.grpThongTinChung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinChung.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpThongTinChung.Controls.Add(this.dtpNgayBatDau);
            this.grpThongTinChung.Controls.Add(this.label12);
            this.grpThongTinChung.Controls.Add(this.label11);
            this.grpThongTinChung.Controls.Add(this.txtNapTien);
            this.grpThongTinChung.Controls.Add(this.label9);
            this.grpThongTinChung.Controls.Add(this.btnNap);
            this.grpThongTinChung.Controls.Add(this.label8);
            this.grpThongTinChung.Controls.Add(this.dtpNgayHan);
            this.grpThongTinChung.Controls.Add(this.txtTienDo);
            this.grpThongTinChung.Controls.Add(this.txtSoTienConThieu);
            this.grpThongTinChung.Controls.Add(this.txtSoTienHienCo);
            this.grpThongTinChung.Controls.Add(this.txtSoTienMucTieu);
            this.grpThongTinChung.Controls.Add(this.label7);
            this.grpThongTinChung.Controls.Add(this.label6);
            this.grpThongTinChung.Controls.Add(this.label5);
            this.grpThongTinChung.Controls.Add(this.label4);
            this.grpThongTinChung.Controls.Add(this.txtMaTietKiem);
            this.grpThongTinChung.Controls.Add(this.txtTenMucTieu);
            this.grpThongTinChung.Controls.Add(this.label3);
            this.grpThongTinChung.Controls.Add(this.label2);
            this.grpThongTinChung.Location = new System.Drawing.Point(24, 74);
            this.grpThongTinChung.Name = "grpThongTinChung";
            this.grpThongTinChung.Size = new System.Drawing.Size(552, 301);
            this.grpThongTinChung.TabIndex = 2;
            this.grpThongTinChung.TabStop = false;
            this.grpThongTinChung.Text = "Thông tin chung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã tiết kiệm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên mục tiêu:";
            // 
            // txtTenMucTieu
            // 
            this.txtTenMucTieu.Location = new System.Drawing.Point(149, 26);
            this.txtTenMucTieu.Name = "txtTenMucTieu";
            this.txtTenMucTieu.ReadOnly = true;
            this.txtTenMucTieu.Size = new System.Drawing.Size(134, 22);
            this.txtTenMucTieu.TabIndex = 2;
            // 
            // txtMaTietKiem
            // 
            this.txtMaTietKiem.Location = new System.Drawing.Point(149, 66);
            this.txtMaTietKiem.Name = "txtMaTietKiem";
            this.txtMaTietKiem.ReadOnly = true;
            this.txtMaTietKiem.Size = new System.Drawing.Size(134, 22);
            this.txtMaTietKiem.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số tiền mục tiêu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số tiền hiện có:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số tiền còn thiếu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày hạn:";
            // 
            // txtSoTienMucTieu
            // 
            this.txtSoTienMucTieu.Location = new System.Drawing.Point(149, 110);
            this.txtSoTienMucTieu.Name = "txtSoTienMucTieu";
            this.txtSoTienMucTieu.ReadOnly = true;
            this.txtSoTienMucTieu.Size = new System.Drawing.Size(134, 22);
            this.txtSoTienMucTieu.TabIndex = 8;
            // 
            // txtSoTienHienCo
            // 
            this.txtSoTienHienCo.Location = new System.Drawing.Point(149, 150);
            this.txtSoTienHienCo.Name = "txtSoTienHienCo";
            this.txtSoTienHienCo.ReadOnly = true;
            this.txtSoTienHienCo.Size = new System.Drawing.Size(134, 22);
            this.txtSoTienHienCo.TabIndex = 9;
            // 
            // txtSoTienConThieu
            // 
            this.txtSoTienConThieu.Location = new System.Drawing.Point(149, 187);
            this.txtSoTienConThieu.Name = "txtSoTienConThieu";
            this.txtSoTienConThieu.ReadOnly = true;
            this.txtSoTienConThieu.Size = new System.Drawing.Size(134, 22);
            this.txtSoTienConThieu.TabIndex = 10;
            // 
            // txtTienDo
            // 
            this.txtTienDo.Location = new System.Drawing.Point(382, 26);
            this.txtTienDo.Name = "txtTienDo";
            this.txtTienDo.ReadOnly = true;
            this.txtTienDo.Size = new System.Drawing.Size(53, 22);
            this.txtTienDo.TabIndex = 11;
            // 
            // dtpNgayHan
            // 
            this.dtpNgayHan.Enabled = false;
            this.dtpNgayHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHan.Location = new System.Drawing.Point(144, 264);
            this.dtpNgayHan.Name = "dtpNgayHan";
            this.dtpNgayHan.Size = new System.Drawing.Size(134, 22);
            this.dtpNgayHan.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tiến độ:";
            // 
            // btnNap
            // 
            this.btnNap.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnNap.Location = new System.Drawing.Point(386, 230);
            this.btnNap.Name = "btnNap";
            this.btnNap.Size = new System.Drawing.Size(103, 40);
            this.btnNap.TabIndex = 14;
            this.btnNap.Text = "Nạp";
            this.btnNap.UseVisualStyleBackColor = false;
            this.btnNap.Click += new System.EventHandler(this.btnNapTien_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nạp tiền vào quỹ:";
            // 
            // txtNapTien
            // 
            this.txtNapTien.Location = new System.Drawing.Point(346, 187);
            this.txtNapTien.Name = "txtNapTien";
            this.txtNapTien.Size = new System.Drawing.Size(131, 22);
            this.txtNapTien.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Danh sách các mục tiêu tiết kiệm:";
            // 
            // grpThemMoi
            // 
            this.grpThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThemMoi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpThemMoi.Controls.Add(this.txtSoTienMucTieuMoi);
            this.grpThemMoi.Controls.Add(this.txtTenMucTieuMoi);
            this.grpThemMoi.Controls.Add(this.dtpNgayHanMoi);
            this.grpThemMoi.Controls.Add(this.label15);
            this.grpThemMoi.Controls.Add(this.label14);
            this.grpThemMoi.Controls.Add(this.label13);
            this.grpThemMoi.Controls.Add(this.btnLuuThem);
            this.grpThemMoi.Location = new System.Drawing.Point(582, 74);
            this.grpThemMoi.Name = "grpThemMoi";
            this.grpThemMoi.Size = new System.Drawing.Size(470, 301);
            this.grpThemMoi.TabIndex = 4;
            this.grpThemMoi.TabStop = false;
            this.grpThemMoi.Text = "Thêm mục tiêu tiết kiệm mới";
            this.grpThemMoi.Enter += new System.EventHandler(this.grpThemMoi_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(452, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "%";
            // 
            // btnLuuThem
            // 
            this.btnLuuThem.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnLuuThem.Location = new System.Drawing.Point(349, 257);
            this.btnLuuThem.Name = "btnLuuThem";
            this.btnLuuThem.Size = new System.Drawing.Size(103, 40);
            this.btnLuuThem.TabIndex = 5;
            this.btnLuuThem.Text = "Thêm";
            this.btnLuuThem.UseVisualStyleBackColor = false;
            this.btnLuuThem.Click += new System.EventHandler(this.btnLuuThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnXoa.Location = new System.Drawing.Point(759, 569);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 39);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnThoat.Location = new System.Drawing.Point(915, 569);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 39);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Ngày bắt đầu:";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Enabled = false;
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(144, 225);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(134, 22);
            this.dtpNgayBatDau.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Tên mục tiêu:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "Số tiền mục tiêu:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "Ngày hạn:";
            // 
            // dtpNgayHanMoi
            // 
            this.dtpNgayHanMoi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHanMoi.Location = new System.Drawing.Point(177, 148);
            this.dtpNgayHanMoi.Name = "dtpNgayHanMoi";
            this.dtpNgayHanMoi.Size = new System.Drawing.Size(144, 22);
            this.dtpNgayHanMoi.TabIndex = 9;
            // 
            // txtTenMucTieuMoi
            // 
            this.txtTenMucTieuMoi.Location = new System.Drawing.Point(177, 66);
            this.txtTenMucTieuMoi.Name = "txtTenMucTieuMoi";
            this.txtTenMucTieuMoi.Size = new System.Drawing.Size(144, 22);
            this.txtTenMucTieuMoi.TabIndex = 10;
            // 
            // txtSoTienMucTieuMoi
            // 
            this.txtSoTienMucTieuMoi.Location = new System.Drawing.Point(177, 104);
            this.txtSoTienMucTieuMoi.Name = "txtSoTienMucTieuMoi";
            this.txtSoTienMucTieuMoi.Size = new System.Drawing.Size(144, 22);
            this.txtSoTienMucTieuMoi.TabIndex = 11;
            // 
            // btnThemMucTieu
            // 
            this.btnThemMucTieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMucTieu.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnThemMucTieu.Location = new System.Drawing.Point(582, 569);
            this.btnThemMucTieu.Name = "btnThemMucTieu";
            this.btnThemMucTieu.Size = new System.Drawing.Size(103, 39);
            this.btnThemMucTieu.TabIndex = 8;
            this.btnThemMucTieu.Text = "Thêm mục tiêu";
            this.btnThemMucTieu.UseVisualStyleBackColor = false;
            this.btnThemMucTieu.Click += new System.EventHandler(this.btnThemMucTieu_Click);
            // 
            // FrmTietKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1057, 636);
            this.Controls.Add(this.btnThemMucTieu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grpThemMoi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grpThongTinChung);
            this.Controls.Add(this.dgvTietKiem);
            this.Controls.Add(this.label1);
            this.Name = "FrmTietKiem";
            this.Text = "FrmTietKiem";
            this.Load += new System.EventHandler(this.FrmTietKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTietKiem)).EndInit();
            this.grpThongTinChung.ResumeLayout(false);
            this.grpThongTinChung.PerformLayout();
            this.grpThemMoi.ResumeLayout(false);
            this.grpThemMoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTietKiem;
        private System.Windows.Forms.GroupBox grpThongTinChung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTietKiem;
        private System.Windows.Forms.TextBox txtTenMucTieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoTienConThieu;
        private System.Windows.Forms.TextBox txtSoTienHienCo;
        private System.Windows.Forms.TextBox txtSoTienMucTieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayHan;
        private System.Windows.Forms.TextBox txtTienDo;
        private System.Windows.Forms.TextBox txtNapTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpThemMoi;
        private System.Windows.Forms.Button btnLuuThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenMucTieuMoi;
        private System.Windows.Forms.DateTimePicker dtpNgayHanMoi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSoTienMucTieuMoi;
        private System.Windows.Forms.Button btnThemMucTieu;
    }
}