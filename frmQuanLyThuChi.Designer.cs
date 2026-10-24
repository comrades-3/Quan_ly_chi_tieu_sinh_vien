namespace Quan_ly_chi_tieu_sinh_vien
{
    partial class FrmQuanLyThuChi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cB_thang = new System.Windows.Forms.ComboBox();
            this.cB_giaodich = new System.Windows.Forms.ComboBox();
            this.cB_nam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimKiem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_them = new System.Windows.Forms.Button();
            this.b_sua = new System.Windows.Forms.Button();
            this.b_xoa = new System.Windows.Forms.Button();
            this.b_load = new System.Windows.Forms.Button();
            this.b_csv = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.b_timkiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tongThuLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tongChiLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tongThuLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(179, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tongChiLabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(535, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(899, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 100);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản Lí Thu Chi";
            // 
            // cB_thang
            // 
            this.cB_thang.FormattingEnabled = true;
            this.cB_thang.Location = new System.Drawing.Point(28, 48);
            this.cB_thang.Name = "cB_thang";
            this.cB_thang.Size = new System.Drawing.Size(121, 24);
            this.cB_thang.TabIndex = 3;
            this.cB_thang.SelectedIndexChanged += new System.EventHandler(this.cB_thang_SelectedIndexChanged);
            // 
            // cB_giaodich
            // 
            this.cB_giaodich.FormattingEnabled = true;
            this.cB_giaodich.Location = new System.Drawing.Point(373, 48);
            this.cB_giaodich.Name = "cB_giaodich";
            this.cB_giaodich.Size = new System.Drawing.Size(121, 24);
            this.cB_giaodich.TabIndex = 4;
            this.cB_giaodich.SelectedIndexChanged += new System.EventHandler(this.cB_giaodich_SelectedIndexChanged);
            // 
            // cB_nam
            // 
            this.cB_nam.FormattingEnabled = true;
            this.cB_nam.Location = new System.Drawing.Point(199, 48);
            this.cB_nam.Name = "cB_nam";
            this.cB_nam.Size = new System.Drawing.Size(121, 24);
            this.cB_nam.TabIndex = 5;
            this.cB_nam.SelectedIndexChanged += new System.EventHandler(this.cB_nam_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Năm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Loại giao dịch";
            // 
            // TimKiem
            // 
            this.TimKiem.Location = new System.Drawing.Point(839, 280);
            this.TimKiem.Multiline = true;
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(268, 29);
            this.TimKiem.TabIndex = 9;
            this.TimKiem.TextChanged += new System.EventHandler(this.TimKiem_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(193, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(941, 234);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // b_them
            // 
            this.b_them.BackColor = System.Drawing.Color.Green;
            this.b_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_them.ForeColor = System.Drawing.Color.White;
            this.b_them.Location = new System.Drawing.Point(405, 12);
            this.b_them.Name = "b_them";
            this.b_them.Size = new System.Drawing.Size(75, 30);
            this.b_them.TabIndex = 12;
            this.b_them.Text = "Thêm ";
            this.b_them.UseVisualStyleBackColor = false;
            this.b_them.Click += new System.EventHandler(this.b_them_Click);
            // 
            // b_sua
            // 
            this.b_sua.Location = new System.Drawing.Point(520, 12);
            this.b_sua.Name = "b_sua";
            this.b_sua.Size = new System.Drawing.Size(75, 30);
            this.b_sua.TabIndex = 12;
            this.b_sua.Text = "Sửa";
            this.b_sua.UseVisualStyleBackColor = true;
            this.b_sua.Click += new System.EventHandler(this.b_sua_Click);
            // 
            // b_xoa
            // 
            this.b_xoa.BackColor = System.Drawing.Color.White;
            this.b_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_xoa.ForeColor = System.Drawing.Color.Red;
            this.b_xoa.Location = new System.Drawing.Point(631, 12);
            this.b_xoa.Name = "b_xoa";
            this.b_xoa.Size = new System.Drawing.Size(75, 30);
            this.b_xoa.TabIndex = 13;
            this.b_xoa.Text = "Xóa";
            this.b_xoa.UseVisualStyleBackColor = false;
            this.b_xoa.Click += new System.EventHandler(this.b_xoa_Click);
            // 
            // b_load
            // 
            this.b_load.Location = new System.Drawing.Point(737, 14);
            this.b_load.Name = "b_load";
            this.b_load.Size = new System.Drawing.Size(75, 30);
            this.b_load.TabIndex = 14;
            this.b_load.Text = "Tải lại";
            this.b_load.UseVisualStyleBackColor = true;
            this.b_load.Click += new System.EventHandler(this.b_load_Click);
            // 
            // b_csv
            // 
            this.b_csv.Location = new System.Drawing.Point(852, 12);
            this.b_csv.Name = "b_csv";
            this.b_csv.Size = new System.Drawing.Size(75, 30);
            this.b_csv.TabIndex = 15;
            this.b_csv.Text = "Xuất CSV";
            this.b_csv.UseVisualStyleBackColor = true;
            this.b_csv.Click += new System.EventHandler(this.b_csv_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(836, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tìm Kiếm";
            // 
            // b_timkiem
            // 
            this.b_timkiem.Location = new System.Drawing.Point(565, 42);
            this.b_timkiem.Name = "b_timkiem";
            this.b_timkiem.Size = new System.Drawing.Size(75, 30);
            this.b_timkiem.TabIndex = 17;
            this.b_timkiem.Text = "Tìm Kiếm";
            this.b_timkiem.UseVisualStyleBackColor = true;
            this.b_timkiem.Click += new System.EventHandler(this.b_timkiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_timkiem);
            this.groupBox1.Controls.Add(this.cB_thang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cB_nam);
            this.groupBox1.Controls.Add(this.cB_giaodich);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(179, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 89);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "TỔNG THU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "TỔNG CHI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_them);
            this.groupBox2.Controls.Add(this.b_sua);
            this.groupBox2.Controls.Add(this.b_csv);
            this.groupBox2.Controls.Add(this.b_xoa);
            this.groupBox2.Controls.Add(this.b_load);
            this.groupBox2.Location = new System.Drawing.Point(179, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(967, 295);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Giao Dịch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "SỐ DƯ";
            // 
            // tongThuLabel
            // 
            this.tongThuLabel.AutoSize = true;
            this.tongThuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongThuLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tongThuLabel.Location = new System.Drawing.Point(22, 39);
            this.tongThuLabel.Name = "tongThuLabel";
            this.tongThuLabel.Size = new System.Drawing.Size(56, 32);
            this.tongThuLabel.TabIndex = 19;
            this.tongThuLabel.Text = "0 đ";
            this.tongThuLabel.Click += new System.EventHandler(this.tongThuLabel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(25, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 32);
            this.label10.TabIndex = 20;
            this.label10.Text = "0 đ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tongChiLabel
            // 
            this.tongChiLabel.AutoSize = true;
            this.tongChiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongChiLabel.ForeColor = System.Drawing.Color.Red;
            this.tongChiLabel.Location = new System.Drawing.Point(25, 39);
            this.tongChiLabel.Name = "tongChiLabel";
            this.tongChiLabel.Size = new System.Drawing.Size(56, 32);
            this.tongChiLabel.TabIndex = 21;
            this.tongChiLabel.Text = "0 đ";
            this.tongChiLabel.Click += new System.EventHandler(this.tongChiLabel_Click);
            // 
            // FrmQuanLyThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 665);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmQuanLyThuChi";
            this.Text = "frmQuanLyThuChi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cB_thang;
        private System.Windows.Forms.ComboBox cB_giaodich;
        private System.Windows.Forms.ComboBox cB_nam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TimKiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_them;
        private System.Windows.Forms.Button b_sua;
        private System.Windows.Forms.Button b_xoa;
        private System.Windows.Forms.Button b_load;
        private System.Windows.Forms.Button b_csv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_timkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label tongThuLabel;
        private System.Windows.Forms.Label tongChiLabel;
        private System.Windows.Forms.Label label10;
    }
}