using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRepairSYS
{
    class RepairItems
    {
        public static void logRepairItem(int repairTicketID, int partID, int qty,double cost)
        {
            //Sql Query
            String strSQL = "INSERT INTO RepairItems VALUES("+repairTicketID+","+partID+","+qty+ "," + cost + ")";

            //Declaring an Oracle connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Open Connection
            conn.Open();

            //Declare Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Query
            cmd.ExecuteNonQuery();

            //Close connection
            conn.Close();
        }

        public static List<Part> loadAllRepairParts(int repairTicketID)
        {
            //define Sql Query to get summary of parts in the RepairItems file that match the repairTicketID
            String strSQL = "SELECT RepairItems.PartID,RepairItems.qty,RepairItems.cost,Parts.PartName " +
                "FROM RepairItems " +
                "LEFT OUTER JOIN Parts " +
                "ON RepairItems.PartID = Parts.PartID " +
                "WHERE RepairItems.RepairTicketID="+ repairTicketID +
                " ORDER BY PartID";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();
            da.Fill(ds, "Parts");

            //Close database connection
            conn.Close();

            //Declare a list
            List<Part> displayItems = new List<Part>();

            //Add parts from the Repair Items table to the items list
            for (int i = 0; i < ds.Tables["Parts"].Rows.Count; i++)
            {
                //instantiate a new part object
                Part displayPart = new Part();

                //add the Parts Details
                displayPart.PartID = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                displayPart.QtyInStock = Convert.ToInt32(ds.Tables[0].Rows[i][1].ToString());
                displayPart.Cost = Convert.ToDouble(ds.Tables[0].Rows[i][2].ToString());
                displayPart.PartName = ds.Tables[0].Rows[i][3].ToString();

                //add the new part to the Parts list array
                displayItems.Add(displayPart);
            }

            return displayItems;
        }
    }
}
