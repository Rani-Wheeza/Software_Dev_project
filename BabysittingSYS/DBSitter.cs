using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Oracle.ManagedDataAccess.Client;

namespace BabysittingSYS
{
    class DBSitter
    {
        public int SitterID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string EirCode { get; set; }
        public string Rates { get; set; }
        public string Bio { get; set; }
        public string Skills { get; set; }

       /* public frm_AddSitter(int id, string firstName, string lastName,string DOB, string email, string phoneNo, string street, string town, string eirCode, string rates, string Bio, string skille)
        {
            SitterID = id;
            FirstName = firstName;
            LastName = lastName;
            DOB = DOB;
            Email = email;
            PhoneNo = PhoneNo;
            Street = street;
            Town = town;
            EirCode = eirCode;
            Rates = rates;
            Bio = bio;
            Skills = skills; 

        }*/

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
