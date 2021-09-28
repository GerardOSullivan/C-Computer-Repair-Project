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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            //ask user to confirm exit

            DialogResult dialog1 = MessageBox.Show("Are you sure you want to exit",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialog1 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuAddPart_Click(object sender, EventArgs e)
        {
            frmAddPart nextform = new frmAddPart(this);
            this.Hide();
            nextform.Show();
        }

        private void mnuUpdatePart_Click(object sender, EventArgs e)
        {
            frmUpdatePart nextform = new frmUpdatePart(this);
            this.Hide();
            nextform.Show();
        }

        private void mnuRemovePart_Click(object sender, EventArgs e)
        {
            frmRemovePart nextform = new frmRemovePart(this);
            this.Hide();
            nextform.Show();
        }

        private void mnuListPart_Click(object sender, EventArgs e)
        {
            frmListPart nextform = new frmListPart(this);
            this.Hide();
            nextform.Show();
        }

        private void mnuLogRepair_Click(object sender, EventArgs e)
        {
            frmLogRepair nextform = new frmLogRepair(this);
            this.Hide();
            nextform.Show();
        }

        private void mnuEstimateRepair_Click(object sender, EventArgs e)
        {
            frmEstimateRepair nextform = new frmEstimateRepair(this);
            this.Hide();
            nextform.Show();
        }

        private void mnuCommenceRepair_Click(object sender, EventArgs e)
        {
            frmCommenceRepair nextform = new frmCommenceRepair(this);
            this.Hide();
            nextform.Show();
        }

        private void mnuFinaliseRepair_Click(object sender, EventArgs e)
        {
            frmFinaliseRepair nextform = new frmFinaliseRepair(this);
            this.Hide();
            nextform.Show();
        }

        private void mnuDispatchRepair_Click(object sender, EventArgs e)
        {
            frmDispatchRepair nextform = new frmDispatchRepair(this);
            this.Hide();
            nextform.Show();
        }

        private void mnuAnalyseYearlyRevenue_Click(object sender, EventArgs e)
        {
            frmAnalyseYearlyRevenue nextform = new frmAnalyseYearlyRevenue(this);
            this.Hide();
            nextform.Show();
        }

        private void mnuAnalyseYearlyParts_Click(object sender, EventArgs e)
        {
            frmAnalyseYearlyStockSales nextform = new frmAnalyseYearlyStockSales(this);
            this.Hide();
            nextform.Show();
        }
    }
}
