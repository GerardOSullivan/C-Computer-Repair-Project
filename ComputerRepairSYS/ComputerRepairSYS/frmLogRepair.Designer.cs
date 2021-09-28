namespace ComputerRepairSYS
{
    partial class frmLogRepair
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogRepair = new System.Windows.Forms.Button();
            this.mnuBackButton = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblRepairTicketID = new System.Windows.Forms.Label();
            this.txtRepairTicketID = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.prntRepairTicketID = new System.Drawing.Printing.PrintDocument();
            this.mnuBackButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(157, 291);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(216, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPhone.Location = new System.Drawing.Point(52, 291);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 20);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 245);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.Location = new System.Drawing.Point(52, 245);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEircode.Location = new System.Drawing.Point(52, 202);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(67, 20);
            this.lblEircode.TabIndex = 11;
            this.lblEircode.Text = "Eircode:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFirstName.Location = new System.Drawing.Point(52, 64);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(157, 202);
            this.txtEircode.MaxLength = 8;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(216, 20);
            this.txtEircode.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(157, 64);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(216, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(57, 353);
            this.txtDescription.MaxLength = 70;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(481, 64);
            this.txtDescription.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(53, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Description of problem:";
            // 
            // btnLogRepair
            // 
            this.btnLogRepair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogRepair.ForeColor = System.Drawing.Color.White;
            this.btnLogRepair.Location = new System.Drawing.Point(133, 435);
            this.btnLogRepair.Name = "btnLogRepair";
            this.btnLogRepair.Size = new System.Drawing.Size(299, 30);
            this.btnLogRepair.TabIndex = 8;
            this.btnLogRepair.Text = "Log Repair";
            this.btnLogRepair.UseVisualStyleBackColor = false;
            this.btnLogRepair.Click += new System.EventHandler(this.btnLogRepair_Click);
            // 
            // mnuBackButton
            // 
            this.mnuBackButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackButton.Location = new System.Drawing.Point(0, 0);
            this.mnuBackButton.Name = "mnuBackButton";
            this.mnuBackButton.Size = new System.Drawing.Size(560, 29);
            this.mnuBackButton.TabIndex = 21;
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
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAddress.Location = new System.Drawing.Point(52, 141);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(157, 141);
            this.txtAddress.MaxLength = 70;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 46);
            this.txtAddress.TabIndex = 3;
            // 
            // lblRepairTicketID
            // 
            this.lblRepairTicketID.AutoSize = true;
            this.lblRepairTicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRepairTicketID.Location = new System.Drawing.Point(53, 29);
            this.lblRepairTicketID.Name = "lblRepairTicketID";
            this.lblRepairTicketID.Size = new System.Drawing.Size(72, 20);
            this.lblRepairTicketID.TabIndex = 24;
            this.lblRepairTicketID.Text = "TicketID:";
            // 
            // txtRepairTicketID
            // 
            this.txtRepairTicketID.Enabled = false;
            this.txtRepairTicketID.Location = new System.Drawing.Point(157, 29);
            this.txtRepairTicketID.MaxLength = 20;
            this.txtRepairTicketID.Name = "txtRepairTicketID";
            this.txtRepairTicketID.ReadOnly = true;
            this.txtRepairTicketID.Size = new System.Drawing.Size(216, 20);
            this.txtRepairTicketID.TabIndex = 25;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLastName.Location = new System.Drawing.Point(52, 101);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 27;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(157, 101);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(216, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // prntRepairTicketID
            // 
            this.prntRepairTicketID.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prntRepairTicketID_PrintPage);
            // 
            // frmLogRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 493);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtRepairTicketID);
            this.Controls.Add(this.lblRepairTicketID);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnLogRepair);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEircode);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtEircode);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.mnuBackButton);
            this.MainMenuStrip = this.mnuBackButton;
            this.Name = "frmLogRepair";
            this.Text = "Log Repair";
            this.Load += new System.EventHandler(this.frmLogRepair_Load);
            this.mnuBackButton.ResumeLayout(false);
            this.mnuBackButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogRepair;
        private System.Windows.Forms.MenuStrip mnuBackButton;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblRepairTicketID;
        private System.Windows.Forms.TextBox txtRepairTicketID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Drawing.Printing.PrintDocument prntRepairTicketID;
    }
}