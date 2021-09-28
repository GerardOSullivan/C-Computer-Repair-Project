using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRepairSYS
{
    class Repair
    {
        public int repairTicketID;
        public String firstName;
        public String lastName;
        private String address;
        private String eircode;
        private String email;
        private long phone;
        public double totalCost;
        public String description;

        public Repair()
        {
            this.repairTicketID = Repair.getNextID();
            this.firstName = "";
            this.lastName = "";
            this.address = "";
            this.eircode = "";
            this.email = "";
            this.phone = 0;
            this.totalCost = 0;
            this.description = "";
        }

        public Repair(int repairTicketID, String firstName, String lastName, String address,String eircode,String email,long phone,String description)
        {
            this.repairTicketID = repairTicketID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.eircode = eircode;
            this.email = email;
            this.phone = phone;
            this.totalCost = 30;
            this.description = description;
        }

        public static int getNextID()
        {
            //declare variable next ID
            int nextUsableID = 0;

            //Sql Query
            String strSQL = "SELECT MAX(REPAIRTICKETID) FROM Repairs";

            //Declaring an Oracle connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Open Connection
            conn.Open();

            //Declare Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute the command using the Oracle DataReader
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //A value is returned from the Database
            if (dr.IsDBNull(0))
            {
                nextUsableID = 1;
            }
            else
            {
                nextUsableID = dr.GetInt32(0) + 1;
            }

            //Close connection
            conn.Close();

            //return the ID
            return nextUsableID;
        }

        public void logRepair()
        {
            //Sql Query
            String strSQL = "INSERT INTO Repairs VALUES (" + this.repairTicketID + ",'" + this.firstName + "','" + this.lastName + "','" + this.address + "','" + this.eircode + "','" + this.email + "'," + this.phone+ "," +
                "'" + this.description + "',SYSDATE,'L',30,'')";

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

        public static DataSet getRepairTicketDetails(Char status)
        {
            //define Sql Query to get summary of logged Repairs
            String strSQL = "SELECT RepairTicketID,FirstName,LastName,Description,TotalCost FROM Repairs WHERE Status ='"+status+"' ORDER BY RepairTicketID";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an Oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to application
            DataSet ds = new DataSet();
            da.Fill(ds, "Repairs");

            //Close database connection
            conn.Close();
            return ds;
        }

        public static List<Repair> loadRepairDetails(Char status)
        {
            //Declare a list
            List<Repair> displayItems = new List<Repair>();

            //retrieve Repairs for all logged repairs (use DataReader)
            DataSet ds = Repair.getRepairTicketDetails(status);

            //Add repairs from the repairs table to the items list whose status is set to 'L'
            for (int i = 0; i < ds.Tables["Repairs"].Rows.Count; i++)
            {
                //instantiate a new part object
                Repair displayRepair = new Repair();

                //add the repair 
                displayRepair.repairTicketID = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                displayRepair.firstName = ds.Tables[0].Rows[i][1].ToString();
                displayRepair.lastName = ds.Tables[0].Rows[i][2].ToString();
                displayRepair.description = ds.Tables[0].Rows[i][3].ToString();
                displayRepair.totalCost = Convert.ToDouble(ds.Tables[0].Rows[i][4].ToString());

                //add the Repair to the repairs list array
                displayItems.Add(displayRepair);
            }

            return displayItems;
        }

        public static void updateCostAndStatus(double totalCost, int repairTicketID)
        {
            //Sql Query
            String strSQL = "UPDATE Repairs SET TotalCost=" + totalCost + ", Status='E' WHERE repairTicketID=" + repairTicketID;

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

        public static String getEmail(int repairTicketID)
        {
            //Sql Query
            String strSQL = "SELECT Email FROM Repairs WHERE repairTicketID=" + repairTicketID;
            
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            //read the record returned in dr and use values to instantiate the object
            dr.Read();
            String email = dr.GetString(0);

            //close database connection
            conn.Close();

            return email;
        }

        public static void updateStatus(Char status, int repairTicketID)
        {
            //Sql Query
            String strSQL = "UPDATE Repairs SET Status='"+status+"' WHERE repairTicketID=" + repairTicketID;

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

        public static void updateDatePaid(int repairTicketID)
        {
            //Sql Query
            String strSQL = "UPDATE Repairs SET DatePaid=SYSDATE WHERE repairTicketID=" + repairTicketID;

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
    }
}
