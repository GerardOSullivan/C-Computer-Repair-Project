using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace ComputerRepairSYS
{
    public partial class frmLogRepair : Form
    {
        frmMainMenu parent;
        public frmLogRepair()
        {
            InitializeComponent();
        }

        public frmLogRepair(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnLogRepair_Click(object sender, EventArgs e)
        {
            //Validate data
            if (!Utility.IsValidName(txtFirstName.Text))
            {
                MessageBox.Show("First Name field must be added and must not contain digits", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            if (!Utility.IsValidName(txtLastName.Text))
            {
                MessageBox.Show("Last Name field must be added and must not contain digits", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return;
            }

            if (txtAddress.Text.Equals(""))
            {
                MessageBox.Show("Address field must be added", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }

            if (!Utility.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Must Be a valid email", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (!Utility.IsValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Phone number Must be all digits and the phone number must have at least 8 digits long", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("Description field must be added", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }

            //Email Customer Details of the Repair

            //I Got to code for emailing from here https://blog.elmah.io/how-to-send-emails-from-csharp-net-the-definitive-tutorial/
            try
            {

                Utility.emailLogin().Send("computerrepairs187@gmail.com", txtEmail.Text , "Repair " + txtRepairTicketID.Text,
                    "Thank you for chosing to repair with us\n" +
                    "Your Details are as follows:\n\n" +
                    "Repair Ticket ID: " + txtRepairTicketID.Text +
                    "\nDescription of Problem: " + txtDescription.Text +
                    "\n\nThe standard charge for examining the repair is €30. If we are successful in determining the problem then we will email you an updated bill." +
                    "\n\nOur team will look after your repair with the highest respect and care." +
                    "\nWe will be in touch shortly with an update on our progress" +
                    "\n\nRegards" +
                    "\nComputer Repair Management");
            }
            catch
            {
                DialogResult userchoice=MessageBox.Show("Unable to send email. Please check your internet connection and try again. Would you like to continue without sending an email?", "Email not sent!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if(userchoice == DialogResult.No )
                {
                    return;
                }
            }

            //Print RepairTicketID Label
            prntRepairTicketID.Print();

            //save data
            Repair customerRepair = new Repair(Convert.ToInt32(txtRepairTicketID.Text), txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtEircode.Text, txtEmail.Text, Convert.ToInt64(txtPhone.Text), txtDescription.Text);
            customerRepair.logRepair();

            //display conf message
            MessageBox.Show("Repair has been Logged", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtRepairTicketID.Text = Repair.getNextID().ToString("00000");
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtEircode.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtDescription.Clear();
            txtFirstName.Focus();
        }

        private void frmLogRepair_Load(object sender, EventArgs e)
        {
            //Set next RepairTicketID on load
            txtRepairTicketID.Text = Repair.getNextID().ToString("00000");
        }

        private void prntRepairTicketID_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //I got the code for printing from here https://www.youtube.com/watch?v=_q7JlWB9Dy8&ab_channel=FoxLearn
            e.Graphics.DrawString("#"+txtRepairTicketID.Text, new Font("Time New Romans", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }
    }
}
