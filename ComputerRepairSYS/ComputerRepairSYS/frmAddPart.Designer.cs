namespace ComputerRepairSYS
{
    partial class frmAddPart
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
            this.txtPartIDBox = new System.Windows.Forms.TextBox();
            this.txtPartNameBox = new System.Windows.Forms.TextBox();
            this.lblAddPartID = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblPartCost = new System.Windows.Forms.Label();
            this.txtPartCostBox = new System.Windows.Forms.TextBox();
            this.lblQtyInStock = new System.Windows.Forms.Label();
            this.txtQuantityInStockBox = new System.Windows.Forms.TextBox();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.mnuBackButton = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPartIDBox
            // 
            this.txtPartIDBox.Enabled = false;
            this.txtPartIDBox.Location = new System.Drawing.Point(209, 49);
            this.txtPartIDBox.MaxLength = 5;
            this.txtPartIDBox.Name = "txtPartIDBox";
            this.txtPartIDBox.ReadOnly = true;
            this.txtPartIDBox.Size = new System.Drawing.Size(97, 20);
            this.txtPartIDBox.TabIndex = 0;
            // 
            // txtPartNameBox
            // 
            this.txtPartNameBox.Location = new System.Drawing.Point(209, 94);
            this.txtPartNameBox.MaxLength = 20;
            this.txtPartNameBox.Name = "txtPartNameBox";
            this.txtPartNameBox.Size = new System.Drawing.Size(139, 20);
            this.txtPartNameBox.TabIndex = 1;
            // 
            // lblAddPartID
            // 
            this.lblAddPartID.AutoSize = true;
            this.lblAddPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAddPartID.Location = new System.Drawing.Point(61, 49);
            this.lblAddPartID.Name = "lblAddPartID";
            this.lblAddPartID.Size = new System.Drawing.Size(63, 20);
            this.lblAddPartID.TabIndex = 2;
            this.lblAddPartID.Text = "Part ID:";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPartName.Location = new System.Drawing.Point(61, 94);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(88, 20);
            this.lblPartName.TabIndex = 3;
            this.lblPartName.Text = "Part Name:";
            // 
            // lblPartCost
            // 
            this.lblPartCost.AutoSize = true;
            this.lblPartCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPartCost.Location = new System.Drawing.Point(61, 137);
            this.lblPartCost.Name = "lblPartCost";
            this.lblPartCost.Size = new System.Drawing.Size(79, 20);
            this.lblPartCost.TabIndex = 4;
            this.lblPartCost.Text = "Part Cost:";
            // 
            // txtPartCostBox
            // 
            this.txtPartCostBox.Location = new System.Drawing.Point(209, 137);
            this.txtPartCostBox.MaxLength = 6;
            this.txtPartCostBox.Name = "txtPartCostBox";
            this.txtPartCostBox.Size = new System.Drawing.Size(97, 20);
            this.txtPartCostBox.TabIndex = 5;
            // 
            // lblQtyInStock
            // 
            this.lblQtyInStock.AutoSize = true;
            this.lblQtyInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQtyInStock.Location = new System.Drawing.Point(61, 183);
            this.lblQtyInStock.Name = "lblQtyInStock";
            this.lblQtyInStock.Size = new System.Drawing.Size(133, 20);
            this.lblQtyInStock.TabIndex = 6;
            this.lblQtyInStock.Text = "Quantity in Stock:";
            // 
            // txtQuantityInStockBox
            // 
            this.txtQuantityInStockBox.Location = new System.Drawing.Point(209, 183);
            this.txtQuantityInStockBox.MaxLength = 4;
            this.txtQuantityInStockBox.Name = "txtQuantityInStockBox";
            this.txtQuantityInStockBox.Size = new System.Drawing.Size(97, 20);
            this.txtQuantityInStockBox.TabIndex = 7;
            // 
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddPart.ForeColor = System.Drawing.Color.White;
            this.btnAddPart.Location = new System.Drawing.Point(99, 250);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(299, 30);
            this.btnAddPart.TabIndex = 8;
            this.btnAddPart.Text = "Add Part";
            this.btnAddPart.UseVisualStyleBackColor = false;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // mnuBackButton
            // 
            this.mnuBackButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackButton.Location = new System.Drawing.Point(0, 0);
            this.mnuBackButton.Name = "mnuBackButton";
            this.mnuBackButton.Size = new System.Drawing.Size(528, 29);
            this.mnuBackButton.TabIndex = 9;
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
            // frmAddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 324);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.txtQuantityInStockBox);
            this.Controls.Add(this.lblQtyInStock);
            this.Controls.Add(this.txtPartCostBox);
            this.Controls.Add(this.lblPartCost);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.lblAddPartID);
            this.Controls.Add(this.txtPartNameBox);
            this.Controls.Add(this.txtPartIDBox);
            this.Controls.Add(this.mnuBackButton);
            this.MainMenuStrip = this.mnuBackButton;
            this.Name = "frmAddPart";
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.frmAddPart_Load);
            this.mnuBackButton.ResumeLayout(false);
            this.mnuBackButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPartIDBox;
        private System.Windows.Forms.TextBox txtPartNameBox;
        private System.Windows.Forms.Label lblAddPartID;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.Label lblPartCost;
        private System.Windows.Forms.TextBox txtPartCostBox;
        private System.Windows.Forms.Label lblQtyInStock;
        private System.Windows.Forms.TextBox txtQuantityInStockBox;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.MenuStrip mnuBackButton;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
    }
}