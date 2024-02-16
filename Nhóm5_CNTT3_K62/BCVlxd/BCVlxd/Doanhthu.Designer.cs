namespace BCVlxd
{
    partial class Doanhthu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.lbNhapkho = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbXuatkho = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbSpkho = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbDoanhthu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(880, 400);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Tổng tiền nhập kho theo tháng";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.BorderRadius = 10;
            this.button1.BorderThickness = 1;
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.FillColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(916, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 45);
            this.button1.TabIndex = 88;
            this.button1.Text = "Tổng tiền nhập kho";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(0, 428);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(880, 400);
            this.chart2.TabIndex = 89;
            this.chart2.Text = "chart2";
            title2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Tổng tiền xuất kho từng tháng";
            this.chart2.Titles.Add(title2);
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Location = new System.Drawing.Point(916, 209);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(232, 45);
            this.guna2Button1.TabIndex = 88;
            this.guna2Button1.Text = "Tổng tiền xuất kho";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button2.Location = new System.Drawing.Point(916, 284);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(232, 45);
            this.guna2Button2.TabIndex = 88;
            this.guna2Button2.Text = "Tổng tiền hàng hóa kho";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button3.Location = new System.Drawing.Point(916, 413);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(232, 45);
            this.guna2Button3.TabIndex = 88;
            this.guna2Button3.Text = "Doanh thu";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // lbNhapkho
            // 
            this.lbNhapkho.BackColor = System.Drawing.Color.Transparent;
            this.lbNhapkho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapkho.Location = new System.Drawing.Point(1186, 145);
            this.lbNhapkho.Name = "lbNhapkho";
            this.lbNhapkho.Size = new System.Drawing.Size(86, 30);
            this.lbNhapkho.TabIndex = 90;
            this.lbNhapkho.Text = "Tổng tiền";
            // 
            // lbXuatkho
            // 
            this.lbXuatkho.BackColor = System.Drawing.Color.Transparent;
            this.lbXuatkho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXuatkho.Location = new System.Drawing.Point(1186, 215);
            this.lbXuatkho.Name = "lbXuatkho";
            this.lbXuatkho.Size = new System.Drawing.Size(86, 30);
            this.lbXuatkho.TabIndex = 90;
            this.lbXuatkho.Text = "Tổng tiền";
            // 
            // lbSpkho
            // 
            this.lbSpkho.BackColor = System.Drawing.Color.Transparent;
            this.lbSpkho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSpkho.Location = new System.Drawing.Point(1186, 290);
            this.lbSpkho.Name = "lbSpkho";
            this.lbSpkho.Size = new System.Drawing.Size(86, 30);
            this.lbSpkho.TabIndex = 90;
            this.lbSpkho.Text = "Tổng tiền";
            // 
            // lbDoanhthu
            // 
            this.lbDoanhthu.BackColor = System.Drawing.Color.Transparent;
            this.lbDoanhthu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanhthu.Location = new System.Drawing.Point(1186, 418);
            this.lbDoanhthu.Name = "lbDoanhthu";
            this.lbDoanhthu.Size = new System.Drawing.Size(86, 30);
            this.lbDoanhthu.TabIndex = 90;
            this.lbDoanhthu.Text = "Tổng tiền";
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.White;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button4.Location = new System.Drawing.Point(916, 617);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(232, 45);
            this.guna2Button4.TabIndex = 88;
            this.guna2Button4.Text = "Quản lý sản phẩm";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // Doanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbDoanhthu);
            this.Controls.Add(this.lbSpkho);
            this.Controls.Add(this.lbXuatkho);
            this.Controls.Add(this.lbNhapkho);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Doanhthu";
            this.Size = new System.Drawing.Size(1400, 828);
            this.Load += new System.EventHandler(this.Doanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbNhapkho;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbXuatkho;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbSpkho;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbDoanhthu;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
    }
}
