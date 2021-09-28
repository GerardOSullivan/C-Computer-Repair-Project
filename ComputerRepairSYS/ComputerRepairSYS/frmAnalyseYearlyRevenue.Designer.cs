namespace ComputerRepairSYS
{
    partial class frmAnalyseYearlyRevenue
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
            this.dtpAnalysisDate = new System.Windows.Forms.DateTimePicker();
            this.lblSelectReviewYear = new System.Windows.Forms.Label();
            this.mnuBackButton = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.chtRevenueAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mnuBackButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtRevenueAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpAnalysisDate
            // 
            this.dtpAnalysisDate.Location = new System.Drawing.Point(189, 45);
            this.dtpAnalysisDate.MinDate = new System.DateTime(2017, 4, 9, 0, 0, 0, 0);
            this.dtpAnalysisDate.Name = "dtpAnalysisDate";
            this.dtpAnalysisDate.Size = new System.Drawing.Size(93, 20);
            this.dtpAnalysisDate.TabIndex = 0;
            this.dtpAnalysisDate.Value = new System.DateTime(2021, 4, 22, 10, 22, 45, 0);
            this.dtpAnalysisDate.ValueChanged += new System.EventHandler(this.dtpAnalysisDate_ValueChanged);
            // 
            // lblSelectReviewYear
            // 
            this.lblSelectReviewYear.AutoSize = true;
            this.lblSelectReviewYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSelectReviewYear.Location = new System.Drawing.Point(35, 45);
            this.lblSelectReviewYear.Name = "lblSelectReviewYear";
            this.lblSelectReviewYear.Size = new System.Drawing.Size(151, 20);
            this.lblSelectReviewYear.TabIndex = 13;
            this.lblSelectReviewYear.Text = "Select Review Year:";
            // 
            // mnuBackButton
            // 
            this.mnuBackButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackButton.Location = new System.Drawing.Point(0, 0);
            this.mnuBackButton.Name = "mnuBackButton";
            this.mnuBackButton.Size = new System.Drawing.Size(1076, 29);
            this.mnuBackButton.TabIndex = 15;
            this.mnuBackButton.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(54, 25);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // chtRevenueAnalysis
            // 
            chartArea1.Name = "ChartArea1";
            this.chtRevenueAnalysis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtRevenueAnalysis.Legends.Add(legend1);
            this.chtRevenueAnalysis.Location = new System.Drawing.Point(39, 91);
            this.chtRevenueAnalysis.Name = "chtRevenueAnalysis";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtRevenueAnalysis.Series.Add(series1);
            this.chtRevenueAnalysis.Size = new System.Drawing.Size(984, 476);
            this.chtRevenueAnalysis.TabIndex = 16;
            this.chtRevenueAnalysis.Text = "RevenueAnalysisChart";
            // 
            // frmAnalyseYearlyRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 610);
            this.Controls.Add(this.chtRevenueAnalysis);
            this.Controls.Add(this.lblSelectReviewYear);
            this.Controls.Add(this.dtpAnalysisDate);
            this.Controls.Add(this.mnuBackButton);
            this.MainMenuStrip = this.mnuBackButton;
            this.Name = "frmAnalyseYearlyRevenue";
            this.Text = "Analyse Yearly Revenue";
            this.Load += new System.EventHandler(this.frmAnalyseYearlyRevenue_Load);
            this.mnuBackButton.ResumeLayout(false);
            this.mnuBackButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtRevenueAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpAnalysisDate;
        private System.Windows.Forms.Label lblSelectReviewYear;
        private System.Windows.Forms.MenuStrip mnuBackButton;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRevenueAnalysis;
    }
}