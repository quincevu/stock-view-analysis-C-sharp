namespace COP_4635_Project_1
{
    partial class Form1
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
            this.radioButtonDaily = new System.Windows.Forms.RadioButton();
            this.groupBoxTimePeriod = new System.Windows.Forms.GroupBox();
            this.radioButtonMonthly = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekly = new System.Windows.Forms.RadioButton();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStockTicker = new System.Windows.Forms.Label();
            this.comboBoxTicker = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxTimePeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonDaily
            // 
            this.radioButtonDaily.AutoSize = true;
            this.radioButtonDaily.Location = new System.Drawing.Point(6, 21);
            this.radioButtonDaily.Name = "radioButtonDaily";
            this.radioButtonDaily.Size = new System.Drawing.Size(59, 20);
            this.radioButtonDaily.TabIndex = 3;
            this.radioButtonDaily.Text = "Daily";
            this.radioButtonDaily.UseVisualStyleBackColor = true;
            this.radioButtonDaily.CheckedChanged += new System.EventHandler(this.radioButtonDaily_CheckedChanged);
            // 
            // groupBoxTimePeriod
            // 
            this.groupBoxTimePeriod.Controls.Add(this.radioButtonMonthly);
            this.groupBoxTimePeriod.Controls.Add(this.radioButtonWeekly);
            this.groupBoxTimePeriod.Controls.Add(this.radioButtonDaily);
            this.groupBoxTimePeriod.Location = new System.Drawing.Point(26, 183);
            this.groupBoxTimePeriod.Name = "groupBoxTimePeriod";
            this.groupBoxTimePeriod.Size = new System.Drawing.Size(197, 144);
            this.groupBoxTimePeriod.TabIndex = 4;
            this.groupBoxTimePeriod.TabStop = false;
            this.groupBoxTimePeriod.Text = "Time Period";
            this.groupBoxTimePeriod.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonMonthly
            // 
            this.radioButtonMonthly.AutoSize = true;
            this.radioButtonMonthly.Location = new System.Drawing.Point(6, 73);
            this.radioButtonMonthly.Name = "radioButtonMonthly";
            this.radioButtonMonthly.Size = new System.Drawing.Size(67, 20);
            this.radioButtonMonthly.TabIndex = 6;
            this.radioButtonMonthly.Text = "Montly";
            this.radioButtonMonthly.UseVisualStyleBackColor = true;
            this.radioButtonMonthly.CheckedChanged += new System.EventHandler(this.radioButtonMonthly_CheckedChanged);
            // 
            // radioButtonWeekly
            // 
            this.radioButtonWeekly.AutoSize = true;
            this.radioButtonWeekly.Location = new System.Drawing.Point(6, 47);
            this.radioButtonWeekly.Name = "radioButtonWeekly";
            this.radioButtonWeekly.Size = new System.Drawing.Size(74, 20);
            this.radioButtonWeekly.TabIndex = 6;
            this.radioButtonWeekly.Text = "Weekly";
            this.radioButtonWeekly.UseVisualStyleBackColor = true;
            this.radioButtonWeekly.CheckedChanged += new System.EventHandler(this.radioButtonWeekly_CheckedChanged);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(77, 343);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(359, 122);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load Selected Data";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(102, 77);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(233, 22);
            this.dateTimePickerStart.TabIndex = 8;
            this.dateTimePickerStart.Value = new System.DateTime(2022, 1, 3, 0, 0, 0, 0);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(102, 130);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(233, 22);
            this.dateTimePickerEnd.TabIndex = 9;
            this.dateTimePickerEnd.Value = new System.DateTime(2022, 12, 30, 0, 0, 0, 0);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.labelStart.Location = new System.Drawing.Point(18, 77);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(78, 18);
            this.labelStart.TabIndex = 11;
            this.labelStart.Text = "Start Date:";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.labelEnd.Location = new System.Drawing.Point(23, 130);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(73, 18);
            this.labelEnd.TabIndex = 12;
            this.labelEnd.Text = "End Date:";
            this.labelEnd.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelStockTicker
            // 
            this.labelStockTicker.AutoSize = true;
            this.labelStockTicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.labelStockTicker.Location = new System.Drawing.Point(258, 205);
            this.labelStockTicker.Name = "labelStockTicker";
            this.labelStockTicker.Size = new System.Drawing.Size(96, 18);
            this.labelStockTicker.TabIndex = 14;
            this.labelStockTicker.Text = "Stock Ticker:";
            this.labelStockTicker.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxTicker
            // 
            this.comboBoxTicker.FormattingEnabled = true;
            this.comboBoxTicker.Location = new System.Drawing.Point(360, 205);
            this.comboBoxTicker.Name = "comboBoxTicker";
            this.comboBoxTicker.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTicker.TabIndex = 15;
            this.comboBoxTicker.SelectedIndexChanged += new System.EventHandler(this.comboBoxTicker_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxTicker);
            this.Controls.Add(this.labelStockTicker);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.groupBoxTimePeriod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTimePeriod.ResumeLayout(false);
            this.groupBoxTimePeriod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonDaily;
        private System.Windows.Forms.GroupBox groupBoxTimePeriod;
        private System.Windows.Forms.RadioButton radioButtonMonthly;
        private System.Windows.Forms.RadioButton radioButtonWeekly;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStockTicker;
        private System.Windows.Forms.ComboBox comboBoxTicker;
        private System.Windows.Forms.Button button1;
    }
}

