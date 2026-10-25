namespace Quan_ly_chi_tieu_sinh_vien
{
    partial class FrmThemSuaGiaoDich
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rB_chitieu = new System.Windows.Forms.RadioButton();
            this.rB_thunhap = new System.Windows.Forms.RadioButton();
            this.cB_danhmuc = new System.Windows.Forms.ComboBox();
            this.tB_sotien = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tb_ghichu = new System.Windows.Forms.TextBox();
            this.b_huy = new System.Windows.Forms.Button();
            this.b_luu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm / Sửa Giao Dịch";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_ghichu);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.tB_sotien);
            this.groupBox1.Controls.Add(this.cB_danhmuc);
            this.groupBox1.Controls.Add(this.rB_thunhap);
            this.groupBox1.Controls.Add(this.rB_chitieu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 476);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giao dịch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại giao dịch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Danh mục:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số tiền (VNĐ):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày giao dịch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ghi chú:";
            // 
            // rB_chitieu
            // 
            this.rB_chitieu.AutoSize = true;
            this.rB_chitieu.Checked = true;
            this.rB_chitieu.Location = new System.Drawing.Point(106, 56);
            this.rB_chitieu.Name = "rB_chitieu";
            this.rB_chitieu.Size = new System.Drawing.Size(71, 20);
            this.rB_chitieu.TabIndex = 7;
            this.rB_chitieu.TabStop = true;
            this.rB_chitieu.Text = "Chi tiêu";
            this.rB_chitieu.UseVisualStyleBackColor = true;
            this.rB_chitieu.CheckedChanged += new System.EventHandler(this.rB_chitieu_CheckedChanged);
            // 
            // rB_thunhap
            // 
            this.rB_thunhap.AutoSize = true;
            this.rB_thunhap.Location = new System.Drawing.Point(209, 56);
            this.rB_thunhap.Name = "rB_thunhap";
            this.rB_thunhap.Size = new System.Drawing.Size(84, 20);
            this.rB_thunhap.TabIndex = 8;
            this.rB_thunhap.Text = "Thu nhập";
            this.rB_thunhap.UseVisualStyleBackColor = true;
            this.rB_thunhap.CheckedChanged += new System.EventHandler(this.rB_thunhap_CheckedChanged);
            // 
            // cB_danhmuc
            // 
            this.cB_danhmuc.FormattingEnabled = true;
            this.cB_danhmuc.Location = new System.Drawing.Point(106, 113);
            this.cB_danhmuc.Name = "cB_danhmuc";
            this.cB_danhmuc.Size = new System.Drawing.Size(129, 24);
            this.cB_danhmuc.TabIndex = 9;
            this.cB_danhmuc.SelectedIndexChanged += new System.EventHandler(this.cB_danhmuc_SelectedIndexChanged);
            // 
            // tB_sotien
            // 
            this.tB_sotien.Location = new System.Drawing.Point(106, 182);
            this.tB_sotien.Name = "tB_sotien";
            this.tB_sotien.Size = new System.Drawing.Size(200, 22);
            this.tB_sotien.TabIndex = 10;
            this.tB_sotien.TextChanged += new System.EventHandler(this.tB_sotien_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 242);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tb_ghichu
            // 
            this.tb_ghichu.Location = new System.Drawing.Point(106, 322);
            this.tb_ghichu.Multiline = true;
            this.tb_ghichu.Name = "tb_ghichu";
            this.tb_ghichu.Size = new System.Drawing.Size(200, 138);
            this.tb_ghichu.TabIndex = 12;
            this.tb_ghichu.TextChanged += new System.EventHandler(this.tb_ghichu_TextChanged);
            // 
            // b_huy
            // 
            this.b_huy.Location = new System.Drawing.Point(204, 540);
            this.b_huy.Name = "b_huy";
            this.b_huy.Size = new System.Drawing.Size(75, 23);
            this.b_huy.TabIndex = 3;
            this.b_huy.Text = "Hủy";
            this.b_huy.UseVisualStyleBackColor = true;
            this.b_huy.Click += new System.EventHandler(this.b_huy_Click);
            // 
            // b_luu
            // 
            this.b_luu.Location = new System.Drawing.Point(300, 540);
            this.b_luu.Name = "b_luu";
            this.b_luu.Size = new System.Drawing.Size(75, 23);
            this.b_luu.TabIndex = 4;
            this.b_luu.Text = "Lưu";
            this.b_luu.UseVisualStyleBackColor = true;
            this.b_luu.Click += new System.EventHandler(this.b_luu_Click);
            // 
            // FrmThemSuaGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 575);
            this.Controls.Add(this.b_luu);
            this.Controls.Add(this.b_huy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmThemSuaGiaoDich";
            this.Text = "FrmThemSuaGiaoDich";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ghichu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tB_sotien;
        private System.Windows.Forms.ComboBox cB_danhmuc;
        private System.Windows.Forms.RadioButton rB_thunhap;
        private System.Windows.Forms.RadioButton rB_chitieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_huy;
        private System.Windows.Forms.Button b_luu;
    }
}