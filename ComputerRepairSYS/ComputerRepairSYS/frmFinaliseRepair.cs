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
    public partial class frmFinaliseRepair : Form
    {
        List<Repair> paidRepairs = new List<Repair>();
        frmMainMenu parent;
        public frmFinaliseRepair()
        {
            InitializeComponent();
        }

        public frmFinaliseRepair(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }


        private void frmFinaliseRepair_Load(object sender, EventArgs e)
        {
            //Retrieve all Paid Repairs
            paidRepairs = Repair.loadRepairDetails('P');

            //clear any existing items in the combo box
            cboRepairTicketID.Items.Clear();

            //add all Paid Repairs to the combo box
            foreach (Repair displayRepair in paidRepairs)
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

            //Display Repair Details
            foreach (Repair displayRepair in paidRepairs)
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
        }

        private void btnFinaliseRepair_Click(object sender, EventArgs e)
        {
            //confirm if repair is to be finalised
            DialogResult userChoice = MessageBox.Show("Would you like to Finalise the Repair?", "Finalise Repair", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (userChoice == DialogResult.No)
            {
                return;
            }

            //email customer informing them the repair is finished
            //I Got to code for emailing from here https://blog.elmah.io/how-to-send-emails-from-csharp-net-the-definitive-tutorial/
            try
            {

                Utility.emailLogin().Send("computerrepairs187@gmail.com", Repair.getEmail(Convert.ToInt32(lblRepairTicketIDValue.Text)), "Repair " + lblRepairTicketIDValue.Text,
                    "Thank you for chosing to repair with us\n" +
                    "Your Details are as follows:\n\n" +
                    "Repair Ticket ID: " + lblRepairTicketIDValue.Text +
                    "\nDescription of Problem: " + lblDescriptionValue.Text +
                    "\n\nWe would like to inform you that your Repair has been complete and is ready to be collected." +
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

            //Set status equal to finalised ('F')
            Repair.updateStatus('F', Convert.ToInt32(lblRepairTicketIDValue.Text));

            //Display Confirmation message
            MessageBox.Show("The Repair has been finalised", "Finalised Repair!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            cboRepairTicketID.Items.Clear();
            paidRepairs = Repair.loadRepairDetails('P');
            foreach (Repair displayRepair in paidRepairs)
            {
                cboRepairTicketID.Items.Add(displayRepair.repairTicketID.ToString("00000"));
            }
            grpRepairDetails.Visible = false;
        }
    }
}
