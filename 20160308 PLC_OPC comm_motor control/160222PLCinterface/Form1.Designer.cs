namespace _160222PLCinterface
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.but_conn = new System.Windows.Forms.Button();
            this.but_read = new System.Windows.Forms.Button();
            this.but_write = new System.Windows.Forms.Button();
            this.tex_r1_value = new System.Windows.Forms.TextBox();
            this.tex_w1 = new System.Windows.Forms.TextBox();
            this.text_r1_quality = new System.Windows.Forms.TextBox();
            this.text_r1_timestamps = new System.Windows.Forms.TextBox();
            this.tex_r2_value = new System.Windows.Forms.TextBox();
            this.tex_r2_quality = new System.Windows.Forms.TextBox();
            this.tex_r2_timestamps = new System.Windows.Forms.TextBox();
            this.tex_w2 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_conn
            // 
            this.but_conn.Location = new System.Drawing.Point(47, 381);
            this.but_conn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.but_conn.Name = "but_conn";
            this.but_conn.Size = new System.Drawing.Size(140, 42);
            this.but_conn.TabIndex = 0;
            this.but_conn.Text = "Connect";
            this.but_conn.UseVisualStyleBackColor = true;
            this.but_conn.Click += new System.EventHandler(this.but_conn_Click);
            // 
            // but_read
            // 
            this.but_read.Location = new System.Drawing.Point(64, 481);
            this.but_read.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.but_read.Name = "but_read";
            this.but_read.Size = new System.Drawing.Size(86, 29);
            this.but_read.TabIndex = 1;
            this.but_read.Text = "Read";
            this.but_read.UseVisualStyleBackColor = true;
            // 
            // but_write
            // 
            this.but_write.Location = new System.Drawing.Point(64, 590);
            this.but_write.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.but_write.Name = "but_write";
            this.but_write.Size = new System.Drawing.Size(86, 29);
            this.but_write.TabIndex = 2;
            this.but_write.Text = "Write";
            this.but_write.UseVisualStyleBackColor = true;
            // 
            // tex_r1_value
            // 
            this.tex_r1_value.Location = new System.Drawing.Point(215, 481);
            this.tex_r1_value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tex_r1_value.Name = "tex_r1_value";
            this.tex_r1_value.Size = new System.Drawing.Size(114, 25);
            this.tex_r1_value.TabIndex = 3;
            // 
            // tex_w1
            // 
            this.tex_w1.Location = new System.Drawing.Point(215, 592);
            this.tex_w1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tex_w1.Name = "tex_w1";
            this.tex_w1.Size = new System.Drawing.Size(114, 25);
            this.tex_w1.TabIndex = 3;
            // 
            // text_r1_quality
            // 
            this.text_r1_quality.Location = new System.Drawing.Point(397, 481);
            this.text_r1_quality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_r1_quality.Name = "text_r1_quality";
            this.text_r1_quality.Size = new System.Drawing.Size(114, 25);
            this.text_r1_quality.TabIndex = 6;
            // 
            // text_r1_timestamps
            // 
            this.text_r1_timestamps.Location = new System.Drawing.Point(577, 480);
            this.text_r1_timestamps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text_r1_timestamps.Name = "text_r1_timestamps";
            this.text_r1_timestamps.Size = new System.Drawing.Size(114, 25);
            this.text_r1_timestamps.TabIndex = 7;
            // 
            // tex_r2_value
            // 
            this.tex_r2_value.Location = new System.Drawing.Point(215, 536);
            this.tex_r2_value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tex_r2_value.Name = "tex_r2_value";
            this.tex_r2_value.Size = new System.Drawing.Size(114, 25);
            this.tex_r2_value.TabIndex = 8;
            // 
            // tex_r2_quality
            // 
            this.tex_r2_quality.Location = new System.Drawing.Point(397, 535);
            this.tex_r2_quality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tex_r2_quality.Name = "tex_r2_quality";
            this.tex_r2_quality.Size = new System.Drawing.Size(114, 25);
            this.tex_r2_quality.TabIndex = 9;
            // 
            // tex_r2_timestamps
            // 
            this.tex_r2_timestamps.Location = new System.Drawing.Point(577, 533);
            this.tex_r2_timestamps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tex_r2_timestamps.Name = "tex_r2_timestamps";
            this.tex_r2_timestamps.Size = new System.Drawing.Size(114, 25);
            this.tex_r2_timestamps.TabIndex = 10;
            // 
            // tex_w2
            // 
            this.tex_w2.Location = new System.Drawing.Point(215, 646);
            this.tex_w2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tex_w2.Name = "tex_w2";
            this.tex_w2.Size = new System.Drawing.Size(114, 25);
            this.tex_w2.TabIndex = 11;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(47, 15);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(905, 347);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 708);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tex_w2);
            this.Controls.Add(this.tex_r2_timestamps);
            this.Controls.Add(this.tex_r2_quality);
            this.Controls.Add(this.tex_r2_value);
            this.Controls.Add(this.text_r1_timestamps);
            this.Controls.Add(this.text_r1_quality);
            this.Controls.Add(this.tex_w1);
            this.Controls.Add(this.tex_r1_value);
            this.Controls.Add(this.but_write);
            this.Controls.Add(this.but_read);
            this.Controls.Add(this.but_conn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_conn;
        private System.Windows.Forms.Button but_read;
        private System.Windows.Forms.Button but_write;
        private System.Windows.Forms.TextBox tex_r1_value;
        private System.Windows.Forms.TextBox tex_w1;
        private System.Windows.Forms.TextBox text_r1_quality;
        private System.Windows.Forms.TextBox text_r1_timestamps;
        private System.Windows.Forms.TextBox tex_r2_value;
        private System.Windows.Forms.TextBox tex_r2_quality;
        private System.Windows.Forms.TextBox tex_r2_timestamps;
        private System.Windows.Forms.TextBox tex_w2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

