namespace ComputerRepairSYS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnuMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddPart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdatePart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemovePart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListPart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepairs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEstimateRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommenceRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFinaliseRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDispatchRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalyseYearlyRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnalyseYearlyParts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.picRepairImageMain = new System.Windows.Forms.PictureBox();
            this.mnuMainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRepairImageMain)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenuStrip
            // 
            this.mnuMainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPartsToolStripMenuItem,
            this.mnuRepairs,
            this.adminToolStripMenuItem,
            this.mnuExit});
            this.mnuMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenuStrip.Name = "mnuMainMenuStrip";
            this.mnuMainMenuStrip.Size = new System.Drawing.Size(800, 27);
            this.mnuMainMenuStrip.TabIndex = 0;
            this.mnuMainMenuStrip.Text = "mnuMainMenuStrip";
            // 
            // mnuPartsToolStripMenuItem
            // 
            this.mnuPartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddPart,
            this.mnuUpdatePart,
            this.mnuRemovePart,
            this.mnuListPart});
            this.mnuPartsToolStripMenuItem.Name = "mnuPartsToolStripMenuItem";
            this.mnuPartsToolStripMenuItem.Size = new System.Drawing.Size(52, 23);
            this.mnuPartsToolStripMenuItem.Text = "Parts";
            // 
            // mnuAddPart
            // 
            this.mnuAddPart.Name = "mnuAddPart";
            this.mnuAddPart.Size = new System.Drawing.Size(156, 24);
            this.mnuAddPart.Text = "Add Part";
            this.mnuAddPart.Click += new System.EventHandler(this.mnuAddPart_Click);
            // 
            // mnuUpdatePart
            // 
            this.mnuUpdatePart.Name = "mnuUpdatePart";
            this.mnuUpdatePart.Size = new System.Drawing.Size(156, 24);
            this.mnuUpdatePart.Text = "Update Part";
            this.mnuUpdatePart.Click += new System.EventHandler(this.mnuUpdatePart_Click);
            // 
            // mnuRemovePart
            // 
            this.mnuRemovePart.Name = "mnuRemovePart";
            this.mnuRemovePart.Size = new System.Drawing.Size(156, 24);
            this.mnuRemovePart.Text = "Remove Part";
            this.mnuRemovePart.Click += new System.EventHandler(this.mnuRemovePart_Click);
            // 
            // mnuListPart
            // 
            this.mnuListPart.Name = "mnuListPart";
            this.mnuListPart.Size = new System.Drawing.Size(156, 24);
            this.mnuListPart.Text = "List Part";
            this.mnuListPart.Click += new System.EventHandler(this.mnuListPart_Click);
            // 
            // mnuRepairs
            // 
            this.mnuRepairs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogRepair,
            this.mnuEstimateRepair,
            this.mnuCommenceRepair,
            this.mnuFinaliseRepair,
            this.mnuDispatchRepair});
            this.mnuRepairs.Name = "mnuRepairs";
            this.mnuRepairs.Size = new System.Drawing.Size(65, 23);
            this.mnuRepairs.Text = "Repairs";
            // 
            // mnuLogRepair
            // 
            this.mnuLogRepair.Name = "mnuLogRepair";
            this.mnuLogRepair.Size = new System.Drawing.Size(189, 24);
            this.mnuLogRepair.Text = "Log Repair";
            this.mnuLogRepair.Click += new System.EventHandler(this.mnuLogRepair_Click);
            // 
            // mnuEstimateRepair
            // 
            this.mnuEstimateRepair.Name = "mnuEstimateRepair";
            this.mnuEstimateRepair.Size = new System.Drawing.Size(189, 24);
            this.mnuEstimateRepair.Text = "Estimate Repair";
            this.mnuEstimateRepair.Click += new System.EventHandler(this.mnuEstimateRepair_Click);
            // 
            // mnuCommenceRepair
            // 
            this.mnuCommenceRepair.Name = "mnuCommenceRepair";
            this.mnuCommenceRepair.Size = new System.Drawing.Size(189, 24);
            this.mnuCommenceRepair.Text = "Commence Repair";
            this.mnuCommenceRepair.Click += new System.EventHandler(this.mnuCommenceRepair_Click);
            // 
            // mnuFinaliseRepair
            // 
            this.mnuFinaliseRepair.Name = "mnuFinaliseRepair";
            this.mnuFinaliseRepair.Size = new System.Drawing.Size(189, 24);
            this.mnuFinaliseRepair.Text = "Finalise Repair";
            this.mnuFinaliseRepair.Click += new System.EventHandler(this.mnuFinaliseRepair_Click);
            // 
            // mnuDispatchRepair
            // 
            this.mnuDispatchRepair.Name = "mnuDispatchRepair";
            this.mnuDispatchRepair.Size = new System.Drawing.Size(189, 24);
            this.mnuDispatchRepair.Text = "Dispatch Repair";
            this.mnuDispatchRepair.Click += new System.EventHandler(this.mnuDispatchRepair_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAnalyseYearlyRevenue,
            this.mnuAnalyseYearlyParts});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // mnuAnalyseYearlyRevenue
            // 
            this.mnuAnalyseYearlyRevenue.Name = "mnuAnalyseYearlyRevenue";
            this.mnuAnalyseYearlyRevenue.Size = new System.Drawing.Size(236, 24);
            this.mnuAnalyseYearlyRevenue.Text = "Analyse Yearly Revenue";
            this.mnuAnalyseYearlyRevenue.Click += new System.EventHandler(this.mnuAnalyseYearlyRevenue_Click);
            // 
            // mnuAnalyseYearlyParts
            // 
            this.mnuAnalyseYearlyParts.Name = "mnuAnalyseYearlyParts";
            this.mnuAnalyseYearlyParts.Size = new System.Drawing.Size(236, 24);
            this.mnuAnalyseYearlyParts.Text = "Analyse Yearly Stock Sales";
            this.mnuAnalyseYearlyParts.Click += new System.EventHandler(this.mnuAnalyseYearlyParts_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(42, 23);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // picRepairImageMain
            // 
            this.picRepairImageMain.Image = ((System.Drawing.Image)(resources.GetObject("picRepairImageMain.Image")));
            this.picRepairImageMain.Location = new System.Drawing.Point(0, 30);
            this.picRepairImageMain.Name = "picRepairImageMain";
            this.picRepairImageMain.Size = new System.Drawing.Size(800, 423);
            this.picRepairImageMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRepairImageMain.TabIndex = 1;
            this.picRepairImageMain.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picRepairImageMain);
            this.Controls.Add(this.mnuMainMenuStrip);
            this.MainMenuStrip = this.mnuMainMenuStrip;
            this.Name = "frmMainMenu";
            this.Text = "ComputerRepairSYS";
            this.mnuMainMenuStrip.ResumeLayout(false);
            this.mnuMainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRepairImageMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuPartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuRepairs;
        private System.Windows.Forms.ToolStripMenuItem mnuLogRepair;
        private System.Windows.Forms.ToolStripMenuItem mnuEstimateRepair;
        private System.Windows.Forms.ToolStripMenuItem mnuCommenceRepair;
        private System.Windows.Forms.ToolStripMenuItem mnuFinaliseRepair;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalyseYearlyRevenue;
        private System.Windows.Forms.ToolStripMenuItem mnuAnalyseYearlyParts;
        private System.Windows.Forms.PictureBox picRepairImageMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuDispatchRepair;
        private System.Windows.Forms.ToolStripMenuItem mnuAddPart;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdatePart;
        private System.Windows.Forms.ToolStripMenuItem mnuRemovePart;
        private System.Windows.Forms.ToolStripMenuItem mnuListPart;
    }
}

