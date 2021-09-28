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
    public partial class frmListPart : Form
    {
        List<Part> displayItems = new List<Part>();
        private int intPartID;
        frmMainMenu parent;
        public frmListPart()
        {
            InitializeComponent();
        }

        public frmListPart(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnListPart_Click(object sender, EventArgs e)
        {
            //Validate data
            if (lstParts.SelectedIndex == -1)
            {
                MessageBox.Show("No part selected. Please select a Part from the list", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchPartName.Focus();
                return;
            }

            //Get Part ID
            intPartID = Convert.ToInt32(lstParts.SelectedItem.ToString().Substring(0, 5));

            //Get Part Details
            Part selectedParts = new Part();
            selectedParts.getPartDetails(intPartID);

            //Display part Information
            String status;
            if(selectedParts.Status.ToString()[0] == 'A')
            {
                status = "Available";
            }
            else
            {
                status = "Unavailable";
            }

            MessageBox.Show("Part ID : "+selectedParts.PartID.ToString("00000") +
                            "\nPart Name : " + selectedParts.PartName.ToString() +
                            "\nCost : €" +selectedParts.Cost.ToString("0.00")+
                            "\nStatus : " + status +
                            "\nQuantity In Stock : " + selectedParts.QtyInStock.ToString(), 
                            "Part Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtSearchPartName.Clear();
            txtSearchPartName.Focus();
            lstParts.Items.Clear();
            grpListItems.Visible = false;
            displayItems.Clear();
            displayItems = Part.loadAllParts();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void txtSearchPartName_TextChanged(object sender, EventArgs e)
        {
            // I got this code from https://stackoverflow.com/questions/4878929/c-sharp-searching-a-listbox

            //clear any list items
            lstParts.Items.Clear();
            grpListItems.Visible = false;

            //search listbox
            foreach (Part displayPart in displayItems)
            {
                //Add items into the list box if the text in the search box matches items in the parts table
                if (displayPart.PartName.StartsWith(txtSearchPartName.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    lstParts.Items.Add(displayPart.PartID.ToString("00000").PadRight(20) + displayPart.PartName);
                    grpListItems.Visible = true;
                }

                if (String.IsNullOrEmpty(txtSearchPartName.Text))
                {
                    lstParts.Items.Clear();
                    grpListItems.Visible = false;
                }
            }

            //error message if part not found in database
            if (lstParts.Items.Count == 0 && !String.IsNullOrEmpty(txtSearchPartName.Text))
            {
                MessageBox.Show("The part you are searching for does not match a part in the database. Please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmListPart_Load(object sender, EventArgs e)
        {
            displayItems = Part.loadAllParts();
        }

        private void btnListAllParts_Click(object sender, EventArgs e)
        {
            //clear any existing parts on the parts list
            lstParts.Items.Clear();

            //load all parts on the parts list to be viewed
            foreach (Part displayPart in displayItems)
            {
                lstParts.Items.Add(displayPart.PartID.ToString("00000").PadRight(20) + displayPart.PartName);
            }

            //make list visable
            grpListItems.Visible = true;
        }
    }
}
