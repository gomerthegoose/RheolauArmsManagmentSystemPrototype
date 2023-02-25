namespace RheolauArmsManagmentSystemPrototype
{

    internal class StaffMenu
    {
        static int defaultPadding = 5;
        public void ViewStaff(Panel View_panel)
        {

            Settings settings = new Settings(); //create nenw instance of login settings
            Cryptography cryptography = new Cryptography();

            Size panelSize = new Size(View_panel.Size.Width - defaultPadding * 6, 80);
            Size textSize = new Size(250, 24);

            StaffInfo[] staffInfo = GetStaffInfo();


            Panel[] panels = new Panel[staffInfo.Length];
            Label[] Forename_Label = new Label[staffInfo.Length];
            Label[] surname_Label = new Label[staffInfo.Length];
            Label[] staffID_Label = new Label[staffInfo.Length];
            Label[] userID_Label = new Label[staffInfo.Length];
            Label[] adress_Label = new Label[staffInfo.Length];
            Label[] PhoneNumber_Label = new Label[staffInfo.Length];
            Label[] Dob_label = new Label[staffInfo.Length];
            Label[] email_label = new Label[staffInfo.Length];

            RemoveControlls(View_panel);

            for (int i = 0; i < staffInfo.Length; i++)
            {

                // - Panel -
                panels[i] = new Panel();
                panels[i].Parent = View_panel;
                panels[i].Location = new Point(defaultPadding, defaultPadding + panelSize.Height * i + defaultPadding * i);
                panels[i].Size = panelSize;
                panels[i].BackColor = Color.FromArgb(66, 96, 138);

                // - forename -
                Forename_Label[i] = new Label();
                Forename_Label[i].Parent = panels[i];
                Forename_Label[i].Text = staffInfo[i].forename;
                Forename_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                Forename_Label[i].Location = new Point(defaultPadding, defaultPadding);
                Forename_Label[i].ForeColor = Color.White;


                // - Surname -
                surname_Label[i] = new Label();
                surname_Label[i].Parent = panels[i];
                surname_Label[i].Text = staffInfo[i].surname;
                surname_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                surname_Label[i].Location = new Point(Forename_Label[i].Location.X + Forename_Label[i].Size.Width, defaultPadding);
                surname_Label[i].ForeColor = Color.White;

                // - staff ID -
                staffID_Label[i] = new Label();
                staffID_Label[i].Parent = panels[i];
                staffID_Label[i].Text = "Staff ID: " + staffInfo[i].staffID.ToString();
                staffID_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                staffID_Label[i].Location = new Point(defaultPadding, Forename_Label[i].Location.Y + Forename_Label[i].Size.Height);
                staffID_Label[i].ForeColor = Color.White;

                // - user ID -
                userID_Label[i] = new Label();
                userID_Label[i].Parent = panels[i];
                userID_Label[i].Text = "User ID: " + staffInfo[i].userID.ToString();
                userID_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                userID_Label[i].Location = new Point(defaultPadding, staffID_Label[i].Location.Y + staffID_Label[i].Size.Height);
                userID_Label[i].ForeColor = Color.White;

                // - adress  -
                adress_Label[i] = new Label(); // new label
                adress_Label[i].Parent = panels[i];
                adress_Label[i].Text = "Adress: " + staffInfo[i].adress;
                adress_Label[i].Size = textSize;
                adress_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                adress_Label[i].Location = new Point(staffID_Label[i].Location.X + staffID_Label[i].Size.Width, Forename_Label[i].Location.Y + Forename_Label[i].Size.Height);
                adress_Label[i].ForeColor = Color.White;

                // - phonenumber -
                PhoneNumber_Label[i] = new Label();
                PhoneNumber_Label[i].Parent = panels[i];
                PhoneNumber_Label[i].Text = "Phone Number: " + staffInfo[i].phonenumber;
                PhoneNumber_Label[i].Size = textSize;
                PhoneNumber_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                PhoneNumber_Label[i].Location = new Point(userID_Label[i].Location.X + userID_Label[i].Size.Width, staffID_Label[i].Location.Y + staffID_Label[i].Size.Height);
                PhoneNumber_Label[i].ForeColor = Color.White;

                // - DOB  -
                Dob_label[i] = new Label();
                Dob_label[i].Parent = panels[i];
                Dob_label[i].Text = "DOB: " + staffInfo[i].DOB;
                Dob_label[i].Size = textSize;
                Dob_label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                Dob_label[i].Location = new Point(adress_Label[i].Location.X + adress_Label[i].Size.Width, Forename_Label[i].Location.Y + Forename_Label[i].Size.Height);
                Dob_label[i].ForeColor = Color.White;

                // - Email  -
                email_label[i] = new Label();
                email_label[i].Parent = panels[i];
                email_label[i].Text = "Email: " + staffInfo[i].email;
                email_label[i].Size = textSize;
                email_label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                email_label[i].Location = new Point(PhoneNumber_Label[i].Location.X + PhoneNumber_Label[i].Size.Width, staffID_Label[i].Location.Y + staffID_Label[i].Size.Height);
                email_label[i].ForeColor = Color.White;
            }
        }
        public void EditStaff(Panel View_panel)
        {

            Settings settings = new Settings(); //create nenw instance of login settings
            Cryptography cryptography = new Cryptography();

            Size textSize = new Size(250, 24);
            Size panelSize = new Size(View_panel.Size.Width - defaultPadding * 6, 80);

            StaffInfo[] staffInfo = GetStaffInfo();

            Panel[] panels = new Panel[staffInfo.Length];
            TextBox[] Forename_TxtBox = new TextBox[staffInfo.Length];
            TextBox[] surname_TxtBox = new TextBox[staffInfo.Length];
            TextBox[] staffID_TxtBox = new TextBox[staffInfo.Length];
            TextBox[] userID_TxtBox = new TextBox[staffInfo.Length];
            TextBox[] adress_TxtBox = new TextBox[staffInfo.Length];
            TextBox[] PhoneNumber_TxtBox = new TextBox[staffInfo.Length];
            TextBox[] Dob_TxtBox = new TextBox[staffInfo.Length];
            TextBox[] email_TxtBox = new TextBox[staffInfo.Length];
            Button[] editEntry_button = new Button[staffInfo.Length];
            Button[] deleteEntry_button = new Button[staffInfo.Length];

            RemoveControlls(View_panel);

            for (int i = 0; i < staffInfo.Length; i++)
            {

                // - Panel -
                panels[i] = new Panel();
                panels[i].Parent = View_panel;
                panels[i].Location = new Point(defaultPadding, defaultPadding + panelSize.Height * i + defaultPadding * i);
                panels[i].Size = panelSize;
                panels[i].BackColor = Color.FromArgb(66, 96, 138);

                // - forename -
                Forename_TxtBox[i] = new TextBox();
                Forename_TxtBox[i].Parent = panels[i];
                Forename_TxtBox[i].Text = staffInfo[i].forename;
                Forename_TxtBox[i].PlaceholderText = "Forename";
                Forename_TxtBox[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                Forename_TxtBox[i].Location = new Point(defaultPadding, defaultPadding);
                Forename_TxtBox[i].ForeColor = Color.Black;


                // - Surname -
                surname_TxtBox[i] = new TextBox();
                surname_TxtBox[i].Parent = panels[i];
                surname_TxtBox[i].Text = staffInfo[i].surname;
                surname_TxtBox[i].PlaceholderText = "Surname";
                surname_TxtBox[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                surname_TxtBox[i].Location = new Point(Forename_TxtBox[i].Location.X + Forename_TxtBox[i].Size.Width, defaultPadding);
                surname_TxtBox[i].ForeColor = Color.Black;

                // - staff ID -
                staffID_TxtBox[i] = new TextBox();
                staffID_TxtBox[i].Parent = panels[i];
                staffID_TxtBox[i].Text = staffInfo[i].staffID.ToString();
                staffID_TxtBox[i].PlaceholderText = "Staff ID";
                staffID_TxtBox[i].Enabled = false;
                staffID_TxtBox[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                staffID_TxtBox[i].Location = new Point(defaultPadding, Forename_TxtBox[i].Location.Y + Forename_TxtBox[i].Size.Height);
                staffID_TxtBox[i].ForeColor = Color.Black;

                // - user ID -
                userID_TxtBox[i] = new TextBox();
                userID_TxtBox[i].Parent = panels[i];
                userID_TxtBox[i].Text = staffInfo[i].userID.ToString();
                userID_TxtBox[i].PlaceholderText = "User ID";
                userID_TxtBox[i].Enabled = false;
                userID_TxtBox[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                userID_TxtBox[i].Location = new Point(defaultPadding, staffID_TxtBox[i].Location.Y + staffID_TxtBox[i].Size.Height);
                userID_TxtBox[i].ForeColor = Color.Black;

                // - adress  -
                adress_TxtBox[i] = new TextBox();
                adress_TxtBox[i].Parent = panels[i];
                adress_TxtBox[i].Text = staffInfo[i].adress;
                adress_TxtBox[i].PlaceholderText = "Adress";
                adress_TxtBox[i].Size = textSize;
                adress_TxtBox[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                adress_TxtBox[i].Location = new Point(staffID_TxtBox[i].Location.X + staffID_TxtBox[i].Size.Width, Forename_TxtBox[i].Location.Y + Forename_TxtBox[i].Size.Height);
                adress_TxtBox[i].ForeColor = Color.Black;

                // - phonenumber -
                PhoneNumber_TxtBox[i] = new TextBox();
                PhoneNumber_TxtBox[i].Parent = panels[i];
                PhoneNumber_TxtBox[i].Text = staffInfo[i].phonenumber;
                PhoneNumber_TxtBox[i].PlaceholderText = "Phone Number";
                PhoneNumber_TxtBox[i].Size = textSize;
                PhoneNumber_TxtBox[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                PhoneNumber_TxtBox[i].Location = new Point(userID_TxtBox[i].Location.X + userID_TxtBox[i].Size.Width, staffID_TxtBox[i].Location.Y + staffID_TxtBox[i].Size.Height);
                PhoneNumber_TxtBox[i].ForeColor = Color.Black;

                // - DOB  -
                Dob_TxtBox[i] = new TextBox();
                Dob_TxtBox[i].Parent = panels[i];
                Dob_TxtBox[i].Text = staffInfo[i].DOB;
                Dob_TxtBox[i].PlaceholderText = "DOB";
                Dob_TxtBox[i].Size = textSize;
                Dob_TxtBox[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                Dob_TxtBox[i].Location = new Point(adress_TxtBox[i].Location.X + adress_TxtBox[i].Size.Width, Forename_TxtBox[i].Location.Y + Forename_TxtBox[i].Size.Height);
                Dob_TxtBox[i].ForeColor = Color.Black;

                // - Email  -
                email_TxtBox[i] = new TextBox();
                email_TxtBox[i].Parent = panels[i];
                email_TxtBox[i].Text = staffInfo[i].email;
                email_TxtBox[i].PlaceholderText = "Email";
                email_TxtBox[i].Size = textSize;
                email_TxtBox[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                email_TxtBox[i].Location = new Point(PhoneNumber_TxtBox[i].Location.X + PhoneNumber_TxtBox[i].Size.Width, staffID_TxtBox[i].Location.Y + staffID_TxtBox[i].Size.Height);
                email_TxtBox[i].ForeColor = Color.Black;

                // - Edit Entry button -
                editEntry_button[i] = new Button();
                editEntry_button[i].Text = "Save Changes!";
                editEntry_button[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                editEntry_button[i].BackColor = Color.FromArgb(64, 199, 73);
                editEntry_button[i].ForeColor = Color.White;
                editEntry_button[i].Location = new Point(panelSize.Width - editEntry_button[i].Size.Width - defaultPadding, defaultPadding);
                editEntry_button[i].Parent = panels[i];
                editEntryButtonAddCallBack(i, staffInfo);


                // - delete entry button -
                deleteEntry_button[i] = new Button();
                deleteEntry_button[i].Text = "Delete";
                deleteEntry_button[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                deleteEntry_button[i].ForeColor = Color.White;
                deleteEntry_button[i].BackColor = Color.Red;
                deleteEntry_button[i].Location = new Point(panelSize.Width - deleteEntry_button[i].Size.Width - defaultPadding, defaultPadding + editEntry_button[i].Location.Y + editEntry_button[i].Size.Height);
                deleteEntry_button[i].Parent = panels[i];
                deleteEntryButtonAddCallBack(i, staffInfo);
            }

            #region - mess -
            void editEntryButtonAddCallBack(int i, StaffInfo[] staffInfo) // not sure why this function is neccasary dosnt work if not in function
            {
                editEntry_button[i].Click += delegate (object sender, EventArgs e) { staffEditSaveEntry(sender, e, i, staffInfo); }; // delegate function to be run on click and pass i to later refer to witch button was pressed
            }

            void deleteEntryButtonAddCallBack(int i, StaffInfo[] staffInfo) // not sure why this function is neccasary dosnt work if not in function
            {
                deleteEntry_button[i].Click += delegate (object sender, EventArgs e) { staffEditDeleteEntry(sender, e, i, staffInfo); }; // delegate function to be run on click and pass i to later refer to witch button was pressed
            }

            void staffEditDeleteEntry(object sender, EventArgs e, int id, StaffInfo[] staffInfo)
            {

                if (MessageBox.Show("Are you Sure you wish to delete this user ?", "Delete ?", MessageBoxButtons.YesNo) == DialogResult.Yes) // ensure that the user is sure to delete 
                {
                    using (StreamWriter sw = new StreamWriter(settings.StaffDetailsFile, false)) // create new stream writer in overwrite mode
                    {
                        for (int i = 0; i < staffInfo.Length; i++)
                        {
                            if (i != id)
                            {
                                sw.WriteLine(cryptography.encryptStr(staffInfo[i].RawData)); // wrtie each line exept for the selected one 
                            }
                        }

                    }
                    //EditStaff_button.PerformClick(); // reload page
                }

            }

            void staffEditSaveEntry(object sender, EventArgs e, int id, StaffInfo[] staffInfo)
            {
                using (StreamWriter sw = new StreamWriter(settings.StaffDetailsFile, false)) // create new stream writer in overwrite mode
                {
                    for (int i = 0; i < staffInfo.Length; i++)
                    {
                        if (i != id)
                        {
                            sw.WriteLine(cryptography.encryptStr(staffInfo[i].RawData)); // wrtie each line exept for the selected one 
                        }
                        else
                        {
                            StaffInfo editedStaffInfo = new StaffInfo();
                            Validator validator = new Validator();

                            editedStaffInfo.staffID = int.Parse(staffID_TxtBox[id].Text);
                            editedStaffInfo.userID = int.Parse(userID_TxtBox[id].Text);
                            editedStaffInfo.forename = Forename_TxtBox[id].Text;
                            editedStaffInfo.surname = surname_TxtBox[id].Text;
                            editedStaffInfo.adress = adress_TxtBox[id].Text;
                            editedStaffInfo.phonenumber = PhoneNumber_TxtBox[id].Text;
                            editedStaffInfo.DOB = Dob_TxtBox[id].Text;
                            editedStaffInfo.email = email_TxtBox[id].Text;

                            // validate string
                            if (!validator.validateStaff(editedStaffInfo).IsError)
                            {
                                string finalString = cryptography.encryptStr(
                                                    editedStaffInfo.staffID.ToString() + "," +
                                                    editedStaffInfo.userID.ToString() + "," +
                                                    editedStaffInfo.surname + "," +
                                                    editedStaffInfo.forename + "," +
                                                    editedStaffInfo.adress + "," +
                                                    editedStaffInfo.phonenumber + "," +
                                                    editedStaffInfo.DOB + "," +
                                                    editedStaffInfo.email
                                                    );



                                sw.WriteLine(finalString);

                                MessageBox.Show("Succesfully saved change !");



                            }
                            else
                            {
                                MessageBox.Show(validator.validateStaff(editedStaffInfo).Message);
                                sw.WriteLine(cryptography.encryptStr(staffInfo[id].RawData)); // write original data if validation fails to ensure that data is not lost 
                            }
                        }
                    }
                }
                //EditStaff_button.PerformClick(); // reload page#
            }
            #endregion

        }
        public void CreateStaff(Panel View_panel)
        {

            Size textSize = new Size(250, 24);
            Size panelSize = new Size(View_panel.Size.Width - defaultPadding * 6, 80);
            Settings settings = new Settings(); //create nenw instance of login settings
            Cryptography cryptography = new Cryptography();



            Panel panels = new Panel();
            TextBox Forename_TxtBox = new TextBox();
            TextBox surname_TxtBox = new TextBox();
            TextBox staffID_TxtBox = new TextBox();
            TextBox userID_TxtBox = new TextBox();
            TextBox adress_TxtBox = new TextBox();
            TextBox PhoneNumber_TxtBox = new TextBox();
            TextBox Dob_TxtBox = new TextBox();
            TextBox email_TxtBox = new TextBox();
            Button createEntry_button = new Button();

            RemoveControlls(View_panel);

            // - Panel -
            panels = new Panel();
            panels.Parent = View_panel;
            panels.Location = new Point(defaultPadding, defaultPadding);
            panels.Size = panelSize;
            panels.BackColor = Color.FromArgb(66, 96, 138);

            // - forename -
            Forename_TxtBox = new TextBox();
            Forename_TxtBox.Parent = panels;
            Forename_TxtBox.PlaceholderText = "Forename";
            Forename_TxtBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Forename_TxtBox.Location = new Point(defaultPadding, defaultPadding);
            Forename_TxtBox.ForeColor = Color.Black;


            // - Surname -
            surname_TxtBox = new TextBox();
            surname_TxtBox.Parent = panels;
            surname_TxtBox.PlaceholderText = "Surname";
            surname_TxtBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            surname_TxtBox.Location = new Point(Forename_TxtBox.Location.X + Forename_TxtBox.Size.Width, defaultPadding);
            surname_TxtBox.ForeColor = Color.Black;

            // - staff ID -
            staffID_TxtBox = new TextBox();
            staffID_TxtBox.Parent = panels;
            staffID_TxtBox.PlaceholderText = "Staff ID";
            staffID_TxtBox.Text = (GetStaffInfo().Length != 0) ? (GetStaffInfo()[GetStaffInfo().Length - 1].staffID + 1).ToString() : "0";
            staffID_TxtBox.Enabled = false;
            staffID_TxtBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            staffID_TxtBox.Location = new Point(defaultPadding, Forename_TxtBox.Location.Y + Forename_TxtBox.Size.Height);
            staffID_TxtBox.ForeColor = Color.Black;

            // - user ID -
            userID_TxtBox = new TextBox();
            userID_TxtBox.Parent = panels;
            userID_TxtBox.PlaceholderText = "User ID";
            userID_TxtBox.Text = (GetStaffInfo().Length != 0) ? (GetStaffInfo()[GetStaffInfo().Length - 1].staffID + 1).ToString() : "0";
            userID_TxtBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            userID_TxtBox.Location = new Point(defaultPadding, staffID_TxtBox.Location.Y + staffID_TxtBox.Size.Height);
            userID_TxtBox.ForeColor = Color.Black;

            // - adress  -
            adress_TxtBox = new TextBox();
            adress_TxtBox.Parent = panels;
            adress_TxtBox.PlaceholderText = "Adress";
            adress_TxtBox.Size = textSize;
            adress_TxtBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            adress_TxtBox.Location = new Point(staffID_TxtBox.Location.X + staffID_TxtBox.Size.Width, Forename_TxtBox.Location.Y + Forename_TxtBox.Size.Height);
            adress_TxtBox.ForeColor = Color.Black;

            // - phonenumber -
            PhoneNumber_TxtBox = new TextBox();
            PhoneNumber_TxtBox.Parent = panels;
            PhoneNumber_TxtBox.PlaceholderText = "Phone Number";
            PhoneNumber_TxtBox.Size = textSize;
            PhoneNumber_TxtBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            PhoneNumber_TxtBox.Location = new Point(userID_TxtBox.Location.X + userID_TxtBox.Size.Width, staffID_TxtBox.Location.Y + staffID_TxtBox.Size.Height);
            PhoneNumber_TxtBox.ForeColor = Color.Black;

            // - DOB  -
            Dob_TxtBox = new TextBox();
            Dob_TxtBox.Parent = panels;
            Dob_TxtBox.PlaceholderText = "DOB";
            Dob_TxtBox.Size = textSize;
            Dob_TxtBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Dob_TxtBox.Location = new Point(adress_TxtBox.Location.X + adress_TxtBox.Size.Width, Forename_TxtBox.Location.Y + Forename_TxtBox.Size.Height);
            Dob_TxtBox.ForeColor = Color.Black;

            // - Email  -
            email_TxtBox = new TextBox();
            email_TxtBox.Parent = panels;
            email_TxtBox.PlaceholderText = "Email";
            email_TxtBox.Size = textSize;
            email_TxtBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            email_TxtBox.Location = new Point(PhoneNumber_TxtBox.Location.X + PhoneNumber_TxtBox.Size.Width, staffID_TxtBox.Location.Y + staffID_TxtBox.Size.Height);
            email_TxtBox.ForeColor = Color.Black;

            // - Create Entry button -
            createEntry_button = new Button();
            createEntry_button.Text = "Save Changes!";
            createEntry_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            createEntry_button.BackColor = Color.FromArgb(64, 199, 73);
            createEntry_button.ForeColor = Color.White;
            createEntry_button.Location = new Point(panelSize.Width - createEntry_button.Size.Width - defaultPadding, defaultPadding);
            createEntry_button.Parent = panels;
            createEntry_button.Click += delegate (object sender, EventArgs e) { staffCreateEntry(sender, e); }; // delegate function to be run on click and pass i to later refer to witch button was pressed

            void staffCreateEntry(object sender, EventArgs e)
            {
                StaffInfo staffInfo = new StaffInfo();
                Validator validator = new Validator();
                try
                {
                    staffInfo.staffID = int.Parse(staffID_TxtBox.Text);
                    staffInfo.userID = int.Parse(userID_TxtBox.Text);
                    staffInfo.forename = Forename_TxtBox.Text;
                    staffInfo.surname = surname_TxtBox.Text;
                    staffInfo.adress = adress_TxtBox.Text;
                    staffInfo.phonenumber = PhoneNumber_TxtBox.Text;
                    staffInfo.DOB = Dob_TxtBox.Text;
                    staffInfo.email = email_TxtBox.Text;
                }
                catch
                {
                    MessageBox.Show("ERROR !\n Please Ensure All Enterd Information is correct !");
                }


                // validate string
                if (!validator.validateStaff(staffInfo).IsError)
                {
                    string finalString = cryptography.encryptStr(
                                        staffInfo.staffID.ToString() + "," +
                                        staffInfo.userID.ToString() + "," +
                                        staffInfo.surname + "," +
                                        staffInfo.forename + "," +
                                        staffInfo.adress + "," +
                                        staffInfo.phonenumber + "," +
                                        staffInfo.DOB + "," +
                                        staffInfo.email
                                        );


                    using (StreamWriter sw = File.AppendText(settings.StaffDetailsFile))
                    {
                        sw.WriteLine(finalString);

                    }
                    MessageBox.Show("Created New Staff Member !");

                    //ViewStaff_button.PerformClick();
                }
                else
                {
                    MessageBox.Show(validator.validateStaff(staffInfo).Message);
                }

                // construct string to be saved to file 


            }

        }
        private StaffInfo[] GetStaffInfo()
        {
            Settings settings = new Settings();
            Cryptography cryptography = new Cryptography();

            StreamReader SrLineCount = new StreamReader(settings.StaffDetailsFile);      // create new stream reader         
            int NumLines = 0; // number of lines in file
            while (SrLineCount.Peek() >= 0) // if not at end of file
            {
                SrLineCount.ReadLine(); //read line to advance file pointer 
                NumLines++; // incriment number of lines 
            }
            SrLineCount.Close(); // close file

            StaffInfo[] staffInfo = new StaffInfo[NumLines]; // create new usr info variable

            using (StreamReader Sr = new StreamReader(settings.StaffDetailsFile)) // create new stream reader
            {

                int i = 0;
                while (Sr.Peek() >= 0) // if not at end of file
                {
                    staffInfo[i].RawData = cryptography.decryptStr(Sr.ReadLine());            //read line from file and decrypt
                    string[] usrDataSingleLine = staffInfo[i].RawData.Split(","); // split read line by ,
                    staffInfo[i].staffID = int.Parse(usrDataSingleLine[0]); // parse first segment staffID
                    staffInfo[i].userID = int.Parse(usrDataSingleLine[1]); // parse second segment userID
                    staffInfo[i].surname = usrDataSingleLine[2]; // parse 3rd secmend surname
                    staffInfo[i].forename = usrDataSingleLine[3]; // parse 4th segment forename
                    staffInfo[i].adress = usrDataSingleLine[4]; // parse 5th segment adress
                    staffInfo[i].phonenumber = usrDataSingleLine[5]; // parse 6th segment phonenumber
                    staffInfo[i].DOB = usrDataSingleLine[6]; // parse 7th segment DOB
                    staffInfo[i].email = usrDataSingleLine[7]; // parse 8th segment email
                    i++;
                }
            }
            return staffInfo;
        }
        private void RemoveControlls(Panel panel)
        {
            while (panel.Controls.Count > 0)
            {
                panel.Controls[0].Dispose(); // remove child if there is one remaining
            }
        }
    }
}
