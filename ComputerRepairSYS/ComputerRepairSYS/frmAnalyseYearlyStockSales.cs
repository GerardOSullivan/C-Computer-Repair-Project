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
    public partial class frmAnalyseYearlyStockSales : Form
    {
        frmMainMenu parent;
        public frmAnalyseYearlyStockSales()
        {
            InitializeComponent();
        }

        public frmAnalyseYearlyStockSales(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            dtpAnalysisDate.Format = DateTimePickerFormat.Custom;
            dtpAnalysisDate.CustomFormat = "yyyy";
            dtpAnalysisDate.ShowUpDown = true;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmAnalyseYearlyStockSales_Load(object sender, EventArgs e)
        {
            //load current year on UI
            String strSQL = "SELECT SUM(RepairItems.Cost*repairitems.qty),to_Char(Repairs.DatePaid,'MM') FROM Repairs RIGHT OUTER JOIN RepairItems ON RepairItems.RepairTicketID = Repairs.RepairTicketID WHERE Repairs.DatePaid LIKE '%"+dtpAnalysisDate.Value.Year.ToString().Substring(2,2)+"' GROUP BY to_Char(Repairs.DatePaid, 'MM') ORDER BY to_Char(Repairs.DatePaid, 'MM')";

            //populate the chart
            Utility.populateChart(chtRevenueAnalysis, strSQL);

            //add title
            chtRevenueAnalysis.Titles.Add("Yearly Stock Sales");
        }

        private void dtpAnalysisDate_ValueChanged(object sender, EventArgs e)
        {
            //load chosen year on UI
            String strSQL = "SELECT SUM(RepairItems.Cost*repairitems.qty),to_Char(Repairs.DatePaid,'MM') FROM Repairs RIGHT OUTER JOIN RepairItems ON RepairItems.RepairTicketID = Repairs.RepairTicketID WHERE Repairs.DatePaid LIKE '%" + dtpAnalysisDate.Value.Year.ToString().Substring(2, 2) + "' GROUP BY to_Char(Repairs.DatePaid, 'MM') ORDER BY to_Char(Repairs.DatePaid, 'MM')";

            //populate the chart
            Utility.populateChart(chtRevenueAnalysis, strSQL);
        }
    }
}
