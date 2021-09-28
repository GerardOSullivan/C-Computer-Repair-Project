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
    public partial class frmEstimateRepair : Form
    {
        List<Repair> loggedRepairs = new List<Repair>();
        List<Part> availableParts = new List<Part>();
        double dblBasketBalance;

        List<string> items = new List<string>();
        List<string> repairItems = new List<string>();

        frmMainMenu parent;
        public frmEstimateRepair()
        {
            InitializeComponent();

        }
        public frmEstimateRepair(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmEstimateRepair_Load(object sender, EventArgs e)
        {
            //Retrieve all logged Repairs
            loggedRepairs = Repair.loadRepairDetails('L');

            //clear any existing items in cboLoggedRepairs
            cboLoggedRepairs.Items.Clear();

            //add all logged Repairs to the combo box
            foreach (Repair displayRepair in loggedRepairs)
            {
                cboLoggedRepairs.Items.Add(displayRepair.repairTicketID.ToString("00000"));
            }
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            //validate Data
            if (cboLoggedRepairs.SelectedIndex==-1)
            {
                MessageBox.Show("Please Select a valid repair TicketID", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartSearch.Clear();
                txtQtytoBeAdded.Clear();
                grpEstimateCost.Visible = false;
                return;
            }

            //Display Repair Details
            foreach (Repair displayRepair in loggedRepairs)
            {
                if (displayRepair.repairTicketID.ToString("00000").Equals(cboLoggedRepairs.SelectedItem.ToString()))
                {
                    lblTicketID.Text = displayRepair.repairTicketID.ToString("00000");
                    lblFirstName.Text = displayRepair.firstName;
                    lblLastName.Text = displayRepair.lastName;
                    lblDescription.Text = displayRepair.description;
                }
            }

            grpEstimateCost.Visible = true;
            grpTicketID.Visible = false;

            //Set Basket Balance
            dblBasketBalance = 30;

            //Load all available parts from the parts file
            availableParts = Part.loadParts();
        }

        private void btnReturnToTicketSelect_Click(object sender, EventArgs e)
        {
            //reset UI
            lstPartsAvailable.Items.Clear();
            lstRepairParts.Items.Clear();
            txtPartSearch.Clear();
            txtQtytoBeAdded.Clear();
            cboLoggedRepairs.SelectedIndex = -1;
            dblBasketBalance = 30;
            lblTotalCostValue.Text = "€" + dblBasketBalance.ToString("0.00");
            grpEstimateCost.Visible = false;
            grpTicketID.Visible = true;
            grpRepairParts.Visible = false;
        }

        private void txtPartSearch_TextChanged(object sender, EventArgs e)
        {
            //clear any existing items in Parts list
            lstPartsAvailable.Items.Clear();

            foreach (Part displayPart in availableParts)
            {
                //Add items into the list box if the text in the search box matches items in the parts table
                if (displayPart.PartName.StartsWith(txtPartSearch.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lstPartsAvailable.Items.Add(displayPart.PartID.ToString("00000").PadRight(10) + displayPart.QtyInStock.ToString("0000").PadRight(10) + displayPart.Cost.ToString("   0.00").PadRight(20) + displayPart.PartName);
                    grpAvailableParts.Visible = true;
                }

                //If search box is null then clear list box
                if (String.IsNullOrEmpty(txtPartSearch.Text))
                {
                    lstPartsAvailable.Items.Clear();
                    grpAvailableParts.Visible = false;
                }
            }
        }
        
        private void btnAddPartToRepair_Click(object sender, EventArgs e)
        {
            //validate data
            //Check if part selected
            if (lstPartsAvailable.SelectedIndex == -1)
            {
                MessageBox.Show("No part selected!! please select a part to add to the repair", "No part selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartSearch.Focus();
                return;
            }

            //check if Qty is a number or if Qty is null
            if (!Int32.TryParse(txtQtytoBeAdded.Text, out _) || txtQtytoBeAdded.Text.Equals(""))
            {
                MessageBox.Show("Invalid Quantity of parts added for repair! Please enter a valid Quantity", "Invalid Quantity!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtytoBeAdded.Focus();
                return;
            }
            int userQuantity = Convert.ToInt32(txtQtytoBeAdded.Text);

            //check if Qty is equal to zero
            if (userQuantity==0)
            {
                MessageBox.Show("Invalid Quantity!! Please enter a Quantity greater than zero", "Invalid Quantity!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtytoBeAdded.Focus();
                return;
            }

            //validating if there is enough stock of an item
            int localQuantityInstock = Convert.ToInt32(lstPartsAvailable.SelectedItem.ToString().Substring(10,4));
            if (localQuantityInstock<=0)
            {
                MessageBox.Show("Part out of stock! Please select another part", "Not enough stock!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtytoBeAdded.Focus();
                return;
            }
            
            //Validating if user quantity is greater than stock quantity
            if (localQuantityInstock<userQuantity)
            {
                MessageBox.Show("Not enough Quantity of the part available! Please Choose a quantity equal to or lower than stock quantity", "Invalid Quantity!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQtytoBeAdded.Focus();
                return;
            }

            //reduce the quantity of parts on the available parts list
            localQuantityInstock = localQuantityInstock - userQuantity;

            //Add the chosen parts to the repair parts list. First checking to see if it already is in the list
            grpRepairParts.Visible = true;
            int indexOfPart=0;
            bool isInRepairsList=false;
            for (int i = 0; i < lstRepairParts.Items.Count; i++)
            {
                if(lstPartsAvailable.SelectedItem.ToString().Substring(0, 5) == lstRepairParts.Items[i].ToString().Substring(0, 5))
                {

                    indexOfPart = i;
                    isInRepairsList = true;
                }
            }

            if(isInRepairsList)
            {
                userQuantity += Convert.ToInt32(lstRepairParts.Items[indexOfPart].ToString().Substring(10, 4));
                lstRepairParts.Items.RemoveAt(indexOfPart);
                lstRepairParts.Items.Add(lstPartsAvailable.SelectedItem.ToString().Substring(0, 10) + userQuantity.ToString("0000") + lstPartsAvailable.SelectedItem.ToString().Substring(14));
            }
            else
            {
                lstRepairParts.Items.Add(lstPartsAvailable.SelectedItem.ToString().Substring(0, 10) + userQuantity.ToString("0000") + lstPartsAvailable.SelectedItem.ToString().Substring(14));
            }

            foreach (Part displayPart in availableParts)
            {
                if(displayPart.PartID == Convert.ToInt32(lstPartsAvailable.SelectedItem.ToString().Substring(0, 5)))
                {
                    //update quantity in stock
                    displayPart.QtyInStock = localQuantityInstock;

                    //update total cost of repair
                    dblBasketBalance += (Part.getPartCostDetails(displayPart.PartID) * Convert.ToInt32(txtQtytoBeAdded.Text));
                }
            }

            //reload list
            reloadPartsList();

            lblTotalCostValue.Text = "€" + dblBasketBalance.ToString("00.00");

        }

        private void btnRemoveParts_Click(object sender, EventArgs e)
        {
            //validate data
            //Check if part selected
            if (lstRepairParts.SelectedIndex == -1)
            {
                MessageBox.Show("No part selected!! Please select a part to remove from the repair", "No part selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartSearch.Focus();
                return;
            }

            foreach (Part displayPart in availableParts)
            {
                if (displayPart.PartID == Convert.ToInt32(lstRepairParts.SelectedItem.ToString().Substring(0, 5)))
                {
                    //update quantity in stock
                    displayPart.QtyInStock += Convert.ToInt32(lstRepairParts.SelectedItem.ToString().Substring(10, 4));

                    //update total cost of repair
                    dblBasketBalance -= (Part.getPartCostDetails(displayPart.PartID) * Convert.ToInt32(lstRepairParts.SelectedItem.ToString().Substring(10, 4)));
                }
            }

            //remove item from the list
            lstRepairParts.Items.Remove(lstRepairParts.SelectedItem);

            //reload list
            reloadPartsList();

            lblTotalCostValue.Text = "€" + dblBasketBalance.ToString("0.00");
        }

        private void btnEstimateRepair_Click(object sender, EventArgs e)
        {
            //if no parts selected for repair(software issue maybe)
            if(lstRepairParts.Items.Count==0)
            {
                DialogResult userchoice = MessageBox.Show("You have not chosen any parts for this repair. Do you wish to continue? ", "No parts!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (userchoice == DialogResult.No)
                {
                    return;
                }
            }
            //email customer details of the repair

            //I Got to code for emailing from here https://blog.elmah.io/how-to-send-emails-from-csharp-net-the-definitive-tutorial/
            try
            {

                Utility.emailLogin().Send("computerrepairs187@gmail.com", Repair.getEmail(Convert.ToInt32(lblTicketID.Text)) , "Repair " + lblTicketID.Text,
                    "Thank you for chosing to repair with us\n" +
                    "Your Details are as follows:\n\n" +
                    "Repair Ticket ID: " + lblTicketID.Text +
                    "\nDescription of Problem: " + lblDescription.Text +
                    "\n\nWe will be able to fix your computer the total cost of repair will be "+lblTotalCostValue.Text+". If you would like us to continue the repair Please pay the Cost of the Repair." +
                    "\n\nOur team will look after your repair with the highest respect and care." +
                    "\nWe will be in touch shortly with an update on our progress" +
                    "\n\nRegards" +
                    "\nComputer Repair Management");
            }
            catch
            {
                DialogResult userchoice = MessageBox.Show("Unable to connect to the network Please check your internet connection and try again. Would you like to continue without sending an email?", "No Internet Connection!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (userchoice == DialogResult.No )
                {
                    return;
                }
            }

            //get Repair ticket ID
            int repairTicketID = Convert.ToInt32(lblTicketID.Text);

            //Save each item in the cart 
            for (int i=0; i < lstRepairParts.Items.Count;i++)
            {
                int partID = Convert.ToInt32(lstRepairParts.Items[i].ToString().Substring(0, 5));
                int quantityInStock = Convert.ToInt32(lstRepairParts.Items[i].ToString().Substring(10, 4));
                double costOfEachPart = Convert.ToDouble(lstRepairParts.Items[i].ToString().Substring(23, 8));

                //reduce the quantity of stock of parts used in the parts file
                Part.updatePartQuantity(quantityInStock,partID);

                //add the parts from the cart repair items file
                RepairItems.logRepairItem(repairTicketID,partID,quantityInStock,costOfEachPart);
            }

            //System updates the cost of the repair in the repairs file. The system sets the repair status to 'E'
            Repair.updateCostAndStatus(Convert.ToDouble(lblTotalCostValue.Text.Substring(1)), repairTicketID);

            //Display confirmation message
            MessageBox.Show("The Repair has been Estimated", "Estimate complete!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            lstPartsAvailable.Items.Clear();
            lstRepairParts.Items.Clear();
            txtPartSearch.Clear();
            txtQtytoBeAdded.Clear();
            dblBasketBalance = 30;
            lblTotalCostValue.Text = "€" + dblBasketBalance.ToString("0.00");
            cboLoggedRepairs.SelectedIndex = -1;
            cboLoggedRepairs.Items.Clear();
            loggedRepairs = Repair.loadRepairDetails('L');
            foreach (Repair displayRepair in loggedRepairs)
            {
                cboLoggedRepairs.Items.Add(displayRepair.repairTicketID.ToString("00000"));
            }
            grpEstimateCost.Visible = false;
            grpTicketID.Visible = true;
            grpRepairParts.Visible = false;
        }

        public void reloadPartsList()
        {
            lstPartsAvailable.Items.Clear();
            foreach (Part displayPart in availableParts)
            {
                //Add items into the list box if the text in the search box matches items in the parts table
                if (displayPart.PartName.StartsWith(txtPartSearch.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lstPartsAvailable.Items.Add(displayPart.PartID.ToString("00000").PadRight(10) + displayPart.QtyInStock.ToString("0000").PadRight(10) + displayPart.Cost.ToString("   0.00").PadRight(20) + displayPart.PartName);
                }

                //If search box is null then clear list box
                if (String.IsNullOrEmpty(txtPartSearch.Text))
                {
                    lstPartsAvailable.Items.Clear();
                }
            }
        }
    }
}
