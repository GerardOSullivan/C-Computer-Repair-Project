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
    public partial class frmUpdatePart : Form
    {
        List<Part> displayItems = new List<Part>();
        private int intPartID;
        frmMainMenu parent;
        public frmUpdatePart()
        {
            InitializeComponent();
        }

        public frmUpdatePart(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnUpdatePart_Click(object sender, EventArgs e)
        {
            //Validate data
            if (txtPartName.Text.Equals(""))
            {
                MessageBox.Show("Part name must be added", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartName.Focus();
                return;
            }

            if (txtPartCost.Text.Equals("") || !Decimal.TryParse(txtPartCost.Text, out _))
            {
                MessageBox.Show("The cost field must be entered and must be numeric", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartCost.Focus();
                return;
            }

            if (txtQuantityInStock.Text.Equals("") || !Int32.TryParse(txtQuantityInStock.Text, out _))
            {
                MessageBox.Show("Quantity in stock field must be added and must be a valid number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantityInStock.Focus();
                return;
            }

            DialogResult userAnswer = MessageBox.Show("Are you sure you sure you wish to update item", "Update Item", MessageBoxButtons.YesNo);
            if (userAnswer == DialogResult.No)
            {
                MessageBox.Show("The part " + lstParts.SelectedItem.ToString().Substring(20) + " has not been Updated", "Part Not Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearchPartName.Clear();
                txtSearchPartName.Focus();
                lstParts.Items.Clear();
                txtPartName.Clear();
                txtQuantityInStock.Clear();
                txtPartCost.Clear();
                grpUpdate.Visible = false;
                grpSearchParts.Visible = true;
                grpListBox.Visible = false;
                grpSearchTextBox.Visible = true;
                return;
            }

            //save data to the database
            Part updatedPart = new Part();
            updatedPart.updateParts(intPartID,txtPartName.Text,Convert.ToDouble(txtPartCost.Text),Convert.ToInt32(txtQuantityInStock.Text));

            //display conf message
            MessageBox.Show("The part "+txtPartName.Text+" has ben Updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            displayItems.Clear();
            displayItems = Part.loadParts();
            txtSearchPartName.Clear();
            txtPartName.Clear();
            txtQuantityInStock.Clear();
            txtPartCost.Clear();
            lstParts.Items.Clear();
            txtSearchPartName.Focus();
            grpUpdate.Visible = false;
            grpListBox.Visible = false;
            grpSearchParts.Visible = true;
        }

        private void txtSearchPartName_TextChanged(object sender, EventArgs e)
        {
            // I got this code from https://stackoverflow.com/questions/4878929/c-sharp-searching-a-listbox

            //clear any existing items in lstParts
            lstParts.Items.Clear();
            grpListBox.Visible = false;

            foreach (Part displayPart in displayItems)
            {
                //Add items into the list box if the text in the search box matches items in the parts table
                if (displayPart.PartName.StartsWith(txtSearchPartName.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lstParts.Items.Add(displayPart.PartID.ToString("00000").PadRight(20) + displayPart.PartName);
                    grpListBox.Visible = true;
                }

                //If search box is null then clear list box
                if(String.IsNullOrEmpty(txtSearchPartName.Text))
                {
                    lstParts.Items.Clear();
                    grpListBox.Visible = false;
                }
            }   
        }

        private void frmUpdatePart_Load(object sender, EventArgs e)
        {
            displayItems=Part.loadParts();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //valitdate data
            if(lstParts.SelectedIndex==-1)
            {
                MessageBox.Show("No part selected. Please select a Part from the list", "No part selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchPartName.Focus();
                grpUpdate.Visible = false;
                return;
            }
            //hide search Items
            grpSearchParts.Visible = false;

            //Get Part ID
            String selectedPartString = lstParts.SelectedItem.ToString();
            intPartID = Convert.ToInt32(selectedPartString.Substring(0,5));

            //Get the Details of the Selected part from the Database
            Part selectedPart = new Part();
            selectedPart.getPartDetails(intPartID);

            //Display the Name,Cost and Quantity in the appropriate text boxes
            txtPartName.Text = Convert.ToString(selectedPart.PartName);
            txtPartCost.Text = Convert.ToString(selectedPart.Cost.ToString("0.00"));
            txtQuantityInStock.Text = Convert.ToString(selectedPart.QtyInStock);

            //Set the group box to visible
            grpUpdate.Visible = true;
        }

        private void btnSelectPart_Click(object sender, EventArgs e)
        {
            //reset UI
            txtSearchPartName.Clear();
            txtPartName.Clear();
            txtQuantityInStock.Clear();
            txtPartCost.Clear();
            lstParts.Items.Clear();
            txtSearchPartName.Focus();
            grpUpdate.Visible = false;
            grpSearchParts.Visible = true;
        }
    }
}
