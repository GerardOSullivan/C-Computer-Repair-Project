namespace ComputerRepairSYS
{
    partial class frmListPart
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
            this.txtSearchPartName = new System.Windows.Forms.TextBox();
            this.lblSearchPartName = new System.Windows.Forms.Label();
            this.lstParts = new System.Windows.Forms.ListBox();
            this.btnListPart = new System.Windows.Forms.Button();
            this.mnuBackButton = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpListItems = new System.Windows.Forms.GroupBox();
            this.lblPartIDAndName = new System.Windows.Forms.Label();
            this.btnListAllParts = new System.Windows.Forms.Button();
            this.mnuBackButton.SuspendLayout();
            this.grpListItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchPartName
            // 
            this.txtSearchPartName.Location = new System.Drawing.Point(305, 44);
            this.txtSearchPartName.MaxLength = 20;
            this.txtSearchPartName.Name = "txtSearchPartName";
            this.txtSearchPartName.Size = new System.Drawing.Size(153, 20);
            this.txtSearchPartName.TabIndex = 12;
            this.txtSearchPartName.TextChanged += new System.EventHandler(this.txtSearchPartName_TextChanged);
            // 
            // lblSearchPartName
            // 
            this.lblSearchPartName.AutoSize = true;
            this.lblSearchPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearchPartName.Location = new System.Drawing.Point(137, 44);
            this.lblSearchPartName.Name = "lblSearchPartName";
            this.lblSearchPartName.Size = new System.Drawing.Size(143, 20);
            this.lblSearchPartName.TabIndex = 11;
            this.lblSearchPartName.Text = "Search Part Name:";
            // 
            // lstParts
            // 
            this.lstParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstParts.FormattingEnabled = true;
            this.lstParts.ItemHeight = 20;
            this.lstParts.Location = new System.Drawing.Point(34, 61);
            this.lstParts.Name = "lstParts";
            this.lstParts.Size = new System.Drawing.Size(333, 164);
            this.lstParts.TabIndex = 10;
            // 
            // btnListPart
            // 
            this.btnListPart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnListPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnListPart.ForeColor = System.Drawing.Color.White;
            this.btnListPart.Location = new System.Drawing.Point(34, 266);
            this.btnListPart.Name = "btnListPart";
            this.btnListPart.Size = new System.Drawing.Size(333, 30);
            this.btnListPart.TabIndex = 14;
            this.btnListPart.Text = "List Part Details";
            this.btnListPart.UseVisualStyleBackColor = false;
            this.btnListPart.Click += new System.EventHandler(this.btnListPart_Click);
            // 
            // mnuBackButton
            // 
            this.mnuBackButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackButton.Location = new System.Drawing.Point(0, 0);
            this.mnuBackButton.Name = "mnuBackButton";
            this.mnuBackButton.Size = new System.Drawing.Size(578, 29);
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
            // grpListItems
            // 
            this.grpListItems.Controls.Add(this.lblPartIDAndName);
            this.grpListItems.Controls.Add(this.lstParts);
            this.grpListItems.Controls.Add(this.btnListPart);
            this.grpListItems.Location = new System.Drawing.Point(91, 120);
            this.grpListItems.Name = "grpListItems";
            this.grpListItems.Size = new System.Drawing.Size(421, 343);
            this.grpListItems.TabIndex = 16;
            this.grpListItems.TabStop = false;
            this.grpListItems.Visible = false;
            // 
            // lblPartIDAndName
            // 
            this.lblPartIDAndName.AutoSize = true;
            this.lblPartIDAndName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPartIDAndName.Location = new System.Drawing.Point(30, 38);
            this.lblPartIDAndName.Name = "lblPartIDAndName";
            this.lblPartIDAndName.Size = new System.Drawing.Size(201, 20);
            this.lblPartIDAndName.TabIndex = 17;
            this.lblPartIDAndName.Text = "Part ID     |    Part Name";
            // 
            // btnListAllParts
            // 
            this.btnListAllParts.BackColor = System.Drawing.Color.SteelBlue;
            this.btnListAllParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnListAllParts.ForeColor = System.Drawing.Color.White;
            this.btnListAllParts.Location = new System.Drawing.Point(141, 84);
            this.btnListAllParts.Name = "btnListAllParts";
            this.btnListAllParts.Size = new System.Drawing.Size(317, 30);
            this.btnListAllParts.TabIndex = 18;
            this.btnListAllParts.Text = "List All Parts";
            this.btnListAllParts.UseVisualStyleBackColor = false;
            this.btnListAllParts.Click += new System.EventHandler(this.btnListAllParts_Click);
            // 
            // frmListPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 497);
            this.Controls.Add(this.btnListAllParts);
            this.Controls.Add(this.grpListItems);
            this.Controls.Add(this.txtSearchPartName);
            this.Controls.Add(this.lblSearchPartName);
            this.Controls.Add(this.mnuBackButton);
            this.MainMenuStrip = this.mnuBackButton;
            this.Name = "frmListPart";
            this.Text = "List Part";
            this.Load += new System.EventHandler(this.frmListPart_Load);
            this.mnuBackButton.ResumeLayout(false);
            this.mnuBackButton.PerformLayout();
            this.grpListItems.ResumeLayout(false);
            this.grpListItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchPartName;
        private System.Windows.Forms.Label lblSearchPartName;
        private System.Windows.Forms.ListBox lstParts;
        private System.Windows.Forms.Button btnListPart;
        private System.Windows.Forms.MenuStrip mnuBackButton;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpListItems;
        private System.Windows.Forms.Label lblPartIDAndName;
        private System.Windows.Forms.Button btnListAllParts;
    }
}