
using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace ComputerRepairSYS
{
    class Part
    {
        private int partID;
        private String partName;
        private double cost;
        private char status;
        private int qtyInStock;

        public int PartID { get => partID; set => partID = value; }
        public string PartName { get => partName; set => partName = value; }
        public double Cost { get => cost; set => cost = value; }
        public char Status { get => status; set => status = value; }
        public int QtyInStock { get => qtyInStock; set => qtyInStock = value; }

        public Part()
        {
            PartID = Part.getNextID();
            PartName = "";
            Cost = 0;
            Status = 'A';
            QtyInStock = 0;
        }

        public Part(int partID,String partName,double cost,char status,int qtyInStock)
        {
            this.PartID = partID;
            this.PartName = partName;
            this.Cost = cost;
            this.Status = status;
            this.QtyInStock = qtyInStock;
        }

        public void addParts()
        {
            //Sql Query
            String strSQL = "INSERT INTO Parts VALUES (" +this.PartID +",'"+ this.PartName + "',"+ this.Cost+",'A',"+
                this.QtyInStock+")";

            //Declaring an Oracle connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Open Connection
            conn.Open();

            //Declare Command to execute
            OracleCommand cmd = new OracleCommand(strSQL,conn);

            //Execute Query
            cmd.ExecuteNonQuery();

            //Close connection
            conn.Close();
        }

        public void updateParts(int partID,String partName,double cost,int qtyInStock)
        {
            //Sql Query
            String strSQL = "UPDATE Parts SET PartName = '" + partName + "', Cost = " + cost + ", QtyInStock = " + qtyInStock + " WHERE PartID = " + partID;

            //Declaring an Oracle connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Open Connection
            conn.Open();

            //Declare Command to execute
            OracleCommand cmd = new OracleCommand(strSQL,conn);

            //Execute Query
            cmd.ExecuteNonQuery();

            //Close connection
            conn.Close();
        }

        public static int getNextID()
        {
            //declare variable next ID
            int nextUsableID = 0;

            //Sql Query
            String strSQL = "SELECT MAX(PARTID) FROM Parts";

            //Declaring an Oracle connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Open Connection
            conn.Open();

            //Declare Command to execute
            OracleCommand cmd = new OracleCommand(strSQL,conn);

            //execute the command using the Oracle DataReader
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //A value is returned from the Database
            if (dr.IsDBNull(0))
            {
                nextUsableID= 1;
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

        public static DataSet getPartsSummary()
        {
            //define Sql Query to get summary of available Parts
            String strSQL = "SELECT PartID,PartName,QtyInStock,Cost FROM Parts WHERE Status = 'A' ORDER BY PartID,PartName";

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
            return ds;
        }

        public void getPartDetails(int id)
        {
            //define Sql Query
            String strSQL = "SELECT * FROM Parts WHERE PartID = " + id;

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            //read the record returned in dr and use values to instantiate the object
            dr.Read();
            this.PartID = dr.GetInt32(0);
            this.PartName = dr.GetString(1);
            this.Cost = dr.GetDouble(2);
            this.status = dr.GetString(3)[0];
            this.QtyInStock = dr.GetInt32(4);

            //close database connection
            conn.Close();
        }

        public void removePart(int id)
        {
            //define Sql Query
            String strSQL = "UPDATE Parts SET Status = 'U' WHERE PartID = " + id;

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static List<Part> loadParts()
        {
            //Declare a list
            List<Part> displayItems = new List<Part>();

            //retrieve Part Name for all available parts (use DataReader)
            DataSet ds = Part.getPartsSummary();

            //Add parts from the parts table to the items list whose status is set to 'A'
            for (int i = 0; i < ds.Tables["Parts"].Rows.Count; i++)
            {
                //instantiate a new part object
                Part displayPart = new Part();

                //add the partID and the PartName so the Part Name can be selected from the list box and the ID can be used to retrieve data
                displayPart.PartID = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                displayPart.PartName = ds.Tables[0].Rows[i][1].ToString();
                displayPart.QtyInStock = Convert.ToInt32(ds.Tables[0].Rows[i][2].ToString());
                displayPart.Cost = Convert.ToDouble(ds.Tables[0].Rows[i][3].ToString());

                //add the new part to the Parts list array
                displayItems.Add(displayPart);
            }

            return displayItems;
        }

        public static List<Part> loadAllParts()
        {
            //define Sql Query to get summary of available Parts
            String strSQL = "SELECT PartID,PartName FROM Parts ORDER BY PartName,PartID";

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

            //Add parts from the parts table to the items list
            for (int i = 0; i < ds.Tables["Parts"].Rows.Count; i++)
            {
                //instantiate a new part object
                Part displayPart = new Part();

                //add the partID and the PartName so the Part Name can be selected from the list box and the ID can be used to retrieve data
                displayPart.PartID = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                displayPart.PartName = ds.Tables[0].Rows[i][1].ToString();

                //add the new part to the Parts list array
                displayItems.Add(displayPart);
            }

            return displayItems;
        }

        public static double getPartCostDetails(int id)
        {
            //define Sql Query
            String strSQL = "SELECT Cost FROM Parts WHERE PartID = " + id;

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare an Oracle Command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            //read the record returned in dr and use values to instantiate the object
            dr.Read();
            double cost = dr.GetDouble(0);

            //close database connection
            conn.Close();

            return cost;
        }

        public static void updatePartQuantity(int qtyRemoved,int partID)
        {
            //Sql Query
            String strSQL = "UPDATE Parts SET QtyInStock=QtyInStock-" + qtyRemoved + " WHERE partID=" + partID;

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
