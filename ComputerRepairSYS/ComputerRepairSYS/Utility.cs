using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ComputerRepairSYS
{
    class Utility
    {
        //I got this code from here https://stackoverflow.com/questions/1365407/c-sharp-code-to-validate-email-address

        public static bool IsValidEmail(string email)
        {
            //check if it is not null
            if (email.Equals(""))
            {
                return false;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidName(String name)
        {
            //check if it is not null
            if(name.Equals(""))
            {
                return false;
            }
            else
            {
                //check if it has numbers in it
                for (int i = 0; i < name.Length; i++)
                {

                    if (Char.IsDigit(name[i]))
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public static bool IsValidPhone(String phone)
        {
            //check if it is not null
            if (phone.Equals(""))
            {
                return false;
            }

            if (phone.Length>=8 && phone.Length<=15 && Int64.TryParse(phone, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static SmtpClient emailLogin()
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("computerrepairs187@gmail.com", "vdJF8SEhQmunGmF"),
                EnableSsl = true,
            };

            return smtpClient;
        }

        public static String getMonth(int month)
        {
            switch (month)
            {
                case 1:
                    {
                        return "JAN";

                    }
                case 2:
                    {
                        return "FEB";

                    }
                case 3:
                    {
                        return "MAR";

                    }
                case 4:
                    {
                        return "APR";

                    }
                case 5:
                    {
                        return "MAY";

                    }
                case 6:
                    {
                        return "JUN";

                    }
                case 7:
                    {
                        return "JUL";

                    }
                case 8:
                    {
                        return "AUG";

                    }
                case 9:
                    {
                        return "SEP";

                    }
                case 10:
                    {
                        return "OCT";

                    }
                case 11:
                    {
                        return "NOV";

                    }
                case 12:
                    {
                        return "DEC";

                    }
                default: return "OTH";

            }
        }

        public static void populateChart(Chart currentChart,String strSQL)
        {
            //Declaring an Oracle connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Open Connection
            conn.Open();

            //Declare data table to store data
            DataTable dt = new DataTable();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //fill data table
            da.Fill(dt);

            //check if table is empty
            if(dt.Rows.Count==0)
            {
                currentChart.Visible = false;
                MessageBox.Show("There is no data for the year currently selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                currentChart.Visible = true;
            }

            //close Connection
            conn.Close();

            string[] Months = new string[12];
            decimal[] Revenue = new decimal[12];

            //revenue for every month to zero
            for (int i = 0; i < 12; i++)
            {
                Months[i] = getMonth(i+1);
                Revenue[i] = Convert.ToDecimal(0);
            }

            //add the data to the chart
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Revenue[Convert.ToInt32(dt.Rows[i][1]) - 1] = Convert.ToDecimal(dt.Rows[i][0]);
            }

            //format the chart
            currentChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            currentChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            currentChart.Series[0].LegendText = "Income in €";
            currentChart.Series[0].Points.DataBindXY(Months, Revenue);
            currentChart.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            currentChart.Series[0].Label = "#VALY";
            currentChart.ChartAreas[0].AxisX.Interval = 1;
            currentChart.ChartAreas[0].AxisX.Title = "Month";
            currentChart.ChartAreas[0].AxisY.Title = "Revenue";
        }
    }
}
