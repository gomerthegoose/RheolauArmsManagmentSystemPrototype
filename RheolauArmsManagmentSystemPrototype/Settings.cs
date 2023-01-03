using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheolauArmsManagmentSystemPrototype
{
    internal class LoginSettings
    {
        public string UsrDetailsFile { get; } = @"DataBase\UsrDetails.txt";
        public string staffDetailsFile { get; } = @"DataBase\StaffDetails.txt";

    }
}
