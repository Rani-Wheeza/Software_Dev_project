using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace BabysittingSYS
{
    public class DBClient
    {
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string EirCode { get; set; }
        public string NoOfChildren { get; set; }

        /*public frmAddClient(int id, string firstName,string lastName, string email, string phoneNo, string street, string town, string eirCode, string NoOfChildren)
        {
            ClientID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNo = PhoneNo;
            Street = street;
            Town = town;
            EirCode = eirCode;
            NoOfChildren = NoOfChildren;

        }*/

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
