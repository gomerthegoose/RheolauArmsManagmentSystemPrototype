namespace RheolauArmsManagmentSystemPrototype
{
    internal class LoginHandle
    {

        public bool Login(string Username, string Password) //handle login returns true if successfull login
        {
            UserInfo[] usrInfo = getUsrData(); // get usr data from file 

            for (int i = 0; i < usrInfo.Length; i++)
            {
                if (usrInfo[i].Username == Username && usrInfo[i].password == Password) // check if username and password match usr enterd data 
                {
                    return true; // return true if match found 
                }
            }
            return false; // return false if no match found 
        }

        private UserInfo[] getUsrData()
        {
            Settings loginSettings = new Settings(); //create nenw instance of login settings
            Cryptography cryptography = new Cryptography(); // instanciate new cryptography class
            StreamReader SrLineCount = new StreamReader(loginSettings.UserDetailsFile);      // create new stream reader         
            int NumLines = 0; // number of lines in file

            while (SrLineCount.Peek() >= 0) // if not at end of file
            {
                SrLineCount.ReadLine(); //read line to advance file pointer 
                NumLines++; // incriment number of lines 
            }
            SrLineCount.Close(); // close file


            using (StreamReader Sr = new StreamReader(loginSettings.UserDetailsFile)) // create new stream reader
            {
                UserInfo[] usrInfo = new UserInfo[NumLines]; // create new usr info variable
                int i = 0;
                while (Sr.Peek() >= 0) // if not at end of file
                {
                    usrInfo[i].RawData = cryptography.decryptStr(Sr.ReadLine());            //read line from file and decrypt
                    string[] usrDataSingleLine = usrInfo[i].RawData.Split(","); // split read line by ,
                    usrInfo[i].UserID = int.Parse(usrDataSingleLine[0]); // parse first segment ID
                    usrInfo[i].Username = usrDataSingleLine[1]; // parse second segment Username
                    usrInfo[i].password = usrDataSingleLine[2]; // parse 3rd secmend password
                    usrInfo[i].accessLevel = int.Parse(usrDataSingleLine[3]); // parse 4th segment access level
                    i++;
                }
                return usrInfo; // return usr info
            }
        }
    }
}
