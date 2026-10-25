namespace Quan_ly_chi_tieu_sinh_vien
{
    partial class FrmBaoCao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.lblTongThu = new System.Windows.Forms.Label();
            this.lblTongChi = new System.Windows.Forms.Label();
            this.lblChenhLech = new System.Windows.Forms.Label();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.chartChi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(659, 19);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(134, 24);
            this.cboThang.TabIndex = 0;
            this.cboThang.Text = "Tháng";
            // 
            // cboNam
            // 
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(828, 19);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(134, 24);
            this.cboNam.TabIndex = 1;
            this.cboNam.Text = "Năm";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(996, 19);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(113, 54);
            this.btnXuatExcel.TabIndex = 2;
            this.btnXuatExcel.Text = "Xuất excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // lblTongThu
            // 
            this.lblTongThu.AutoSize = true;
            this.lblTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThu.Location = new System.Drawing.Point(123, 17);
            this.lblTongThu.Name = "lblTongThu";
            this.lblTongThu.Size = new System.Drawing.Size(64, 25);
            this.lblTongThu.TabIndex = 3;
            this.lblTongThu.Text = "label1";
            // 
            // lblTongChi
            // 
            this.lblTongChi.AutoSize = true;
            this.lblTongChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongChi.Location = new System.Drawing.Point(126, 17);
            this.lblTongChi.Name = "lblTongChi";
            this.lblTongChi.Size = new System.Drawing.Size(64, 25);
            this.lblTongChi.TabIndex = 4;
            this.lblTongChi.Text = "label2";
            // 
            // lblChenhLech
            // 
            this.lblChenhLech.AutoSize = true;
            this.lblChenhLech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChenhLech.Location = new System.Drawing.Point(150, 17);
            this.lblChenhLech.Name = "lblChenhLech";
            this.lblChenhLech.Size = new System.Drawing.Size(64, 25);
            this.lblChenhLech.TabIndex = 5;
            this.lblChenhLech.Text = "label3";
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Location = new System.Drawing.Point(56, 200);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.RowTemplate.Height = 24;
            this.dgvDanhMuc.Size = new System.Drawing.Size(1053, 263);
            this.dgvDanhMuc.TabIndex = 6;
            // 
            // chartChi
            // 
            this.chartChi.BorderlineColor = System.Drawing.Color.Black;
            this.chartChi.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartChi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartChi.Legends.Add(legend1);
            this.chartChi.Location = new System.Drawing.Point(56, 469);
            this.chartChi.Name = "chartChi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartChi.Series.Add(series1);
            this.chartChi.Size = new System.Drawing.Size(502, 265);
            this.chartChi.TabIndex = 7;
            this.chartChi.Text = "chart1";
            // 
            // chartThu
            // 
            this.chartThu.BorderlineColor = System.Drawing.Color.Black;
            this.chartThu.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chartThu.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartThu.Legends.Add(legend2);
            this.chartThu.Location = new System.Drawing.Point(605, 469);
            this.chartThu.Name = "chartThu";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartThu.Series.Add(series2);
            this.chartThu.Size = new System.Drawing.Size(504, 265);
            this.chartThu.TabIndex = 8;
            this.chartThu.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tổng thu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tổng chi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chêch lệch:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTongThu);
            this.panel1.Location = new System.Drawing.Point(56, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 58);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblTongChi);
            this.panel2.Location = new System.Drawing.Point(429, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 58);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblChenhLech);
            this.panel3.Location = new System.Drawing.Point(799, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 58);
            this.panel3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(50, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(422, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Báo cáo và phân tích tài chính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(52, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Thống kê chi tiết dòng tiền và xuất file excel";
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1142, 781);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartThu);
            this.Controls.Add(this.chartChi);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.cboThang);
            this.Name = "FrmBaoCao";
            this.Text = "FrmBaoCao";
            this.Load += new System.EventHandler(this.FrmBaoCao_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label lblTongThu;
        private System.Windows.Forms.Label lblTongChi;
        private System.Windows.Forms.Label lblChenhLech;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
