namespace Quan_ly_chi_tieu_sinh_vien
{
    partial class FrmQuenMatKhau
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacThuc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.txtXNMKM = new System.Windows.Forms.TextBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnLuuMKM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(406, 184);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(259, 29);
            this.txtEmail.TabIndex = 14;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(406, 123);
            this.txtTenTK.Multiline = true;
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(259, 29);
            this.txtTenTK.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email đăng ký:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên tài khoản:";
            // 
            // btnXacThuc
            // 
            this.btnXacThuc.Location = new System.Drawing.Point(162, 358);
            this.btnXacThuc.Name = "btnXacThuc";
            this.btnXacThuc.Size = new System.Drawing.Size(109, 44);
            this.btnXacThuc.TabIndex = 15;
            this.btnXacThuc.Text = "Xác thực";
            this.btnXacThuc.UseVisualStyleBackColor = true;
            this.btnXacThuc.Click += new System.EventHandler(this.btnXacThuc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(91, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(91, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Xác nhận lại mật khẩu mới:";
            // 
            // txtMKM
            // 
            this.txtMKM.Enabled = false;
            this.txtMKM.Location = new System.Drawing.Point(406, 246);
            this.txtMKM.Multiline = true;
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.PasswordChar = '*';
            this.txtMKM.Size = new System.Drawing.Size(259, 29);
            this.txtMKM.TabIndex = 18;
            // 
            // txtXNMKM
            // 
            this.txtXNMKM.Enabled = false;
            this.txtXNMKM.Location = new System.Drawing.Point(406, 302);
            this.txtXNMKM.Multiline = true;
            this.txtXNMKM.Name = "txtXNMKM";
            this.txtXNMKM.PasswordChar = '*';
            this.txtXNMKM.Size = new System.Drawing.Size(259, 29);
            this.txtXNMKM.TabIndex = 19;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(511, 358);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(98, 44);
            this.btnQuayLai.TabIndex = 20;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnLuuMKM
            // 
            this.btnLuuMKM.Location = new System.Drawing.Point(341, 358);
            this.btnLuuMKM.Name = "btnLuuMKM";
            this.btnLuuMKM.Size = new System.Drawing.Size(121, 44);
            this.btnLuuMKM.TabIndex = 21;
            this.btnLuuMKM.Text = "Lưu mật khẩu mới";
            this.btnLuuMKM.UseVisualStyleBackColor = true;
            this.btnLuuMKM.Click += new System.EventHandler(this.btnLuuMKM_Click);
            // 
            // FrmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLuuMKM);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.txtXNMKM);
            this.Controls.Add(this.txtMKM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXacThuc);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuenMatKhau";
            this.Text = "FrmQuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXacThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.TextBox txtXNMKM;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnLuuMKM;
    }
}