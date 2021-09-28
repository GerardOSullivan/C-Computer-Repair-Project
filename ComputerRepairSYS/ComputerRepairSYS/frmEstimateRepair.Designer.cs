namespace ComputerRepairSYS
{
    partial class frmEstimateRepair
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
            this.lblQtytoBeAdded = new System.Windows.Forms.Label();
            this.txtQtytoBeAdded = new System.Windows.Forms.TextBox();
            this.lstPartsAvailable = new System.Windows.Forms.ListBox();
            this.btnAddPartToRepair = new System.Windows.Forms.Button();
            this.btnEstimateRepair = new System.Windows.Forms.Button();
            this.mnuBackButton = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lstRepairParts = new System.Windows.Forms.ListBox();
            this.lblSearchPart = new System.Windows.Forms.Label();
            this.txtPartSearch = new System.Windows.Forms.TextBox();
            this.lblRepairParts = new System.Windows.Forms.Label();
            this.btnSelectID = new System.Windows.Forms.Button();
            this.grpEstimateCost = new System.Windows.Forms.GroupBox();
            this.grpRepairParts = new System.Windows.Forms.GroupBox();
            this.lblRepairPartsCost = new System.Windows.Forms.Label();
            this.lblRepairPartID = new System.Windows.Forms.Label();
            this.lblRepairPartsQuantity = new System.Windows.Forms.Label();
            this.grpAvailableParts = new System.Windows.Forms.GroupBox();
            this.lblAvailableCost = new System.Windows.Forms.Label();
            this.lblAvailableParts = new System.Windows.Forms.Label();
            this.lblAvailablePartID = new System.Windows.Forms.Label();
            this.lblAvailableQuantity = new System.Windows.Forms.Label();
            this.btnReturnToTicketSelect = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescriptionTitle = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblLastNameTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblFirstNameTitle = new System.Windows.Forms.Label();
            this.lblTicketID = new System.Windows.Forms.Label();
            this.lblRepairTicketTitle = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnRemoveParts = new System.Windows.Forms.Button();
            this.lblTotalCostValue = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.cboLoggedRepairs = new System.Windows.Forms.ComboBox();
            this.grpTicketID = new System.Windows.Forms.GroupBox();
            this.mnuBackButton.SuspendLayout();
            this.grpEstimateCost.SuspendLayout();
            this.grpRepairParts.SuspendLayout();
            this.grpAvailableParts.SuspendLayout();
            this.grpTicketID.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRepairTicketID
            // 
            this.lblRepairTicketID.AutoSize = true;
            this.lblRepairTicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRepairTicketID.Location = new System.Drawing.Point(278, 35);
            this.lblRepairTicketID.Name = "lblRepairTicketID";
            this.lblRepairTicketID.Size = new System.Drawing.Size(127, 20);
            this.lblRepairTicketID.TabIndex = 12;
            this.lblRepairTicketID.Text = "Repair Ticket ID:";
            // 
            // lblQtytoBeAdded
            // 
            this.lblQtytoBeAdded.AutoSize = true;
            this.lblQtytoBeAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQtytoBeAdded.Location = new System.Drawing.Point(362, 365);
            this.lblQtytoBeAdded.Name = "lblQtytoBeAdded";
            this.lblQtytoBeAdded.Size = new System.Drawing.Size(169, 20);
            this.lblQtytoBeAdded.TabIndex = 16;
            this.lblQtytoBeAdded.Text = "Quantity To Be Added:";
            // 
            // txtQtytoBeAdded
            // 
            this.txtQtytoBeAdded.Location = new System.Drawing.Point(537, 365);
            this.txtQtytoBeAdded.MaxLength = 4;
            this.txtQtytoBeAdded.Name = "txtQtytoBeAdded";
            this.txtQtytoBeAdded.Size = new System.Drawing.Size(184, 26);
            this.txtQtytoBeAdded.TabIndex = 17;
            // 
            // lstPartsAvailable
            // 
            this.lstPartsAvailable.ItemHeight = 20;
            this.lstPartsAvailable.Location = new System.Drawing.Point(27, 55);
            this.lstPartsAvailable.Name = "lstPartsAvailable";
            this.lstPartsAvailable.Size = new System.Drawing.Size(466, 184);
            this.lstPartsAvailable.TabIndex = 18;
            // 
            // btnAddPartToRepair
            // 
            this.btnAddPartToRepair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddPartToRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddPartToRepair.ForeColor = System.Drawing.Color.White;
            this.btnAddPartToRepair.Location = new System.Drawing.Point(366, 421);
            this.btnAddPartToRepair.Name = "btnAddPartToRepair";
            this.btnAddPartToRepair.Size = new System.Drawing.Size(221, 30);
            this.btnAddPartToRepair.TabIndex = 19;
            this.btnAddPartToRepair.Text = "Add Part to Repair";
            this.btnAddPartToRepair.UseVisualStyleBackColor = false;
            this.btnAddPartToRepair.Click += new System.EventHandler(this.btnAddPartToRepair_Click);
            // 
            // btnEstimateRepair
            // 
            this.btnEstimateRepair.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEstimateRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEstimateRepair.ForeColor = System.Drawing.Color.White;
            this.btnEstimateRepair.Location = new System.Drawing.Point(366, 476);
            this.btnEstimateRepair.Name = "btnEstimateRepair";
            this.btnEstimateRepair.Size = new System.Drawing.Size(221, 30);
            this.btnEstimateRepair.TabIndex = 21;
            this.btnEstimateRepair.Text = "Estimate Repair";
            this.btnEstimateRepair.UseVisualStyleBackColor = false;
            this.btnEstimateRepair.Click += new System.EventHandler(this.btnEstimateRepair_Click);
            // 
            // mnuBackButton
            // 
            this.mnuBackButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuBackButton.Location = new System.Drawing.Point(0, 0);
            this.mnuBackButton.Name = "mnuBackButton";
            this.mnuBackButton.Size = new System.Drawing.Size(1530, 29);
            this.mnuBackButton.TabIndex = 22;
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
            // lstRepairParts
            // 
            this.lstRepairParts.FormattingEnabled = true;
            this.lstRepairParts.ItemHeight = 20;
            this.lstRepairParts.Location = new System.Drawing.Point(21, 50);
            this.lstRepairParts.Name = "lstRepairParts";
            this.lstRepairParts.Size = new System.Drawing.Size(472, 184);
            this.lstRepairParts.TabIndex = 23;
            // 
            // lblSearchPart
            // 
            this.lblSearchPart.AutoSize = true;
            this.lblSearchPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearchPart.Location = new System.Drawing.Point(362, 332);
            this.lblSearchPart.Name = "lblSearchPart";
            this.lblSearchPart.Size = new System.Drawing.Size(171, 20);
            this.lblSearchPart.TabIndex = 24;
            this.lblSearchPart.Text = "Search Available parts:";
            // 
            // txtPartSearch
            // 
            this.txtPartSearch.Location = new System.Drawing.Point(539, 332);
            this.txtPartSearch.MaxLength = 20;
            this.txtPartSearch.Name = "txtPartSearch";
            this.txtPartSearch.Size = new System.Drawing.Size(182, 26);
            this.txtPartSearch.TabIndex = 25;
            this.txtPartSearch.TextChanged += new System.EventHandler(this.txtPartSearch_TextChanged);
            // 
            // lblRepairParts
            // 
            this.lblRepairParts.AutoSize = true;
            this.lblRepairParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblRepairParts.Location = new System.Drawing.Point(248, 27);
            this.lblRepairParts.Name = "lblRepairParts";
            this.lblRepairParts.Size = new System.Drawing.Size(136, 20);
            this.lblRepairParts.TabIndex = 26;
            this.lblRepairParts.Text = "Parts for Repair";
            // 
            // btnSelectID
            // 
            this.btnSelectID.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSelectID.ForeColor = System.Drawing.Color.White;
            this.btnSelectID.Location = new System.Drawing.Point(625, 30);
            this.btnSelectID.Name = "btnSelectID";
            this.btnSelectID.Size = new System.Drawing.Size(130, 30);
            this.btnSelectID.TabIndex = 27;
            this.btnSelectID.Text = "Select ID";
            this.btnSelectID.UseVisualStyleBackColor = false;
            this.btnSelectID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // grpEstimateCost
            // 
            this.grpEstimateCost.Controls.Add(this.grpRepairParts);
            this.grpEstimateCost.Controls.Add(this.grpAvailableParts);
            this.grpEstimateCost.Controls.Add(this.btnReturnToTicketSelect);
            this.grpEstimateCost.Controls.Add(this.lblDescription);
            this.grpEstimateCost.Controls.Add(this.lblDescriptionTitle);
            this.grpEstimateCost.Controls.Add(this.lblLastName);
            this.grpEstimateCost.Controls.Add(this.lblLastNameTitle);
            this.grpEstimateCost.Controls.Add(this.lblFirstName);
            this.grpEstimateCost.Controls.Add(this.lblFirstNameTitle);
            this.grpEstimateCost.Controls.Add(this.lblTicketID);
            this.grpEstimateCost.Controls.Add(this.lblRepairTicketTitle);
            this.grpEstimateCost.Controls.Add(this.lblDetails);
            this.grpEstimateCost.Controls.Add(this.btnRemoveParts);
            this.grpEstimateCost.Controls.Add(this.lblTotalCostValue);
            this.grpEstimateCost.Controls.Add(this.lblTotalCost);
            this.grpEstimateCost.Controls.Add(this.btnAddPartToRepair);
            this.grpEstimateCost.Controls.Add(this.btnEstimateRepair);
            this.grpEstimateCost.Controls.Add(this.lblSearchPart);
            this.grpEstimateCost.Controls.Add(this.lblQtytoBeAdded);
            this.grpEstimateCost.Controls.Add(this.txtQtytoBeAdded);
            this.grpEstimateCost.Controls.Add(this.txtPartSearch);
            this.grpEstimateCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpEstimateCost.Location = new System.Drawing.Point(46, 41);
            this.grpEstimateCost.Name = "grpEstimateCost";
            this.grpEstimateCost.Size = new System.Drawing.Size(1443, 559);
            this.grpEstimateCost.TabIndex = 2;
            this.grpEstimateCost.TabStop = false;
            this.grpEstimateCost.Visible = false;
            // 
            // grpRepairParts
            // 
            this.grpRepairParts.Controls.Add(this.lblRepairPartsCost);
            this.grpRepairParts.Controls.Add(this.lstRepairParts);
            this.grpRepairParts.Controls.Add(this.lblRepairParts);
            this.grpRepairParts.Controls.Add(this.lblRepairPartID);
            this.grpRepairParts.Controls.Add(this.lblRepairPartsQuantity);
            this.grpRepairParts.Location = new System.Drawing.Point(882, 60);
            this.grpRepairParts.Name = "grpRepairParts";
            this.grpRepairParts.Size = new System.Drawing.Size(531, 256);
            this.grpRepairParts.TabIndex = 46;
            this.grpRepairParts.TabStop = false;
            this.grpRepairParts.Visible = false;
            // 
            // lblRepairPartsCost
            // 
            this.lblRepairPartsCost.AutoSize = true;
            this.lblRepairPartsCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblRepairPartsCost.Location = new System.Drawing.Point(161, 27);
            this.lblRepairPartsCost.Name = "lblRepairPartsCost";
            this.lblRepairPartsCost.Size = new System.Drawing.Size(46, 20);
            this.lblRepairPartsCost.TabIndex = 45;
            this.lblRepairPartsCost.Text = "Cost";
            // 
            // lblRepairPartID
            // 
            this.lblRepairPartID.AutoSize = true;
            this.lblRepairPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblRepairPartID.Location = new System.Drawing.Point(19, 27);
            this.lblRepairPartID.Name = "lblRepairPartID";
            this.lblRepairPartID.Size = new System.Drawing.Size(61, 20);
            this.lblRepairPartID.TabIndex = 44;
            this.lblRepairPartID.Text = "PartID";
            // 
            // lblRepairPartsQuantity
            // 
            this.lblRepairPartsQuantity.AutoSize = true;
            this.lblRepairPartsQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblRepairPartsQuantity.Location = new System.Drawing.Point(94, 27);
            this.lblRepairPartsQuantity.Name = "lblRepairPartsQuantity";
            this.lblRepairPartsQuantity.Size = new System.Drawing.Size(36, 20);
            this.lblRepairPartsQuantity.TabIndex = 42;
            this.lblRepairPartsQuantity.Text = "Qty";
            // 
            // grpAvailableParts
            // 
            this.grpAvailableParts.Controls.Add(this.lblAvailableCost);
            this.grpAvailableParts.Controls.Add(this.lstPartsAvailable);
            this.grpAvailableParts.Controls.Add(this.lblAvailableParts);
            this.grpAvailableParts.Controls.Add(this.lblAvailablePartID);
            this.grpAvailableParts.Controls.Add(this.lblAvailableQuantity);
            this.grpAvailableParts.Location = new System.Drawing.Point(345, 60);
            this.grpAvailableParts.Name = "grpAvailableParts";
            this.grpAvailableParts.Size = new System.Drawing.Size(531, 256);
            this.grpAvailableParts.TabIndex = 45;
            this.grpAvailableParts.TabStop = false;
            this.grpAvailableParts.Visible = false;
            // 
            // lblAvailableCost
            // 
            this.lblAvailableCost.AutoSize = true;
            this.lblAvailableCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblAvailableCost.Location = new System.Drawing.Point(166, 32);
            this.lblAvailableCost.Name = "lblAvailableCost";
            this.lblAvailableCost.Size = new System.Drawing.Size(46, 20);
            this.lblAvailableCost.TabIndex = 44;
            this.lblAvailableCost.Text = "Cost";
            // 
            // lblAvailableParts
            // 
            this.lblAvailableParts.AutoSize = true;
            this.lblAvailableParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblAvailableParts.Location = new System.Drawing.Point(254, 32);
            this.lblAvailableParts.Name = "lblAvailableParts";
            this.lblAvailableParts.Size = new System.Drawing.Size(128, 20);
            this.lblAvailableParts.TabIndex = 13;
            this.lblAvailableParts.Text = "Available Parts";
            // 
            // lblAvailablePartID
            // 
            this.lblAvailablePartID.AutoSize = true;
            this.lblAvailablePartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblAvailablePartID.Location = new System.Drawing.Point(23, 32);
            this.lblAvailablePartID.Name = "lblAvailablePartID";
            this.lblAvailablePartID.Size = new System.Drawing.Size(61, 20);
            this.lblAvailablePartID.TabIndex = 43;
            this.lblAvailablePartID.Text = "PartID";
            // 
            // lblAvailableQuantity
            // 
            this.lblAvailableQuantity.AutoSize = true;
            this.lblAvailableQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblAvailableQuantity.Location = new System.Drawing.Point(98, 32);
            this.lblAvailableQuantity.Name = "lblAvailableQuantity";
            this.lblAvailableQuantity.Size = new System.Drawing.Size(36, 20);
            this.lblAvailableQuantity.TabIndex = 41;
            this.lblAvailableQuantity.Text = "Qty";
            // 
            // btnReturnToTicketSelect
            // 
            this.btnReturnToTicketSelect.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReturnToTicketSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReturnToTicketSelect.ForeColor = System.Drawing.Color.White;
            this.btnReturnToTicketSelect.Location = new System.Drawing.Point(46, 476);
            this.btnReturnToTicketSelect.Name = "btnReturnToTicketSelect";
            this.btnReturnToTicketSelect.Size = new System.Drawing.Size(221, 30);
            this.btnReturnToTicketSelect.TabIndex = 39;
            this.btnReturnToTicketSelect.Text = "Go Back to Ticket Select";
            this.btnReturnToTicketSelect.UseVisualStyleBackColor = false;
            this.btnReturnToTicketSelect.Click += new System.EventHandler(this.btnReturnToTicketSelect_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(42, 275);
            this.lblDescription.MaximumSize = new System.Drawing.Size(290, 180);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 20);
            this.lblDescription.TabIndex = 38;
            this.lblDescription.Text = "Broken Screen";
            // 
            // lblDescriptionTitle
            // 
            this.lblDescriptionTitle.AutoSize = true;
            this.lblDescriptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionTitle.Location = new System.Drawing.Point(42, 236);
            this.lblDescriptionTitle.Name = "lblDescriptionTitle";
            this.lblDescriptionTitle.Size = new System.Drawing.Size(105, 20);
            this.lblDescriptionTitle.TabIndex = 37;
            this.lblDescriptionTitle.Text = "Description:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(189, 195);
            this.lblLastName.MaximumSize = new System.Drawing.Size(150, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(50, 20);
            this.lblLastName.TabIndex = 36;
            this.lblLastName.Text = "Smith";
            // 
            // lblLastNameTitle
            // 
            this.lblLastNameTitle.AutoSize = true;
            this.lblLastNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameTitle.Location = new System.Drawing.Point(42, 195);
            this.lblLastNameTitle.Name = "lblLastNameTitle";
            this.lblLastNameTitle.Size = new System.Drawing.Size(100, 20);
            this.lblLastNameTitle.TabIndex = 35;
            this.lblLastNameTitle.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(189, 155);
            this.lblFirstName.MaximumSize = new System.Drawing.Size(150, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(38, 20);
            this.lblFirstName.TabIndex = 34;
            this.lblFirstName.Text = "Bob";
            // 
            // lblFirstNameTitle
            // 
            this.lblFirstNameTitle.AutoSize = true;
            this.lblFirstNameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameTitle.Location = new System.Drawing.Point(42, 155);
            this.lblFirstNameTitle.Name = "lblFirstNameTitle";
            this.lblFirstNameTitle.Size = new System.Drawing.Size(101, 20);
            this.lblFirstNameTitle.TabIndex = 33;
            this.lblFirstNameTitle.Text = "First Name:";
            // 
            // lblTicketID
            // 
            this.lblTicketID.AutoSize = true;
            this.lblTicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketID.Location = new System.Drawing.Point(189, 114);
            this.lblTicketID.Name = "lblTicketID";
            this.lblTicketID.Size = new System.Drawing.Size(54, 20);
            this.lblTicketID.TabIndex = 32;
            this.lblTicketID.Text = "10001";
            // 
            // lblRepairTicketTitle
            // 
            this.lblRepairTicketTitle.AutoSize = true;
            this.lblRepairTicketTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepairTicketTitle.Location = new System.Drawing.Point(42, 114);
            this.lblRepairTicketTitle.Name = "lblRepairTicketTitle";
            this.lblRepairTicketTitle.Size = new System.Drawing.Size(144, 20);
            this.lblRepairTicketTitle.TabIndex = 31;
            this.lblRepairTicketTitle.Text = "Repair Ticket ID:";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblDetails.Location = new System.Drawing.Point(42, 73);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(123, 20);
            this.lblDetails.TabIndex = 30;
            this.lblDetails.Text = "Repair Details";
            // 
            // btnRemoveParts
            // 
            this.btnRemoveParts.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRemoveParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRemoveParts.ForeColor = System.Drawing.Color.White;
            this.btnRemoveParts.Location = new System.Drawing.Point(903, 327);
            this.btnRemoveParts.Name = "btnRemoveParts";
            this.btnRemoveParts.Size = new System.Drawing.Size(200, 30);
            this.btnRemoveParts.TabIndex = 29;
            this.btnRemoveParts.Text = "Remove Part from Repair";
            this.btnRemoveParts.UseVisualStyleBackColor = false;
            this.btnRemoveParts.Click += new System.EventHandler(this.btnRemoveParts_Click);
            // 
            // lblTotalCostValue
            // 
            this.lblTotalCostValue.AutoSize = true;
            this.lblTotalCostValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalCostValue.Location = new System.Drawing.Point(1215, 337);
            this.lblTotalCostValue.Name = "lblTotalCostValue";
            this.lblTotalCostValue.Size = new System.Drawing.Size(58, 20);
            this.lblTotalCostValue.TabIndex = 28;
            this.lblTotalCostValue.Text = "€30.00";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalCost.Location = new System.Drawing.Point(1124, 337);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(85, 20);
            this.lblTotalCost.TabIndex = 27;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // cboLoggedRepairs
            // 
            this.cboLoggedRepairs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoggedRepairs.FormattingEnabled = true;
            this.cboLoggedRepairs.Location = new System.Drawing.Point(421, 34);
            this.cboLoggedRepairs.Name = "cboLoggedRepairs";
            this.cboLoggedRepairs.Size = new System.Drawing.Size(173, 21);
            this.cboLoggedRepairs.TabIndex = 29;
            // 
            // grpTicketID
            // 
            this.grpTicketID.Controls.Add(this.btnSelectID);
            this.grpTicketID.Controls.Add(this.cboLoggedRepairs);
            this.grpTicketID.Controls.Add(this.lblRepairTicketID);
            this.grpTicketID.Location = new System.Drawing.Point(51, 35);
            this.grpTicketID.Name = "grpTicketID";
            this.grpTicketID.Size = new System.Drawing.Size(1438, 565);
            this.grpTicketID.TabIndex = 1;
            this.grpTicketID.TabStop = false;
            // 
            // frmEstimateRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 706);
            this.Controls.Add(this.mnuBackButton);
            this.Controls.Add(this.grpEstimateCost);
            this.Controls.Add(this.grpTicketID);
            this.MainMenuStrip = this.mnuBackButton;
            this.Name = "frmEstimateRepair";
            this.Text = "Estimate Repair";
            this.Load += new System.EventHandler(this.frmEstimateRepair_Load);
            this.mnuBackButton.ResumeLayout(false);
            this.mnuBackButton.PerformLayout();
            this.grpEstimateCost.ResumeLayout(false);
            this.grpEstimateCost.PerformLayout();
            this.grpRepairParts.ResumeLayout(false);
            this.grpRepairParts.PerformLayout();
            this.grpAvailableParts.ResumeLayout(false);
            this.grpAvailableParts.PerformLayout();
            this.grpTicketID.ResumeLayout(false);
            this.grpTicketID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepairTicketID;
        private System.Windows.Forms.Label lblQtytoBeAdded;
        private System.Windows.Forms.TextBox txtQtytoBeAdded;
        private System.Windows.Forms.ListBox lstPartsAvailable;
        private System.Windows.Forms.Button btnAddPartToRepair;
        private System.Windows.Forms.Button btnEstimateRepair;
        private System.Windows.Forms.MenuStrip mnuBackButton;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ListBox lstRepairParts;
        private System.Windows.Forms.Label lblSearchPart;
        private System.Windows.Forms.TextBox txtPartSearch;
        private System.Windows.Forms.Label lblRepairParts;
        private System.Windows.Forms.Button btnSelectID;
        private System.Windows.Forms.GroupBox grpEstimateCost;
        private System.Windows.Forms.Label lblTotalCostValue;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnRemoveParts;
        private System.Windows.Forms.ComboBox cboLoggedRepairs;
        private System.Windows.Forms.GroupBox grpTicketID;
        private System.Windows.Forms.Button btnReturnToTicketSelect;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDescriptionTitle;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblLastNameTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblFirstNameTitle;
        private System.Windows.Forms.Label lblTicketID;
        private System.Windows.Forms.Label lblRepairTicketTitle;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblAvailableQuantity;
        private System.Windows.Forms.Label lblAvailableParts;
        private System.Windows.Forms.Label lblRepairPartsQuantity;
        private System.Windows.Forms.Label lblAvailablePartID;
        private System.Windows.Forms.Label lblRepairPartID;
        private System.Windows.Forms.GroupBox grpRepairParts;
        private System.Windows.Forms.GroupBox grpAvailableParts;
        private System.Windows.Forms.Label lblRepairPartsCost;
        private System.Windows.Forms.Label lblAvailableCost;
    }
}