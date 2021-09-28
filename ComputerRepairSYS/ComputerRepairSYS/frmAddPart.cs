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
    public partial class frmAddPart : Form
    {
        frmMainMenu parent;

        public frmAddPart()
        {
            InitializeComponent();
        }

        public frmAddPart(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            //Validate data
            if (txtPartNameBox.Text.Equals(""))
            {
                MessageBox.Show("The part name field must be added", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartNameBox.Focus();
                return;
            }

            if (txtPartCostBox.Text.Equals("") || !Decimal.TryParse(txtPartCostBox.Text, out _))
            {
                MessageBox.Show("The cost field must be entered and must be numeric", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartCostBox.Focus();
                return;
            }

            if (txtQuantityInStockBox.Text.Equals("") || !Int32.TryParse(txtQuantityInStockBox.Text, out _))
            {
                MessageBox.Show("Quantity in stock field must be added and must be a valid number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantityInStockBox.Focus();
                return;
            }

            //save data
            Part partToBeAdded = new Part(Convert.ToInt32(txtPartIDBox.Text),txtPartNameBox.Text, Convert.ToDouble(txtPartCostBox.Text),'A',Convert.ToInt32(txtQuantityInStockBox.Text));
            partToBeAdded.addParts();

            //display conf message
            MessageBox.Show("Part has ben Added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtPartCostBox.Clear();
            txtPartNameBox.Clear();
            txtQuantityInStockBox.Clear();
            txtPartIDBox.Text = Part.getNextID().ToString("00000");
            txtPartNameBox.Focus();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmAddPart_Load(object sender, EventArgs e)
        {
            //Set next Part ID on load
            txtPartIDBox.Text = Part.getNextID().ToString("00000");
        }
    }
}
