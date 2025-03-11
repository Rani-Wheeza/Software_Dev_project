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
        public int BookingID;
        public int ClientID;
        public int SitterID;
        public DateTime BookingDate;
        public string Time;
        public string Services;
        public string ExtraInformation;

        public DBBooking()
        {
            BookingID = 0;
            ClientID = 0;
            SitterID = 0;
            BookingDate = DateTime.MinValue;
            Time = "";
            Services = "";
            ExtraInformation = "";
        }

        public DBBooking(int BookingID, int ClientID, int SitterID, DateTime BookingDate, string Time, string Services, string ExtraInformation)
        {
            this.BookingID = BookingID;
            this.ClientID = ClientID;
            this.SitterID = SitterID;
            this.BookingDate = BookingDate;
            this.Time = Time;
            this.Services = Services;
            this.ExtraInformation = ExtraInformation;
        }

        //getters
        public int getBookingID() { return BookingID; }
        public int getClientID() { return ClientID; }
        public int getSitterID() { return SitterID; }
        public DateTime getBookingDate() { return BookingDate; }
        public string getTime() { return Time; }
        public string getServices() { return Services; }
        public string getExtraInformation() { return ExtraInformation; }

        //setters
        public void setBookingID(int BookingID) { this.BookingID = BookingID; }

        public void setClientID(int ClientID) { this.ClientID = ClientID; }
        public void setSitterID(int SitterID) { this.SitterID = SitterID; }
        public void setBookingDate(DateTime BookingDate) { this.BookingDate = BookingDate; }
        public void setServices(string Services) { this.Services = Services; }
        public void setExtraInformation(string ExtraInformation) { this.ExtraInformation = ExtraInformation; }




    }
}
