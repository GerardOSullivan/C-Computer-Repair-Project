namespace ComputerRepairSYS
{
    partial class frmFinaliseRepair
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
            this.lblRepairTicketID = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnFinaliseRepair = new System.Windows.Forms.Button();
            this.mnuBackButton = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cboRepairTicketID = new System.Windows.Forms.ComboBox();
            this.grpRepairDetails = new System.Windows.Forms.GroupBox();
            this.lblRepairTicketIDValue = new System.Windows.Forms.Label();
            this.lblRepairTicketID1 = new System.Windows.Forms.Label();
            this.lblTotalCostValue = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescriptionValue = new System.Windows.Forms.Label();
            this.lblLastNameValue = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstNameValue = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.mnuBackButton.SuspendLayout();
            this.grpRepairDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRepairTicketID
            // 
            this.lblRepairTicketID.AutoSize = true;
            this.lblRepairTicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRepairTicketID.Location = new System.Drawing.Point(167, 63);
            this.lblRepairTicketID.Name = "lblRepairTicketID";
            this.lblRepairTicketID.Size = new System.Drawing.Size(127, 20);
            this.lblRepairTicketID.TabIndex = 14;
            this.lblRepairTicketID.Text = "Repair Ticket ID:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalCost.Location = new System.Drawing.Point(106, 138);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(85, 20);
            this.lblTotalCost.TabIndex = 15;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // btnFinaliseRepair
            // 
            this.btnFinaliseRepair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFinaliseRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFinaliseRepair.ForeColor = System.Drawing.Color.White;
            this.btnFinaliseRepair.Location = new System.Drawing.Point(81, 333);
            this.btnFinaliseRepair.Name = "btnFinaliseRepair";
            this.btnFinaliseRepair.Size = new System.Drawing.Size(260, 30);
            this.btnFinaliseRepair.TabIndex = 22;
            this.btnFinaliseRepair.Text = "Finalise Repair";
            this.btnFinaliseRepair.UseVisualStyleBackColor = false;
            this.btnFinaliseRepair.Click += new System.EventHandler(this.btnFinaliseRepair_Click);
            // 
            // mnuBackButton
            // 
            this.mnuBackButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackButton.Location = new System.Drawing.Point(0, 0);
            this.mnuBackButton.Name = "mnuBackButton";
            this.mnuBackButton.Size = new System.Drawing.Size(654, 29);
            this.mnuBackButton.TabIndex = 23;
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
            // cboRepairTicketID
            // 
            this.cboRepairTicketID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRepairTicketID.FormattingEnabled = true;
            this.cboRepairTicketID.Location = new System.Drawing.Point(300, 62);
            this.cboRepairTicketID.Name = "cboRepairTicketID";
            this.cboRepairTicketID.Size = new System.Drawing.Size(147, 21);
            this.cboRepairTicketID.TabIndex = 25;
            this.cboRepairTicketID.SelectedIndexChanged += new System.EventHandler(this.cboRepairTicketID_SelectedIndexChanged);
            // 
            // grpRepairDetails
            // 
            this.grpRepairDetails.Controls.Add(this.lblRepairTicketIDValue);
            this.grpRepairDetails.Controls.Add(this.lblRepairTicketID1);
            this.grpRepairDetails.Controls.Add(this.lblTotalCostValue);
            this.grpRepairDetails.Controls.Add(this.lblDescription);
            this.grpRepairDetails.Controls.Add(this.lblDescriptionValue);
            this.grpRepairDetails.Controls.Add(this.lblLastNameValue);
            this.grpRepairDetails.Controls.Add(this.lblLastName);
            this.grpRepairDetails.Controls.Add(this.lblFirstNameValue);
            this.grpRepairDetails.Controls.Add(this.lblFirstName);
            this.grpRepairDetails.Controls.Add(this.btnFinaliseRepair);
            this.grpRepairDetails.Controls.Add(this.lblTotalCost);
            this.grpRepairDetails.Location = new System.Drawing.Point(106, 115);
            this.grpRepairDetails.Name = "grpRepairDetails";
            this.grpRepairDetails.Size = new System.Drawing.Size(427, 417);
            this.grpRepairDetails.TabIndex = 26;
            this.grpRepairDetails.TabStop = false;
            this.grpRepairDetails.Visible = false;
            // 
            // lblRepairTicketIDValue
            // 
            this.lblRepairTicketIDValue.AutoSize = true;
            this.lblRepairTicketIDValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRepairTicketIDValue.Location = new System.Drawing.Point(252, 30);
            this.lblRepairTicketIDValue.Name = "lblRepairTicketIDValue";
            this.lblRepairTicketIDValue.Size = new System.Drawing.Size(54, 20);
            this.lblRepairTicketIDValue.TabIndex = 43;
            this.lblRepairTicketIDValue.Text = "10004";
            // 
            // lblRepairTicketID1
            // 
            this.lblRepairTicketID1.AutoSize = true;
            this.lblRepairTicketID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRepairTicketID1.Location = new System.Drawing.Point(106, 30);
            this.lblRepairTicketID1.Name = "lblRepairTicketID1";
            this.lblRepairTicketID1.Size = new System.Drawing.Size(127, 20);
            this.lblRepairTicketID1.TabIndex = 42;
            this.lblRepairTicketID1.Text = "Repair Ticket ID:";
            // 
            // lblTotalCostValue
            // 
            this.lblTotalCostValue.AutoSize = true;
            this.lblTotalCostValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalCostValue.Location = new System.Drawing.Point(252, 138);
            this.lblTotalCostValue.Name = "lblTotalCostValue";
            this.lblTotalCostValue.Size = new System.Drawing.Size(58, 20);
            this.lblTotalCostValue.TabIndex = 41;
            this.lblTotalCostValue.Text = "€50.00";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDescription.Location = new System.Drawing.Point(106, 172);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 40;
            this.lblDescription.Text = "Description:";
            // 
            // lblDescriptionValue
            // 
            this.lblDescriptionValue.AutoSize = true;
            this.lblDescriptionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionValue.Location = new System.Drawing.Point(106, 201);
            this.lblDescriptionValue.MaximumSize = new System.Drawing.Size(300, 100);
            this.lblDescriptionValue.Name = "lblDescriptionValue";
            this.lblDescriptionValue.Size = new System.Drawing.Size(115, 20);
            this.lblDescriptionValue.TabIndex = 39;
            this.lblDescriptionValue.Text = "Broken Screen";
            // 
            // lblLastNameValue
            // 
            this.lblLastNameValue.AutoSize = true;
            this.lblLastNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLastNameValue.Location = new System.Drawing.Point(252, 103);
            this.lblLastNameValue.MaximumSize = new System.Drawing.Size(150, 20);
            this.lblLastNameValue.Name = "lblLastNameValue";
            this.lblLastNameValue.Size = new System.Drawing.Size(50, 20);
            this.lblLastNameValue.TabIndex = 28;
            this.lblLastNameValue.Text = "Smith";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLastName.Location = new System.Drawing.Point(106, 103);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 27;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstNameValue
            // 
            this.lblFirstNameValue.AutoSize = true;
            this.lblFirstNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFirstNameValue.Location = new System.Drawing.Point(252, 67);
            this.lblFirstNameValue.MaximumSize = new System.Drawing.Size(150, 20);
            this.lblFirstNameValue.Name = "lblFirstNameValue";
            this.lblFirstNameValue.Size = new System.Drawing.Size(44, 20);
            this.lblFirstNameValue.TabIndex = 26;
            this.lblFirstNameValue.Text = "John";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFirstName.Location = new System.Drawing.Point(106, 67);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 25;
            this.lblFirstName.Text = "First Name:";
            // 
            // frmFinaliseRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 579);
            this.Controls.Add(this.grpRepairDetails);
            this.Controls.Add(this.cboRepairTicketID);
            this.Controls.Add(this.lblRepairTicketID);
            this.Controls.Add(this.mnuBackButton);
            this.MainMenuStrip = this.mnuBackButton;
            this.Name = "frmFinaliseRepair";
            this.Text = "Finalise Repair";
            this.Load += new System.EventHandler(this.frmFinaliseRepair_Load);
            this.mnuBackButton.ResumeLayout(false);
            this.mnuBackButton.PerformLayout();
            this.grpRepairDetails.ResumeLayout(false);
            this.grpRepairDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepairTicketID;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnFinaliseRepair;
        private System.Windows.Forms.MenuStrip mnuBackButton;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ComboBox cboRepairTicketID;
        private System.Windows.Forms.GroupBox grpRepairDetails;
        private System.Windows.Forms.Label lblLastNameValue;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstNameValue;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDescriptionValue;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTotalCostValue;
        private System.Windows.Forms.Label lblRepairTicketIDValue;
        private System.Windows.Forms.Label lblRepairTicketID1;
    }
}