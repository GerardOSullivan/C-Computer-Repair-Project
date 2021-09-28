namespace ComputerRepairSYS
{
    partial class frmUpdatePart
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
            this.lblPartBeingUpdated = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.lblPartCost = new System.Windows.Forms.Label();
            this.txtPartCost = new System.Windows.Forms.TextBox();
            this.lblQtyInStock = new System.Windows.Forms.Label();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.btnUpdatePart = new System.Windows.Forms.Button();
            this.lstParts = new System.Windows.Forms.ListBox();
            this.mnuBackButton = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.btnSelectPart = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblSearchPartName = new System.Windows.Forms.Label();
            this.lblPartIDAndName = new System.Windows.Forms.Label();
            this.grpSearchParts = new System.Windows.Forms.GroupBox();
            this.grpListBox = new System.Windows.Forms.GroupBox();
            this.grpSearchTextBox = new System.Windows.Forms.GroupBox();
            this.mnuBackButton.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.grpSearchParts.SuspendLayout();
            this.grpListBox.SuspendLayout();
            this.grpSearchTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchPartName
            // 
            this.txtSearchPartName.Location = new System.Drawing.Point(176, 32);
            this.txtSearchPartName.MaxLength = 20;
            this.txtSearchPartName.Name = "txtSearchPartName";
            this.txtSearchPartName.Size = new System.Drawing.Size(153, 20);
            this.txtSearchPartName.TabIndex = 3;
            this.txtSearchPartName.TextChanged += new System.EventHandler(this.txtSearchPartName_TextChanged);
            // 
            // lblPartBeingUpdated
            // 
            this.lblPartBeingUpdated.AutoSize = true;
            this.lblPartBeingUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblPartBeingUpdated.Location = new System.Drawing.Point(57, 54);
            this.lblPartBeingUpdated.Name = "lblPartBeingUpdated";
            this.lblPartBeingUpdated.Size = new System.Drawing.Size(162, 20);
            this.lblPartBeingUpdated.TabIndex = 4;
            this.lblPartBeingUpdated.Text = "Part being updated";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPartName.Location = new System.Drawing.Point(57, 113);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(88, 20);
            this.lblPartName.TabIndex = 5;
            this.lblPartName.Text = "Part Name:";
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(206, 113);
            this.txtPartName.MaxLength = 20;
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(153, 20);
            this.txtPartName.TabIndex = 6;
            // 
            // lblPartCost
            // 
            this.lblPartCost.AutoSize = true;
            this.lblPartCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPartCost.Location = new System.Drawing.Point(57, 162);
            this.lblPartCost.Name = "lblPartCost";
            this.lblPartCost.Size = new System.Drawing.Size(79, 20);
            this.lblPartCost.TabIndex = 7;
            this.lblPartCost.Text = "Part Cost:";
            // 
            // txtPartCost
            // 
            this.txtPartCost.Location = new System.Drawing.Point(206, 162);
            this.txtPartCost.MaxLength = 6;
            this.txtPartCost.Name = "txtPartCost";
            this.txtPartCost.Size = new System.Drawing.Size(153, 20);
            this.txtPartCost.TabIndex = 8;
            // 
            // lblQtyInStock
            // 
            this.lblQtyInStock.AutoSize = true;
            this.lblQtyInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQtyInStock.Location = new System.Drawing.Point(57, 216);
            this.lblQtyInStock.Name = "lblQtyInStock";
            this.lblQtyInStock.Size = new System.Drawing.Size(135, 20);
            this.lblQtyInStock.TabIndex = 9;
            this.lblQtyInStock.Text = "Quantity In Stock:";
            // 
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.Location = new System.Drawing.Point(206, 216);
            this.txtQuantityInStock.MaxLength = 4;
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.Size = new System.Drawing.Size(153, 20);
            this.txtQuantityInStock.TabIndex = 10;
            // 
            // btnUpdatePart
            // 
            this.btnUpdatePart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdatePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdatePart.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePart.Location = new System.Drawing.Point(232, 290);
            this.btnUpdatePart.Name = "btnUpdatePart";
            this.btnUpdatePart.Size = new System.Drawing.Size(183, 30);
            this.btnUpdatePart.TabIndex = 11;
            this.btnUpdatePart.Text = "Update Part";
            this.btnUpdatePart.UseVisualStyleBackColor = false;
            this.btnUpdatePart.Click += new System.EventHandler(this.btnUpdatePart_Click);
            // 
            // lstParts
            // 
            this.lstParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstParts.FormattingEnabled = true;
            this.lstParts.ItemHeight = 20;
            this.lstParts.Location = new System.Drawing.Point(30, 47);
            this.lstParts.Name = "lstParts";
            this.lstParts.Size = new System.Drawing.Size(378, 124);
            this.lstParts.TabIndex = 12;
            // 
            // mnuBackButton
            // 
            this.mnuBackButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackButton.Location = new System.Drawing.Point(0, 0);
            this.mnuBackButton.Name = "mnuBackButton";
            this.mnuBackButton.Size = new System.Drawing.Size(634, 29);
            this.mnuBackButton.TabIndex = 13;
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
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.btnSelectPart);
            this.grpUpdate.Controls.Add(this.lblPartBeingUpdated);
            this.grpUpdate.Controls.Add(this.lblPartName);
            this.grpUpdate.Controls.Add(this.btnUpdatePart);
            this.grpUpdate.Controls.Add(this.txtPartName);
            this.grpUpdate.Controls.Add(this.txtQuantityInStock);
            this.grpUpdate.Controls.Add(this.lblPartCost);
            this.grpUpdate.Controls.Add(this.lblQtyInStock);
            this.grpUpdate.Controls.Add(this.txtPartCost);
            this.grpUpdate.Location = new System.Drawing.Point(84, 32);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(448, 369);
            this.grpUpdate.TabIndex = 14;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Visible = false;
            // 
            // btnSelectPart
            // 
            this.btnSelectPart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSelectPart.ForeColor = System.Drawing.Color.White;
            this.btnSelectPart.Location = new System.Drawing.Point(23, 290);
            this.btnSelectPart.Name = "btnSelectPart";
            this.btnSelectPart.Size = new System.Drawing.Size(181, 30);
            this.btnSelectPart.TabIndex = 12;
            this.btnSelectPart.Text = "Return to Select Part";
            this.btnSelectPart.UseVisualStyleBackColor = false;
            this.btnSelectPart.Click += new System.EventHandler(this.btnSelectPart_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(145, 186);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(131, 32);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblSearchPartName
            // 
            this.lblSearchPartName.AutoSize = true;
            this.lblSearchPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearchPartName.Location = new System.Drawing.Point(27, 32);
            this.lblSearchPartName.Name = "lblSearchPartName";
            this.lblSearchPartName.Size = new System.Drawing.Size(143, 20);
            this.lblSearchPartName.TabIndex = 2;
            this.lblSearchPartName.Text = "Search Part Name:";
            // 
            // lblPartIDAndName
            // 
            this.lblPartIDAndName.AutoSize = true;
            this.lblPartIDAndName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPartIDAndName.Location = new System.Drawing.Point(26, 24);
            this.lblPartIDAndName.Name = "lblPartIDAndName";
            this.lblPartIDAndName.Size = new System.Drawing.Size(201, 20);
            this.lblPartIDAndName.TabIndex = 15;
            this.lblPartIDAndName.Text = "Part ID     |    Part Name";
            // 
            // grpSearchParts
            // 
            this.grpSearchParts.Controls.Add(this.grpListBox);
            this.grpSearchParts.Controls.Add(this.grpSearchTextBox);
            this.grpSearchParts.Location = new System.Drawing.Point(84, 32);
            this.grpSearchParts.Name = "grpSearchParts";
            this.grpSearchParts.Size = new System.Drawing.Size(471, 369);
            this.grpSearchParts.TabIndex = 16;
            this.grpSearchParts.TabStop = false;
            // 
            // grpListBox
            // 
            this.grpListBox.Controls.Add(this.lstParts);
            this.grpListBox.Controls.Add(this.btnSelect);
            this.grpListBox.Controls.Add(this.lblPartIDAndName);
            this.grpListBox.Location = new System.Drawing.Point(23, 113);
            this.grpListBox.Name = "grpListBox";
            this.grpListBox.Size = new System.Drawing.Size(431, 243);
            this.grpListBox.TabIndex = 17;
            this.grpListBox.TabStop = false;
            this.grpListBox.Visible = false;
            // 
            // grpSearchTextBox
            // 
            this.grpSearchTextBox.Controls.Add(this.lblSearchPartName);
            this.grpSearchTextBox.Controls.Add(this.txtSearchPartName);
            this.grpSearchTextBox.Location = new System.Drawing.Point(23, 19);
            this.grpSearchTextBox.Name = "grpSearchTextBox";
            this.grpSearchTextBox.Size = new System.Drawing.Size(431, 81);
            this.grpSearchTextBox.TabIndex = 16;
            this.grpSearchTextBox.TabStop = false;
            // 
            // frmUpdatePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.mnuBackButton);
            this.Controls.Add(this.grpSearchParts);
            this.Controls.Add(this.grpUpdate);
            this.MainMenuStrip = this.mnuBackButton;
            this.Name = "frmUpdatePart";
            this.Text = "Update Part";
            this.Load += new System.EventHandler(this.frmUpdatePart_Load);
            this.mnuBackButton.ResumeLayout(false);
            this.mnuBackButton.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.grpSearchParts.ResumeLayout(false);
            this.grpListBox.ResumeLayout(false);
            this.grpListBox.PerformLayout();
            this.grpSearchTextBox.ResumeLayout(false);
            this.grpSearchTextBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchPartName;
        private System.Windows.Forms.Label lblPartBeingUpdated;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.Label lblPartCost;
        private System.Windows.Forms.TextBox txtPartCost;
        private System.Windows.Forms.Label lblQtyInStock;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.Button btnUpdatePart;
        private System.Windows.Forms.ListBox lstParts;
        private System.Windows.Forms.MenuStrip mnuBackButton;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblSearchPartName;
        private System.Windows.Forms.Label lblPartIDAndName;
        private System.Windows.Forms.GroupBox grpSearchParts;
        private System.Windows.Forms.Button btnSelectPart;
        private System.Windows.Forms.GroupBox grpSearchTextBox;
        private System.Windows.Forms.GroupBox grpListBox;
    }
}