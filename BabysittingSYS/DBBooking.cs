using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace BabysittingSYS
{
    class DBBooking
    {
        public int BookingID { get; set; }
        public int ClientID { get; set; }
        public int SitterID { get; set; }
        public DateTime BookingDate { get; set; }
        public string Time { get; set; }
        public string Services { get; set; }
        public string ExtraInformation { get; set; }


        /*public frm_MakeBooking(int bookingID, int sitterID, int clientID, DateTime date, string time, string services, string exterInformation)
        {
            BookingID = bookingID;
            ClientID = clientID;
            SitterID = sitterID;
            BookingDate = date;
            Time = time;
            Services = services;
            ExtraInformation = exterInformation;
        }*/

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
