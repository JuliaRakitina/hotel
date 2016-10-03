namespace Resto.Plugin.Hotel
{
    partial class HotelPluginUserControl
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioModeMonths = new System.Windows.Forms.RadioButton();
            this.radioModeDays = new System.Windows.Forms.RadioButton();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBoxMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(160, 18);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(412, 28);
            this.cmbDepartment.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Подразделение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата с:";
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(160, 68);
            this.dtFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtFrom.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(193, 26);
            this.dtFrom.TabIndex = 3;
            this.dtFrom.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата по:";
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(162, 118);
            this.dtTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(192, 26);
            this.dtTo.TabIndex = 5;
            this.dtTo.Value = new System.DateTime(2500, 1, 1, 19, 8, 0, 0);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(24, 169);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 42);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Location = new System.Drawing.Point(24, 232);
            this.chart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart.Name = "chart";
            this.chart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.LabelFormat = "n2";
            series1.LabelToolTip = "#AXISLABEL: #VALY{n2}";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series1.Name = "SalesSeries";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(457, 241);
            this.chart.TabIndex = 7;
            this.chart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Задайте параметры отчета и нажмите кнопку Обновить";
            this.chart.Titles.Add(title1);
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.radioModeMonths);
            this.groupBoxMode.Controls.Add(this.radioModeDays);
            this.groupBoxMode.Location = new System.Drawing.Point(392, 60);
            this.groupBoxMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxMode.Size = new System.Drawing.Size(183, 102);
            this.groupBoxMode.TabIndex = 8;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Режим";
            // 
            // radioModeMonths
            // 
            this.radioModeMonths.AutoSize = true;
            this.radioModeMonths.Checked = true;
            this.radioModeMonths.Location = new System.Drawing.Point(10, 62);
            this.radioModeMonths.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioModeMonths.Name = "radioModeMonths";
            this.radioModeMonths.Size = new System.Drawing.Size(122, 24);
            this.radioModeMonths.TabIndex = 1;
            this.radioModeMonths.TabStop = true;
            this.radioModeMonths.Text = "по месяцам";
            this.radioModeMonths.UseVisualStyleBackColor = true;
            // 
            // radioModeDays
            // 
            this.radioModeDays.AutoSize = true;
            this.radioModeDays.Location = new System.Drawing.Point(10, 28);
            this.radioModeDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioModeDays.Name = "radioModeDays";
            this.radioModeDays.Size = new System.Drawing.Size(96, 24);
            this.radioModeDays.TabIndex = 0;
            this.radioModeDays.Text = "по дням";
            this.radioModeDays.UseVisualStyleBackColor = true;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(324, 547);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(200, 100);
            this.elementHost1.TabIndex = 9;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // SamplePluginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.groupBoxMode);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDepartment);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SamplePluginUserControl";
            this.Size = new System.Drawing.Size(1050, 769);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.RadioButton radioModeMonths;
        private System.Windows.Forms.RadioButton radioModeDays;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
    }
}
