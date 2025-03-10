using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
//using Oracle.ManagedDataAccess.Client;

namespace BabysittingSYS
{
    class DBSitter
    {
        public int SitterID;
        public String FirstName;
        public String LastName;
        public DateTime DOB;
        public string Email;
        public string PhoneNo;
        public string Street;
        public string Town;
        public string EirCode;
        public decimal Rates;
        public string Bio;
        public string Skills;

       public DBSitter() 
        { 
            this.SitterID = 0;
            this.FirstName = "";
            this.LastName = "";
            this.Street = "";
            this.Town = "";
            this.EirCode = "";
            this.PhoneNo = "";
            this.Email = "";
            this.DOB = DateTime.MinValue; ;
            this.Rates = 0.0m;
            this.Bio = "";
            this.Skills = "";
        }

        public DBSitter(int SitterID, String FirstName, String LastName, DateTime DOB, string Email, string PhoneNo, string Street, string Town, string EirCode, decimal Rates, string Bio, string Skills)
        {
            this.SitterID = SitterID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DOB = DOB;
            this.Email = Email;
            this.PhoneNo = PhoneNo;
            this.Street = Street;
            this.Town = Town;
            this.EirCode = EirCode;
            this.Rates = Rates;
            this.Bio = Bio;
            this.Skills = Skills;
        }

        //getters
        public int getSitterID(){return SitterID;}
        public String getFirstName() { return FirstName; }
        public String getLastName() { return LastName;} 
        public DateTime getDOB() { return DOB; }
        public String getEmail() { return Email; }
        public String getPhoneNo() { return PhoneNo; }
        public String getStreet() { return Street; }
        public String getTown() { return Town;}
        public String getEirCode() { return EirCode; }
        public decimal getRates() { return Rates; }
        public String getBio() { return Bio; }
        public String getSkills() { return Skills; }

        //setters
        public void setSitterID(int SitterID) { this.SitterID = SitterID; }
        public void setFirstName(String FirstName) { this.FirstName = FirstName; }
        public void setLastName(String LastName) { this.LastName = LastName; }
        public void setDOB(DateTime DOB) { this.DOB = DOB; }
        public void setEmail(String Email) { this.Email = Email; }
        public void setPhoneNo(String PhoneNo) { this.PhoneNo = PhoneNo; }
        public void setStreet(String Street) { this.Street = Street; }
        public void setTown(String Town) { this.Town = Town; }
        public void setEirCode(String EirCode) { this.EirCode = EirCode; }
        public void setRates(decimal Rates) { this.Rates = Rates; }
        public void setBio(String Bio) { this.Bio = Bio; }
        public void setSkills(String Skills) { this.Skills = Skills; }

       /* public DataSet GetSitters()
        {
            DataSet ds = new DataSet();
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();
            String strSQL = "SELECT * FROM Sitters ORDER BY SitterID";
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds, "Sitters");
            conn.Close();
            return ds;
        }*/





    }
}
