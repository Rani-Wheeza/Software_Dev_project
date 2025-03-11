using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace BabysittingSYS
{
    public class DBClient
    {
        public int ClientID;
        public String FirstName;
        public String LastName;
        public string Email;
        public string PhoneNo;
        public string Street;
        public string Town;
        public string EirCode;
        public string NoOfChildren;

        
        public DBClient()
        {
            this.ClientID = 0;
            this.FirstName = "";
            this.LastName = "";
            this.Street = "";
            this.Town = "";
            this.EirCode = "";
            this.PhoneNo = "";
            this.Email = "";
            this.NoOfChildren = "";

        }

        public DBClient(int ClientID, String FirstName, String LastName, string Email, string PhoneNo, string Street, string Town, string EirCode, string NoOfChildren)
        {
            this.ClientID = ClientID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Street = Street;
            this.Town = Town;
            this.EirCode = EirCode;
            this.PhoneNo = PhoneNo;
            this.Email = Email;
            this.NoOfChildren = NoOfChildren;
        }

        //getters
        public int getClientID() { return ClientID; }
        public String getFirstName() { return FirstName; }
        public String getLastName() { return LastName; }
        public String getStreet() { return Street; }
        public String getTown() { return Town; }
        public String getEirCode() { return EirCode; }
        public String getPhoneNo() { return PhoneNo; }
        public String getEmail() { return Email; }
        public String getNoOfChildren() { return NoOfChildren; }

        //setters
        public void setClientID(int ClientID) { this.ClientID = ClientID; }
        public void setFirstName(String FirstName) { this.FirstName = FirstName; }
        public void setLastName(String LastName) { this.LastName = LastName; }
        public void setStreet(String Street) { this.Street = Street; }
        public void setTown(String Town) { this.Town = Town; }
        public void setEirCode(String EirCode) { this.EirCode = EirCode; }
        public void setPhoneNo(String PhoneNo) { this.PhoneNo = PhoneNo; }
        public void setEmail(String Email) { this.Email = Email; }
        public void setNoOfChildren(String NoOfChildren) { this.NoOfChildren = NoOfChildren; }

        public DataSet Client
        {
            get
            {
                DataSet ds = new DataSet();
                //this opens a db connection
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                conn.Open();
                //Define the SQL query to be executed
                String strSQL = "SELECT * FROM Client ORDER BY SitterID";

                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(strSQL, conn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                da.Fill(ds, "Client");
                conn.Close();
                return ds;
            }
        }
    }
}
