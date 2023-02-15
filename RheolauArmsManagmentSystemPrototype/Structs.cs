using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheolauArmsManagmentSystemPrototype
{
    struct BookingInfo
    {
        public string RawData;
        public int bookingID;
        public int customerID;
        public int numberOfPeople;
        public string bookingDate;
        public string bookingTime;
    }
    struct CustomerInfo
    {
        public string RawData;
        public int customerID;
        public string surname;
        public string forename;
        public string phoneNumber;
        public string email;
    }
    struct StaffInfo
    {
        public string RawData;
        public int staffID;
        public int userID;
        public string surname;
        public string forename;
        public string adress;
        public string phonenumber;
        public string DOB;
        public string email;
    }
    struct UsrInfo //used to store usr info
    {
        public int ID;
        public string Username;
        public string password;
        public int accessLevel;
        public string RawData;
    }
}
