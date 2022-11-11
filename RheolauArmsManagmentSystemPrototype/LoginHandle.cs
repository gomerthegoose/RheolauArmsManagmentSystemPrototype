using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RheolauArmsManagmentSystemPrototype
{
    internal class LoginHandle
    {

        public struct UsrInfo //used to store usr info
        {
            public int ID;
            public string Username;
            public string password;
            public int accessLevel;
            public string RawData;
        }

        public bool Login(string Username , string Password) //handle login returns true if successfull login
        {
            LoginSettings loginSettings = new LoginSettings(); //create nenw instance of login settings
            
            if (getUsrData(loginSettings.UsrDetailsFile).Username == Username && getUsrData(loginSettings.UsrDetailsFile).password == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private UsrInfo getUsrData(string fileLocation)
        {
            UsrInfo usrInfo = new UsrInfo();
            Cryptography cryptography = new Cryptography();

            using (StreamReader Sr = new StreamReader(fileLocation))
            {
                usrInfo.RawData = cryptography.decryptStr(Sr.ReadToEnd());
            }
            string[] usrDataSingleLine = usrInfo.RawData.Split(",");

            usrInfo.ID = int.Parse(usrDataSingleLine[0]);
            usrInfo.Username = usrDataSingleLine[1];
            usrInfo.password = usrDataSingleLine[2];
            usrInfo.accessLevel = int.Parse(usrDataSingleLine[3]);    
            return usrInfo;
        }
    }
}
