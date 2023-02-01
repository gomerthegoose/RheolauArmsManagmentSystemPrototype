using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheolauArmsManagmentSystemPrototype
{
    
    internal class SundayBookingsMenu
    {
        static int defaultPadding = 5;
        public void ViewBookings(Panel View_panel)
        {
            #region - file garbage ish mostly idk -
            LoginSettings settings = new LoginSettings(); //create nenw instance of login settings
            Cryptography cryptography = new Cryptography();

            Size panelSize = new Size(View_panel.Size.Width - defaultPadding * 6, 80);
            Size textSize = new Size(250, 24);


            StreamReader SrLineCount = new StreamReader(settings.staffDetailsFile);      // create new stream reader         
            int NumLines = 0; // number of lines in file
            while (SrLineCount.Peek() >= 0) // if not at end of file
            {
                SrLineCount.ReadLine(); //read line to advance file pointer 
                NumLines++; // incriment number of lines 
            }
            SrLineCount.Close(); // close file

            BookingInfo[] bookingInfo = new BookingInfo[NumLines]; // create new usr info variable

            using (StreamReader Sr = new StreamReader(settings.staffDetailsFile)) // create new stream reader
            {

                int i = 0;
                while (Sr.Peek() >= 0) // if not at end of file
                {
                    bookingInfo[i].RawData = cryptography.decryptStr(Sr.ReadLine());            //read line from file and decrypt
                    string[] entry = bookingInfo[i].RawData.Split(","); // split read line by ,
                    bookingInfo[i].bookingID = int.Parse(entry[0]); // parse first field "booking ID"
                    bookingInfo[i].customerID = int.Parse(entry[1]); // parse second field "Customer ID"
                    bookingInfo[i].numberOfPeople = int.Parse(entry[2]); // parse third field "number of people"
                    bookingInfo[i].bookingDate = entry[3];// parse fourth field "Booking Date"
                    bookingInfo[i].bookingTime = entry[4];// parse fith field "booking Time"
                    i++;
                }
            }
            #endregion

            Panel[] panels = new Panel[bookingInfo.Length];
            Label[] bookingID_Label = new Label[bookingInfo.Length];
            Label[] customerID_Label = new Label[bookingInfo.Length];
            Label[] numberOfPeople_Label = new Label[bookingInfo.Length];
            Label[] bookingDate_Label = new Label[bookingInfo.Length];

            Label[] bookingTime_Label = new Label[bookingInfo.Length];


            for (int i = 0; i < bookingInfo.Length; i++)
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
    }
}
