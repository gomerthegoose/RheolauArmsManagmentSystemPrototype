using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheolauArmsManagmentSystemPrototype
{
    //constant file locations
    internal class Settings
    {
        public string UsrDetailsFile { get; } = @"DataBase\User.txt";
        public string staffDetailsFile { get; } = @"DataBase\Staff.txt";
        public string SundayBookingsFile { get; } = @"DataBase\SundayBookings.txt";
        public string ThursdayBookingsFile { get; } = @"DataBase\SundayBookings.txt";
        public string CustomersFile { get; } = @"DataBase\Customer.txt";
    }
}
