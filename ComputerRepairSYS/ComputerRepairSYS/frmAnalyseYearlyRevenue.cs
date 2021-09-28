using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ComputerRepairSYS
{
    public partial class frmAnalyseYearlyRevenue : Form
    {
        frmMainMenu parent;
        public frmAnalyseYearlyRevenue()
        {
            InitializeComponent();
        }

        public frmAnalyseYearlyRevenue(frmMainMenu Parent)
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

        private void frmAnalyseYearlyRevenue_Load(object sender, EventArgs e)
        {
            //load current year on UI
            String strSQL = "SELECT SUM(TotalCost),to_Char(DatePaid,'MM') FROM Repairs WHERE DatePaid LIKE '%"+dtpAnalysisDate.Value.Year.ToString().Substring(2,2)+"' GROUP BY to_Char(DatePaid, 'MM') ORDER BY to_char(DatePaid, 'MM')";

            //populate the chart
            Utility.populateChart(chtRevenueAnalysis,strSQL);

            //add title
            chtRevenueAnalysis.Titles.Add("Yearly Revenue");
        }

        private void dtpAnalysisDate_ValueChanged(object sender, EventArgs e)
        {
            //load chosen year on UI
            String strSQL = "SELECT SUM(TotalCost),to_Char(DatePaid,'MM') FROM Repairs WHERE DatePaid LIKE '%" + dtpAnalysisDate.Value.Year.ToString().Substring(2, 2) + "' GROUP BY to_Char(DatePaid, 'MM') ORDER BY to_char(DatePaid, 'MM')";

            //populate the chart
            Utility.populateChart(chtRevenueAnalysis, strSQL);
        }
    }
}
