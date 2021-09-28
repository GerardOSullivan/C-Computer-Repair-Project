using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerRepairSYS
{
    public partial class frmCommenceRepair : Form
    {
        List<Repair> estimatedRepairs = new List<Repair>();
        List<Part> repairParts = new List<Part>();
        frmMainMenu parent;
        public frmCommenceRepair()
        {
            InitializeComponent();
        }

        public frmCommenceRepair(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmCommenceRepair_Load(object sender, EventArgs e)
        {
            //Retrieve all Estimated Repairs
            estimatedRepairs = Repair.loadRepairDetails('E');

            //clear any existing items in the combo box
            cboRepairTicketID.Items.Clear();

            //add all Estimated Repairs to the combo box
            foreach (Repair displayRepair in estimatedRepairs)
            {
                cboRepairTicketID.Items.Add(displayRepair.repairTicketID.ToString("00000"));
            }
        }

        private void cboRepairTicketID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //validate that the user has selected a repair
            if(cboRepairTicketID.SelectedIndex!=-1)
            {
                grpRepairDetails.Visible=true;
            }

            //hide repair parts box 
            grpPartsInRepair.Visible = false;

            //Display Repair Details
            foreach (Repair displayRepair in estimatedRepairs)
            {
                if (displayRepair.repairTicketID.ToString("00000").Equals(cboRepairTicketID.SelectedItem.ToString()))
                {
                    lblRepairTicketIDValue.Text = displayRepair.repairTicketID.ToString("00000");
                    lblFirstNameValue.Text = displayRepair.firstName;
                    lblLastNameValue.Text = displayRepair.lastName;
                    lblDescriptionValue.Text = displayRepair.description;
                    lblTotalCostValue.Text = "€"+displayRepair.totalCost.ToString("0.00");
                }
            }

            //display parts in parts list from the repair items file(if parts were selected for the repair)

            //load all parts from the RepairItems File
            repairParts = RepairItems.loadAllRepairParts(Convert.ToInt32(lblRepairTicketIDValue.Text));

            //Check if Repair has no parts in the Repair Items file(Software issue might not need parts to complete repair)
            if(repairParts.Count==0)
            {
                MessageBox.Show("No parts were recorded for this repair", "No Parts!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //clear any items that may exist in the box 
                lstPartsInRepair.Items.Clear();

                //load all parts on the parts list to be viewed
                foreach (Part displayPart in repairParts)
                {
                    lstPartsInRepair.Items.Add(displayPart.PartID.ToString("00000").PadRight(10) + displayPart.QtyInStock.ToString("0000").PadRight(10) + displayPart.Cost.ToString("   0.00").PadRight(20) + displayPart.PartName);
                }
                grpPartsInRepair.Visible = true;
            }
        }

        private void btnCommenceRepair_Click(object sender, EventArgs e)
        {
            //confirm if repair is to be commenced
            DialogResult userChoice = MessageBox.Show("Would you like to commence the Repair?", "Commence Repair", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (userChoice == DialogResult.No )
            {
                return;
            }

            //email customer receipt of the repair
            //I Got to code for emailing from here https://blog.elmah.io/how-to-send-emails-from-csharp-net-the-definitive-tutorial/
            try
            {

                Utility.emailLogin().Send("computerrepairs187@gmail.com", Repair.getEmail(Convert.ToInt32(lblRepairTicketIDValue.Text)), "Repair " + lblRepairTicketIDValue.Text,
                    "Thank you for chosing to repair with us\n" +
                    "Your Details are as follows:\n\n" +
                    "Repair Ticket ID: " + lblRepairTicketIDValue.Text +
                    "\nDescription of Problem: " + lblDescriptionValue.Text +
                    "\n\nThank you for your payment.We will now commence your repair" +
                    "\n\nOur team will look after your repair with the highest respect and care." +
                    "\nWe will be in touch shortly with an update on our progress" +
                    "\n\nRegards" +
                    "\nComputer Repair Management");
            }
            catch
            {
                DialogResult userchoice = MessageBox.Show("Unable to send email. Please check your internet connection and try again. Would you like to continue without sending an email?", "Email not sent!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (userchoice == DialogResult.No)
                {
                    return;
                }
            }

            //Set status equal to Paid ('P')
            Repair.updateStatus('P', Convert.ToInt32(lblRepairTicketIDValue.Text));

            //Set the Date Paid to the current date in the Repairs file
            Repair.updateDatePaid(Convert.ToInt32(lblRepairTicketIDValue.Text));

            //Display Confirmation message
            MessageBox.Show("The Repair "+lblRepairTicketIDValue.Text+" has Commenced", "Commencing Repair!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            cboRepairTicketID.Items.Clear();
            lstPartsInRepair.Items.Clear();
            grpPartsInRepair.Visible = false;
            estimatedRepairs = Repair.loadRepairDetails('E');
            foreach (Repair displayRepair in estimatedRepairs)
            {
                cboRepairTicketID.Items.Add(displayRepair.repairTicketID.ToString("00000"));
            }
            grpRepairDetails.Visible = false;

        }
    }
}
