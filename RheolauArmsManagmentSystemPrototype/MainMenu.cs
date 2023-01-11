using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RheolauArmsManagmentSystemPrototype
{

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


    public partial class MainMenu : Form
    {
        //------------------------------------------------------------------
        static int defaultPadding = 5;
        //------------------------------------------------------------------
        public MainMenu()
        {
            InitializeComponent();

        }
        //------------------------------------------------------------------
        #region - Main menu  -

        private void StockMenuBtn_Click(object sender, EventArgs e)
        {
            navigationPanel.Hide();
            StockControls_panel.Show();
            StockControls_panel.BringToFront();
            View_panel.Location = new Point(StockControls_panel.Width, StockControls_panel.Location.Y);
            View_panel.Size = new Size(this.Width - StockControls_panel.Size.Width - 15, StockControls_panel.Size.Height);
        }
        private void StaffMenuBtn_Click(object sender, EventArgs e)
        {
            navigationPanel.Hide();
            StaffControls_panel.Show();
            StaffControls_panel.BringToFront();
            View_panel.Location = new Point(StaffControls_panel.Width, StaffControls_panel.Location.Y);
            View_panel.Size = new Size(this.Width - StaffControls_panel.Size.Width - 15  , StaffControls_panel.Size.Height);
        }
        private void ThursdayBookingsBtn_Click(object sender, EventArgs e)
        {
            navigationPanel.Hide();
            ThursdayControls_panel.Show();
            ThursdayControls_panel.BringToFront();
            View_panel.Location = new Point(ThursdayControls_panel.Width , ThursdayControls_panel.Location.Y);
            View_panel.Size = new Size(this.Width - ThursdayControls_panel.Size.Width - 15, ThursdayControls_panel.Size.Height);
        }
        private void SundayBookingsBtn_Click(object sender, EventArgs e)
        {
            navigationPanel.Hide();
            SundayControlls_panel.Show();
            SundayControlls_panel.BringToFront();
            View_panel.Location = new Point(SundayControlls_panel.Width, SundayControlls_panel.Location.Y);
            View_panel.Size = new Size(this.Width - SundayControlls_panel.Size.Width - 15, SundayControlls_panel.Size.Height);
        }
        private void SettingsMenu_button_Click(object sender, EventArgs e)
        {
            navigationPanel.Hide();
            SettingsControls_panel.Show();
            SettingsControls_panel.BringToFront();
            View_panel.Location = new Point(SettingsControls_panel.Width, SettingsControls_panel.Location.Y);
            View_panel.Size = new Size(this.Width - SettingsControls_panel.Size.Width - 15, SettingsControls_panel.Size.Height);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
        //------------------------------------------------------------------
        #region - Staff -
        private void ViewStaff_button_Click(object sender, EventArgs e)
        {
            // remove all children of view panel to clear old information
            while (View_panel.Controls.Count > 0)
            {
                View_panel.Controls[0].Dispose();
            }
            ViewStaff();
        }
        private void EditStaff_button_Click(object sender, EventArgs e)
        {
            // remove all children of view panel to clear old information
            while (View_panel.Controls.Count > 0)
            {
                View_panel.Controls[0].Dispose();
            }
            EditStaff();
        }
        private void createStaff_button_Click(object sender, EventArgs e)
        {
            // remove all children of view panel to clear old information
            while (View_panel.Controls.Count > 0)
            {
                View_panel.Controls[0].Dispose();
            }
            CreateStaff();
        }
        private void StaffReturn_button_Click(object sender, EventArgs e)
        {
            navigationPanel.BringToFront(); // bring main nav panel to front 
            StaffControls_panel.Hide(); // hide current nav panel
            navigationPanel.Show(); // show main nav panel
            View_panel.Location = new Point(navigationPanel.Width, navigationPanel.Location.Y); // reset location of view panel

            // remove all children of view panel to clear old information
            while (View_panel.Controls.Count > 0)
            {
                View_panel.Controls[0].Dispose();
            }

        }
        private void ViewStaff()
        {
            #region - file garbage ish mostly idk -
            LoginSettings settings = new LoginSettings(); //create nenw instance of login settings
            Cryptography cryptography = new Cryptography();
            Graphics graphics = CreateGraphics();

            Size panelSize = new Size(View_panel.Size.Width - defaultPadding * 2, 80);
            Size textSize = new Size(250, 24);


            StreamReader SrLineCount = new StreamReader(settings.staffDetailsFile);      // create new stream reader         
            int NumLines = 0; // number of lines in file
            while (SrLineCount.Peek() >= 0) // if not at end of file
            {
                SrLineCount.ReadLine(); //read line to advance file pointer 
                NumLines++; // incriment number of lines 
            }
            SrLineCount.Close(); // close file

            StaffInfo[] staffInfo = new StaffInfo[NumLines]; // create new usr info variable

            using (StreamReader Sr = new StreamReader(settings.staffDetailsFile)) // create new stream reader
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
            #endregion

            Panel[] panels = new Panel[staffInfo.Length];
            Label[] Forename_Label = new Label[staffInfo.Length];
            Label[] surname_Label = new Label[staffInfo.Length];
            Label[] staffID_Label = new Label[staffInfo.Length];
            Label[] userID_Label = new Label[staffInfo.Length];
            Label[] adress_Label = new Label[staffInfo.Length];
            Label[] PhoneNumber_Label = new Label[staffInfo.Length];
            Label[] Dob_label = new Label[staffInfo.Length];
            Label[] email_label = new Label[staffInfo.Length];

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
                adress_Label[i] = new Label();
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
        private void EditStaff()
        {
            #region - file garbage ish mostly idk -
            LoginSettings settings = new LoginSettings(); //create nenw instance of login settings
            Cryptography cryptography = new Cryptography();
            Graphics graphics = CreateGraphics();

            Size panelSize = new Size(View_panel.Size.Width - defaultPadding * 2, 80);
            Size textSize = new Size(250, 24);

            StreamReader SrLineCount = new StreamReader(settings.staffDetailsFile);      // create new stream reader         
            int NumLines = 0; // number of lines in file
            while (SrLineCount.Peek() >= 0) // if not at end of file
            {
                SrLineCount.ReadLine(); //read line to advance file pointer 
                NumLines++; // incriment number of lines 
            }
            SrLineCount.Close(); // close file

            StaffInfo[] staffInfo = new StaffInfo[NumLines]; // create new usr info variable

            using (StreamReader Sr = new StreamReader(settings.staffDetailsFile)) // create new stream reader
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
            #endregion

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
                staffID_TxtBox[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                staffID_TxtBox[i].Location = new Point(defaultPadding, Forename_TxtBox[i].Location.Y + Forename_TxtBox[i].Size.Height);
                staffID_TxtBox[i].ForeColor = Color.Black;

                // - user ID -
                userID_TxtBox[i] = new TextBox();
                userID_TxtBox[i].Parent = panels[i];
                userID_TxtBox[i].Text = staffInfo[i].userID.ToString();
                userID_TxtBox[i].PlaceholderText = "User ID";
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
                editEntry_button[i].Location = new Point(panelSize.Width - editEntry_button[i].Size.Width - defaultPadding, defaultPadding );
                editEntry_button[i].Parent = panels[i];
                editEntryButtonAddCallBack(i);
                

                // - delete entry button -
                deleteEntry_button[i] = new Button();
                deleteEntry_button[i].Text = "Delete";
                deleteEntry_button[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                deleteEntry_button[i].ForeColor = Color.White;
                deleteEntry_button[i].BackColor = Color.Red;
                deleteEntry_button[i].Location = new Point(panelSize.Width - deleteEntry_button[i].Size.Width - defaultPadding, defaultPadding  + editEntry_button[i].Location.Y + editEntry_button[i].Size.Height);
                deleteEntry_button[i].Parent = panels[i];
                deleteEntryButtonAddCallBack(i);
            }

            #region - mess -
            void editEntryButtonAddCallBack(int i) // not sure why this function is neccasary dosnt work if not in function
            {
                editEntry_button[i].Click += delegate (object sender, EventArgs e) { staffEditSaveEntry(sender, e, i); }; // delegate function to be run on click and pass i to later refer to witch button was pressed
            }

            void deleteEntryButtonAddCallBack(int i) // not sure why this function is neccasary dosnt work if not in function
            {
                deleteEntry_button[i].Click += delegate (object sender, EventArgs e) { staffEditDeleteEntry(sender, e, i); }; // delegate function to be run on click and pass i to later refer to witch button was pressed
            }

            void staffEditDeleteEntry(object sender, EventArgs e,  int id)
            {
                MessageBox.Show("delete: " + id.ToString());
            }

            void staffEditSaveEntry(object sender, EventArgs e, int id)
            {
                MessageBox.Show("Edit: " + id.ToString());
            }
            #endregion

        }
        private void CreateStaff()
        {

            Size panelSize = new Size(View_panel.Size.Width - defaultPadding * 2, 80);
            Size textSize = new Size(250, 24);

            LoginSettings settings = new LoginSettings(); //create nenw instance of login settings
            Cryptography cryptography = new Cryptography();
            Graphics graphics = CreateGraphics();

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
            staffID_TxtBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            staffID_TxtBox.Location = new Point(defaultPadding, Forename_TxtBox.Location.Y + Forename_TxtBox.Size.Height);
            staffID_TxtBox.ForeColor = Color.Black;

            // - user ID -
            userID_TxtBox = new TextBox();
            userID_TxtBox.Parent = panels;
            userID_TxtBox.PlaceholderText = "User ID";
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

                staffInfo.staffID = int.Parse(staffID_TxtBox.Text);
                staffInfo.userID = int.Parse(userID_TxtBox.Text);
                staffInfo.forename = Forename_TxtBox.Text;
                staffInfo.surname = surname_TxtBox.Text;
                staffInfo.adress = adress_TxtBox.Text;
                staffInfo.phonenumber = PhoneNumber_TxtBox.Text;
                staffInfo.DOB = Dob_TxtBox.Text;
                staffInfo.email = email_TxtBox.Text;

                // construct string to be saved to file 

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


                using (StreamWriter sw = File.AppendText(settings.staffDetailsFile))
                {
                    sw.WriteLine(finalString);

                }
            }

        }
        #endregion
        //------------------------------------------------------------------
        #region - Stock -
        private void ViewStock_button_Click(object sender, EventArgs e)
        {

        }

        private void StockReturn_button_Click(object sender, EventArgs e)
        {
            navigationPanel.BringToFront();
            StockControls_panel.Hide();
            navigationPanel.Show();
            View_panel.Location = new Point(navigationPanel.Width, navigationPanel.Location.Y); // reset location of view panel
        }

        #endregion
        //------------------------------------------------------------------
        #region - Sunday Bookings -
        private void ViewSunBookings_button_Click(object sender, EventArgs e)
        {

        }

        private void SundayReturn_button_Click(object sender, EventArgs e)
        {
            navigationPanel.BringToFront();
            SundayControlls_panel.Hide();
            navigationPanel.Show();
            View_panel.Location = new Point(navigationPanel.Width, navigationPanel.Location.Y); // reset location of view panel
        }
        #endregion
        //------------------------------------------------------------------
        #region - Thursday Bookings -
        private void ViewThuBookings_button_Click(object sender, EventArgs e)
        {

        }

        private void ThursdayReturn_button_Click(object sender, EventArgs e)
        {
            navigationPanel.BringToFront();
            ThursdayControls_panel.Hide();
            navigationPanel.Show();
            View_panel.Location = new Point(navigationPanel.Width, navigationPanel.Location.Y); // reset location of view panel
        }
        #endregion
        //------------------------------------------------------------------
        #region - settings -

        private void EncryptString_Button_Click(object sender, EventArgs e)
        {
            Cryptography cryptography = new Cryptography();
            EncryptString_TxtBox.Text = cryptography.encryptStr(EncryptString_TxtBox.Text);
        }
        private void DecryptString_Button_Click(object sender, EventArgs e)
        {
            Cryptography cryptography = new Cryptography();
            EncryptString_TxtBox.Text = cryptography.decryptStr(EncryptString_TxtBox.Text);
        }
        private void SettingsReturn_Button_Click(object sender, EventArgs e)
        {
            navigationPanel.BringToFront(); // bring main nav panel to front 
            SettingsControls_panel.Hide(); // hide current nav panel
            navigationPanel.Show(); // show main nav panel
            View_panel.Location = new Point(navigationPanel.Width, navigationPanel.Location.Y); // reset location of view panel

            // remove all children of view panel to clear old information
            while (View_panel.Controls.Count > 0)
            {
                View_panel.Controls[0].Dispose();
            }
        }



        #endregion
        //------------------------------------------------------------------
    }
}
 