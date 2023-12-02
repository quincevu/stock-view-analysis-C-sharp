namespace COP_4635_Project_1
{
    partial class dojiChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDoji = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.comboBoxDoji = new System.Windows.Forms.ComboBox();
            this.labelDoji = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoji)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDoji
            // 
            this.chartDoji.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.ScaleView.MinSize = 1D;
            chartArea2.AxisX.ScaleView.SmallScrollMinSize = 0.1D;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.ScaleView.MinSize = 1D;
            chartArea2.AxisY.ScaleView.SmallScrollMinSize = 0.1D;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "OHLC";
            this.chartDoji.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDoji.Legends.Add(legend2);
            this.chartDoji.Location = new System.Drawing.Point(12, 4);
            this.chartDoji.Name = "chartDoji";
            series2.ChartArea = "OHLC";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series2.Legend = "Legend1";
            series2.Name = "OHLC";
            series2.YValuesPerPoint = 4;
            this.chartDoji.Series.Add(series2);
            this.chartDoji.Size = new System.Drawing.Size(1052, 460);
            this.chartDoji.TabIndex = 0;
            this.chartDoji.Text = "chartDoji";
            this.chartDoji.Click += new System.EventHandler(this.chart1_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(751, 491);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(187, 66);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.Text = "Return to Home";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxDoji
            // 
            this.comboBoxDoji.FormattingEnabled = true;
            this.comboBoxDoji.Location = new System.Drawing.Point(257, 522);
            this.comboBoxDoji.Name = "comboBoxDoji";
            this.comboBoxDoji.Size = new System.Drawing.Size(228, 24);
            this.comboBoxDoji.TabIndex = 3;
            this.comboBoxDoji.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoji_SelectedIndexChanged);
            // 
            // labelDoji
            // 
            this.labelDoji.AutoSize = true;
            this.labelDoji.Location = new System.Drawing.Point(179, 526);
            this.labelDoji.Name = "labelDoji";
            this.labelDoji.Size = new System.Drawing.Size(69, 16);
            this.labelDoji.TabIndex = 4;
            this.labelDoji.Text = "Doji Type:";
            // 
            // dojiChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 584);
            this.Controls.Add(this.labelDoji);
            this.Controls.Add(this.comboBoxDoji);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.chartDoji);
            this.Name = "dojiChart";
            this.Text = "dojiChart";
            this.Load += new System.EventHandler(this.dojiChart_Load);
            this.MouseEnter += new System.EventHandler(this.dojiChart_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chartDoji;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.ComboBox comboBoxDoji;
        private System.Windows.Forms.Label labelDoji;
    }
}