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
            this.chartThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThang)).BeginInit();
            this.SuspendLayout();
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(238, 12);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(121, 24);
            this.cboThang.TabIndex = 0;
            // 
            // cboNam
            // 
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(450, 12);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(121, 24);
            this.cboNam.TabIndex = 1;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(659, 5);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(98, 37);
            this.btnXuatExcel.TabIndex = 2;
            this.btnXuatExcel.Text = "Xuất excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // lblTongThu
            // 
            this.lblTongThu.AutoSize = true;
            this.lblTongThu.Location = new System.Drawing.Point(315, 54);
            this.lblTongThu.Name = "lblTongThu";
            this.lblTongThu.Size = new System.Drawing.Size(44, 16);
            this.lblTongThu.TabIndex = 3;
            this.lblTongThu.Text = "label1";
            // 
            // lblTongChi
            // 
            this.lblTongChi.AutoSize = true;
            this.lblTongChi.Location = new System.Drawing.Point(510, 54);
            this.lblTongChi.Name = "lblTongChi";
            this.lblTongChi.Size = new System.Drawing.Size(44, 16);
            this.lblTongChi.TabIndex = 4;
            this.lblTongChi.Text = "label2";
            // 
            // lblChenhLech
            // 
            this.lblChenhLech.AutoSize = true;
            this.lblChenhLech.Location = new System.Drawing.Point(713, 54);
            this.lblChenhLech.Name = "lblChenhLech";
            this.lblChenhLech.Size = new System.Drawing.Size(44, 16);
            this.lblChenhLech.TabIndex = 5;
            this.lblChenhLech.Text = "label3";
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Location = new System.Drawing.Point(238, 100);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.RowTemplate.Height = 24;
            this.dgvDanhMuc.Size = new System.Drawing.Size(519, 150);
            this.dgvDanhMuc.TabIndex = 6;
            // 
            // chartChi
            // 
            chartArea1.Name = "ChartArea1";
            this.chartChi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartChi.Legends.Add(legend1);
            this.chartChi.Location = new System.Drawing.Point(238, 266);
            this.chartChi.Name = "chartChi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartChi.Series.Add(series1);
            this.chartChi.Size = new System.Drawing.Size(519, 199);
            this.chartChi.TabIndex = 7;
            this.chartChi.Text = "chart1";
            // 
            // chartThang
            // 
            chartArea2.Name = "ChartArea1";
            this.chartThang.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartThang.Legends.Add(legend2);
            this.chartThang.Location = new System.Drawing.Point(238, 486);
            this.chartThang.Name = "chartThang";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartThang.Series.Add(series2);
            this.chartThang.Size = new System.Drawing.Size(519, 215);
            this.chartThang.TabIndex = 8;
            this.chartThang.Text = "chart2";
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.chartThang);
            this.Controls.Add(this.chartChi);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.lblChenhLech);
            this.Controls.Add(this.lblTongChi);
            this.Controls.Add(this.lblTongThu);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.cboThang);
            this.Name = "FrmBaoCao";
            this.Text = "FrmBaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThang)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThang;
    }
}