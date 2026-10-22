namespace Quan_ly_chi_tieu_sinh_vien
{
    partial class FrmTongQuan
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
            this.lblSubGreeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào! 👋";
            // 
            // lblSubGreeting
            // 
            this.lblSubGreeting.AutoSize = true;
            this.lblSubGreeting.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubGreeting.Location = new System.Drawing.Point(86, 74);
            this.lblSubGreeting.Name = "lblSubGreeting";
            this.lblSubGreeting.Size = new System.Drawing.Size(337, 44);
            this.lblSubGreeting.TabIndex = 1;
            this.lblSubGreeting.Text = "Tổng quan tình hình tài chính của bạn trong Tháng này";
            // 
            // FrmTongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 1222);
            this.Controls.Add(this.lblSubGreeting);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name = "FrmTongQuan";
            this.Text = "FrmTongQuan";
            this.Load += new System.EventHandler(this.FrmTongQuan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubGreeting;
    }
}