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
    public partial class frmRemovePart : Form
    {
        List<Part> displayItems = new List<Part>();
        private int intPartID;
        frmMainMenu parent;
        public frmRemovePart()
        {
            InitializeComponent();
        }

        public frmRemovePart(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmRemovePart_Load(object sender, EventArgs e)
        {
            displayItems = Part.loadParts();
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
        }

        private void btnRemovePart_Click(object sender, EventArgs e)
        {
            //Validate data
            if (lstParts.SelectedIndex == -1)
            {
                MessageBox.Show("No part selected. Please select a Part from the list", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchPartName.Focus();
                return;
            }

            DialogResult userAnswer=MessageBox.Show("Are you sure you sure you wish to remove the part " + lstParts.SelectedItem.ToString().Substring(20), "Remove Item", MessageBoxButtons.YesNo);
            if(userAnswer==DialogResult.No)
            {
                MessageBox.Show("The part " + lstParts.SelectedItem.ToString().Substring(20) +" has not been Removed", "Part Not Removed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearchPartName.Clear();
                txtSearchPartName.Focus();
                lstParts.Items.Clear();
                return;
            }

            //Get Part ID
            String selectedPartString = lstParts.SelectedItem.ToString();
            intPartID = Convert.ToInt32(selectedPartString.Substring(0, 5));

            //Save Data
            Part partToBeRemoved = new Part();
            partToBeRemoved.removePart(intPartID);

            //display conf message
            MessageBox.Show("The part " +lstParts.SelectedItem.ToString().Substring(20)+" has ben Removed", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtSearchPartName.Clear();
            txtSearchPartName.Focus();
            lstParts.Items.Clear();
            grpListItems.Visible = false;
            displayItems.Clear();
            displayItems = Part.loadParts();

        }
    }
}
