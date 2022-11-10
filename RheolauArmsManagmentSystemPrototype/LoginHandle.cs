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
            int ID;
            string Username;
            string password;
            int accessLevel;
            string RawData;
        }

        public bool Login(string Username , string Password) //handle login returns true if successfull login
        {
            LoginSettings loginSettings = new LoginSettings(); //create nenw instance of login settings
            getUsrData(loginSettings.UsrDetailsFile);
            return false;
        }

        private UsrInfo getUsrData(string fileLocation)
        {
            UsrInfo usrInfo = new UsrInfo();
            Cryptography cryptography = new Cryptography();

            using (StreamReader Sr = new StreamReader(fileLocation))
            {
                usrInfo. cryptography.decryptStr(Sr.ReadToEnd());
            }
            

            
            return usrInfo;
        }
    }
}
