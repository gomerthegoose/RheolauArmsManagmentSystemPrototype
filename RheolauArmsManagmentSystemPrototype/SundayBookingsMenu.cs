using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RheolauArmsManagmentSystemPrototype
{
    
    internal class SundayBookingsMenu
    {
        static int defaultPadding = 5;
        public void ViewBookings(Panel View_panel)
        {

            // - variables --------------------------------------------------------------------------------------------------------------------
            Settings settings = new Settings(); //create nenw instance of login settings
            Cryptography cryptography = new Cryptography();

            Size panelSize = new Size(View_panel.Size.Width - defaultPadding * 6, 125);
            Size textSize = new Size(250, 24);

            BookingInfo[] bookingInfo = GetBookingInfo();
            CustomerInfo[] customerInfo = GetCustomerInfo();

            Panel[] panels = new Panel[bookingInfo.Length];
            Label[] bookingID_Label = new Label[bookingInfo.Length];
            Label[] customerID_Label = new Label[bookingInfo.Length];
            Label[] numberOfPeople_Label = new Label[bookingInfo.Length];
            Label[] bookingDate_Label = new Label[bookingInfo.Length];
            Label[] bookingTime_Label = new Label[bookingInfo.Length];

            // - customer information -
            Label[] CustomerSurname_Label = new Label[bookingInfo.Length];
            Label[] CustomerForename_Label = new Label[bookingInfo.Length];
            Label[] CustomerPhonenumber_Label = new Label[bookingInfo.Length];
            Label[] CustomerEmail_Label = new Label[bookingInfo.Length];

            // --------------------------------------------------------------------------------------------------------------------------------

            // - setup controls ---------------------------------------------------------------------------------------------------------------

            for (int i = 0; i < bookingInfo.Length; i++)
            {

                //setup controlls

                // - Panel -
                panels[i] = new Panel();
                panels[i].Parent = View_panel;
                panels[i].Location = new Point(defaultPadding, defaultPadding + panelSize.Height * i + defaultPadding * i);
                panels[i].Size = panelSize;
                panels[i].BackColor = Color.FromArgb(66, 96, 138);

                // - Booking ID -
                bookingID_Label[i] = new Label();
                bookingID_Label[i].Parent = panels[i];
                bookingID_Label[i].Text = "Booking ID: " + bookingInfo[i].bookingID.ToString();
                bookingID_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                bookingID_Label[i].Location = new Point(defaultPadding, defaultPadding);
                bookingID_Label[i].ForeColor = Color.White;

                // - Customer ID -
                customerID_Label[i] = new Label();
                customerID_Label[i].Parent = panels[i];
                customerID_Label[i].Text = "Customer ID: " + bookingInfo[i].customerID.ToString();
                customerID_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                customerID_Label[i].Size = textSize;
                customerID_Label[i].Location = new Point(defaultPadding*2 + 200 + bookingID_Label[i].Size.Width, defaultPadding);
                customerID_Label[i].ForeColor = Color.White;

                // - Number Of People -
                numberOfPeople_Label[i] = new Label();
                numberOfPeople_Label[i].Parent = panels[i];
                numberOfPeople_Label[i].Text ="Number Of people: " + bookingInfo[i].numberOfPeople.ToString();
                numberOfPeople_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                numberOfPeople_Label[i].Size = textSize;
                numberOfPeople_Label[i].Location = new Point(defaultPadding, bookingID_Label[i].Location.Y + bookingID_Label[i].Size.Height);
                numberOfPeople_Label[i].ForeColor = Color.White;

                // - Booking Date -
                bookingDate_Label[i] = new Label();
                bookingDate_Label[i].Parent = panels[i];
                bookingDate_Label[i].Text = "Date: " + bookingInfo[i].bookingDate;
                bookingDate_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                bookingDate_Label[i].Location = new Point(defaultPadding, numberOfPeople_Label[i].Location.Y + numberOfPeople_Label[i].Size.Height);
                bookingDate_Label[i].Size = textSize;
                bookingDate_Label[i].ForeColor = Color.White;

                // - Booking Time  -
                bookingTime_Label[i] = new Label(); // new label
                bookingTime_Label[i].Parent = panels[i];
                bookingTime_Label[i].Text = "Time: " + bookingInfo[i].bookingTime;
                bookingTime_Label[i].Size = textSize;
                bookingTime_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                bookingTime_Label[i].Location = new Point(defaultPadding , bookingDate_Label[i].Location.Y + bookingDate_Label[i].Size.Height);
                bookingDate_Label[i].Size = textSize;
                bookingTime_Label[i].ForeColor = Color.White;

                // - customer surname -
                CustomerSurname_Label[i] = new Label(); // new label
                CustomerSurname_Label[i].Parent = panels[i];
                CustomerSurname_Label[i].Text = "Surname: " + customerInfo[bookingInfo[i].customerID].surname; // 
                CustomerSurname_Label[i].Size = textSize;
                CustomerSurname_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                CustomerSurname_Label[i].Location = new Point(defaultPadding * 2 + 200 + bookingID_Label[i].Size.Width, bookingID_Label[i].Location.Y + bookingID_Label[i].Size.Height);
                CustomerSurname_Label[i].Size = textSize;
                CustomerSurname_Label[i].ForeColor = Color.White;

                // - customer ForeName -
                CustomerForename_Label[i] = new Label(); // new label
                CustomerForename_Label[i].Parent = panels[i];
                CustomerForename_Label[i].Text = "Forename: " + customerInfo[bookingInfo[i].customerID].forename; // 
                CustomerForename_Label[i].Size = textSize;
                CustomerForename_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                CustomerForename_Label[i].Location = new Point(defaultPadding * 2 + 200 + bookingID_Label[i].Size.Width, CustomerSurname_Label[i].Location.Y + CustomerSurname_Label[i].Size.Height);
                CustomerForename_Label[i].Size = textSize;
                CustomerForename_Label[i].ForeColor = Color.White;

                // - customer Phone Number -
                CustomerPhonenumber_Label[i] = new Label(); // new label
                CustomerPhonenumber_Label[i].Parent = panels[i];
                CustomerPhonenumber_Label[i].Text = "PhoneNumber: " + customerInfo[bookingInfo[i].customerID].phoneNumber; // 
                CustomerPhonenumber_Label[i].Size = textSize;
                CustomerPhonenumber_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                CustomerPhonenumber_Label[i].Location = new Point(defaultPadding * 2 + 200 + bookingID_Label[i].Size.Width, CustomerForename_Label[i].Location.Y + CustomerForename_Label[i].Size.Height);
                CustomerPhonenumber_Label[i].Size = textSize;
                CustomerPhonenumber_Label[i].ForeColor = Color.White;

                // - customer Email -
                CustomerEmail_Label[i] = new Label(); // new label
                CustomerEmail_Label[i].Parent = panels[i];
                CustomerEmail_Label[i].Text = "Email: " + customerInfo[bookingInfo[i].customerID].email; // 
                CustomerEmail_Label[i].Size = textSize;
                CustomerEmail_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                CustomerEmail_Label[i].Location = new Point(defaultPadding * 2 + 200 + bookingID_Label[i].Size.Width, CustomerPhonenumber_Label[i].Location.Y + CustomerPhonenumber_Label[i].Size.Height);
                CustomerEmail_Label[i].Size = textSize;
                CustomerEmail_Label[i].ForeColor = Color.White;



                // --------------------------------------------------------------------------------------------------------------------------------
            }
        }
        public void EditBookings(Panel View_panel)
        {

            // - variables --------------------------------------------------------------------------------------------------------------------
            Settings settings = new Settings(); //create nenw instance of login settings
            Cryptography cryptography = new Cryptography();

            Size panelSize = new Size(View_panel.Size.Width - defaultPadding * 6, 125);
            Size textSize = new Size(250, 24);

            BookingInfo[] bookingInfo = GetBookingInfo();
            CustomerInfo[] customerInfo = GetCustomerInfo();

            Panel[] panels = new Panel[bookingInfo.Length];
            TextBox[] bookingID_Label = new TextBox[bookingInfo.Length];
            TextBox[] customerID_Label = new TextBox[bookingInfo.Length];
            TextBox[] numberOfPeople_Label = new TextBox[bookingInfo.Length];
            TextBox[] bookingDate_Label = new TextBox[bookingInfo.Length];
            TextBox[] bookingTime_Label = new TextBox[bookingInfo.Length];

            // - customer information -
            TextBox[] CustomerSurname_Label = new TextBox[bookingInfo.Length];
            TextBox[] CustomerForename_Label = new TextBox[bookingInfo.Length];
            TextBox[] CustomerPhonenumber_Label = new TextBox[bookingInfo.Length];
            TextBox[] CustomerEmail_Label = new TextBox[bookingInfo.Length];

            Button[] editEntry_button = new Button[bookingInfo.Length];
            Button[] deleteEntry_button = new Button[bookingInfo.Length];
            // --------------------------------------------------------------------------------------------------------------------------------

            for (int i = 0; i < bookingInfo.Length; i++)
            {

                //setup controlls

                // - Panel -
                panels[i] = new Panel();
                panels[i].Parent = View_panel;
                panels[i].Location = new Point(defaultPadding, defaultPadding + panelSize.Height * i + defaultPadding * i);
                panels[i].Size = panelSize;
                panels[i].BackColor = Color.FromArgb(66, 96, 138);

                // - Booking ID -
                bookingID_Label[i] = new TextBox();
                bookingID_Label[i].Parent = panels[i];
                bookingID_Label[i].Text = bookingInfo[i].bookingID.ToString();
                bookingID_Label[i].PlaceholderText = "Booking ID";
                bookingID_Label[i].Enabled = false;
                bookingID_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                bookingID_Label[i].Location = new Point(defaultPadding, defaultPadding);
                bookingID_Label[i].ForeColor = Color.Black;

                // - Customer ID -
                customerID_Label[i] = new TextBox();
                customerID_Label[i].Parent = panels[i];
                customerID_Label[i].Text = bookingInfo[i].customerID.ToString();
                customerID_Label[i].Enabled = false;
                customerID_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                customerID_Label[i].Size = textSize;
                customerID_Label[i].Location = new Point(defaultPadding * 2 + 200 + bookingID_Label[i].Size.Width, defaultPadding);
                customerID_Label[i].ForeColor = Color.Black;

                // - Number Of People -
                numberOfPeople_Label[i] = new TextBox();
                numberOfPeople_Label[i].Parent = panels[i];
                numberOfPeople_Label[i].Text = bookingInfo[i].numberOfPeople.ToString();
                numberOfPeople_Label[i].PlaceholderText = "Number Of People";
                numberOfPeople_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                numberOfPeople_Label[i].Size = textSize;
                numberOfPeople_Label[i].Location = new Point(defaultPadding, bookingID_Label[i].Location.Y + bookingID_Label[i].Size.Height);
                numberOfPeople_Label[i].ForeColor = Color.Black;

                // - Booking Date -
                bookingDate_Label[i] = new TextBox();
                bookingDate_Label[i].Parent = panels[i];
                bookingDate_Label[i].Text = bookingInfo[i].bookingDate;
                bookingDate_Label[i].PlaceholderText = "Booking Date";
                bookingDate_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                bookingDate_Label[i].Location = new Point(defaultPadding, numberOfPeople_Label[i].Location.Y + numberOfPeople_Label[i].Size.Height);
                bookingDate_Label[i].Size = textSize;
                bookingDate_Label[i].ForeColor = Color.Black;

                // - Booking Time  -
                bookingTime_Label[i] = new TextBox(); // new label
                bookingTime_Label[i].Parent = panels[i];
                bookingTime_Label[i].Text = bookingInfo[i].bookingTime;
                bookingTime_Label[i].PlaceholderText = "Booking Time";
                bookingTime_Label[i].Size = textSize;
                bookingTime_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                bookingTime_Label[i].Location = new Point(defaultPadding, bookingDate_Label[i].Location.Y + bookingDate_Label[i].Size.Height);
                bookingDate_Label[i].Size = textSize;
                bookingTime_Label[i].ForeColor = Color.Black;

                // - customer surname -
                CustomerSurname_Label[i] = new TextBox(); // new label
                CustomerSurname_Label[i].Parent = panels[i];
                CustomerSurname_Label[i].Text = customerInfo[bookingInfo[i].customerID].surname; // 
                CustomerSurname_Label[i].PlaceholderText = "Surname";
                CustomerSurname_Label[i].Size = textSize;
                CustomerSurname_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                CustomerSurname_Label[i].Location = new Point(defaultPadding * 2 + 200 + bookingID_Label[i].Size.Width, bookingID_Label[i].Location.Y + bookingID_Label[i].Size.Height);
                CustomerSurname_Label[i].Size = textSize;
                CustomerSurname_Label[i].ForeColor = Color.Black;

                // - customer ForeName -
                CustomerForename_Label[i] = new TextBox(); // new label
                CustomerForename_Label[i].Parent = panels[i];
                CustomerForename_Label[i].Text = customerInfo[bookingInfo[i].customerID].forename; // 
                CustomerForename_Label[i].PlaceholderText = "Forename";
                CustomerForename_Label[i].Size = textSize;
                CustomerForename_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                CustomerForename_Label[i].Location = new Point(defaultPadding * 2 + 200 + bookingID_Label[i].Size.Width, CustomerSurname_Label[i].Location.Y + CustomerSurname_Label[i].Size.Height);
                CustomerForename_Label[i].Size = textSize;
                CustomerForename_Label[i].ForeColor = Color.Black;

                // - customer Phone Number -
                CustomerPhonenumber_Label[i] = new TextBox(); // new label
                CustomerPhonenumber_Label[i].Parent = panels[i];
                CustomerPhonenumber_Label[i].Text = customerInfo[bookingInfo[i].customerID].phoneNumber; // 
                CustomerPhonenumber_Label[i].PlaceholderText = "Phonenumber";
                CustomerPhonenumber_Label[i].Size = textSize;
                CustomerPhonenumber_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                CustomerPhonenumber_Label[i].Location = new Point(defaultPadding * 2 + 200 + bookingID_Label[i].Size.Width, CustomerForename_Label[i].Location.Y + CustomerForename_Label[i].Size.Height);
                CustomerPhonenumber_Label[i].Size = textSize;
                CustomerPhonenumber_Label[i].ForeColor = Color.Black;

                // - customer Email -
                CustomerEmail_Label[i] = new TextBox(); // new label
                CustomerEmail_Label[i].Parent = panels[i];
                CustomerEmail_Label[i].Text = customerInfo[bookingInfo[i].customerID].email; // 
                CustomerEmail_Label[i].PlaceholderText = "Email";
                CustomerEmail_Label[i].Size = textSize;
                CustomerEmail_Label[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                CustomerEmail_Label[i].Location = new Point(defaultPadding * 2 + 200 + bookingID_Label[i].Size.Width, CustomerPhonenumber_Label[i].Location.Y + CustomerPhonenumber_Label[i].Size.Height);
                CustomerEmail_Label[i].Size = textSize;
                CustomerEmail_Label[i].ForeColor = Color.Black;

                // - Edit Entry button -
                editEntry_button[i] = new Button();
                editEntry_button[i].Text = "Save Changes!";
                editEntry_button[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                editEntry_button[i].BackColor = Color.FromArgb(64, 199, 73);
                editEntry_button[i].ForeColor = Color.White;
                editEntry_button[i].Location = new Point(panelSize.Width - editEntry_button[i].Size.Width - defaultPadding, defaultPadding);
                editEntry_button[i].Parent = panels[i];
                editEntryButtonAddCallBack(i, bookingInfo[i].customerID, customerInfo,bookingInfo);


                // - delete entry button -
                deleteEntry_button[i] = new Button();
                deleteEntry_button[i].Text = "Delete";
                deleteEntry_button[i].Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                deleteEntry_button[i].ForeColor = Color.White;
                deleteEntry_button[i].BackColor = Color.Red;
                deleteEntry_button[i].Location = new Point(panelSize.Width - deleteEntry_button[i].Size.Width - defaultPadding, defaultPadding + editEntry_button[i].Location.Y + editEntry_button[i].Size.Height);
                deleteEntry_button[i].Parent = panels[i];
                deleteEntryButtonAddCallBack(i, bookingInfo[i].customerID, customerInfo,bookingInfo);



                // --------------------------------------------------------------------------------------------------------------------------------

                // - Save and edit buttons --------------------------------------------------------------------------------------------------------

                void editEntryButtonAddCallBack(int BookingID,int customerID, CustomerInfo[] customerInfo, BookingInfo[] bookingInfo) // not sure why this function is neccasary dosnt work if not in function
                {
                    editEntry_button[i].Click += delegate (object sender, EventArgs e) { SaveEntry(sender, e, BookingID, customerID, customerInfo, bookingInfo); }; // delegate function to be run on click and pass i to later refer to witch button was pressed
                }

                void deleteEntryButtonAddCallBack(int BookingID, int customerID, CustomerInfo[] customerInfo, BookingInfo[] bookingInfo) // not sure why this function is neccasary dosnt work if not in function
                {
                    deleteEntry_button[i].Click += delegate (object sender, EventArgs e) { DeleteEntry(sender, e, BookingID, customerID, customerInfo, bookingInfo); }; // delegate function to be run on click and pass i to later refer to witch button was pressed
                }

                void DeleteEntry(object sender, EventArgs e, int BookingID, int customerID, CustomerInfo[] customerInfo, BookingInfo[] bookingInfo)
                {
                    //delete entry in both customer and bookings file
                    if (MessageBox.Show("Are you Sure you wish to delete this user ?", "Delete ?", MessageBoxButtons.YesNo) == DialogResult.Yes) // ensure that the user is sure to delete 
                    {
                        using (StreamWriter sw = new StreamWriter(settings.SundayBookingsFile, false)) // bookings
                        {
                            for (int i = 0; i < bookingInfo.Length; i++)
                            {
                                if (i != BookingID)
                                {
                                    sw.WriteLine(cryptography.encryptStr(bookingInfo[i].RawData)); // wrtie each line exept for the selected one 
                                }
                            }

                        }
                        using (StreamWriter sw = new StreamWriter(settings.CustomersFile, false)) // customers 
                        {
                            for (int i = 0; i < customerInfo.Length; i++)
                            {
                                if (i != customerID)
                                {
                                    sw.WriteLine(cryptography.encryptStr(customerInfo[i].RawData)); // wrtie each line exept for the selected one 
                                }
                            }

                        }
                    }

                }

                void SaveEntry(object sender, EventArgs e, int BookingID, int customerID, CustomerInfo[] customerInfo, BookingInfo[] bookingInfo)
                {

                    CustomerInfo editedCustomerInfo = new CustomerInfo();
                    BookingInfo editedBookingInfo = new BookingInfo();
                    Validator validator = new Validator();

                    //this code is confusing and i cant explain it 
                    editedCustomerInfo.customerID = int.Parse(customerID_Label[BookingID].Text);
                    editedCustomerInfo.forename = CustomerForename_Label[BookingID].Text;
                    editedCustomerInfo.surname = CustomerSurname_Label[BookingID].Text;
                    editedCustomerInfo.phoneNumber = CustomerPhonenumber_Label[BookingID].Text;
                    editedCustomerInfo.email = CustomerEmail_Label[BookingID].Text;

                    editedBookingInfo.bookingID = int.Parse(bookingID_Label[BookingID].Text);
                    editedBookingInfo.customerID = int.Parse(customerID_Label[BookingID].Text);
                    editedBookingInfo.numberOfPeople = int.Parse(numberOfPeople_Label[BookingID].Text);
                    editedBookingInfo.bookingDate = bookingDate_Label[BookingID].Text;
                    editedBookingInfo.bookingTime = bookingTime_Label[BookingID].Text;

                    if (!validator.validateCustomer(editedCustomerInfo).IsError && !validator.validateBooking(editedBookingInfo).IsError)
                    {
                        using (StreamWriter sw = new StreamWriter(settings.CustomersFile, false)) // save customer data 
                        {
                            for (int i = 0; i < customerInfo.Length; i++)
                            {
                                if (i != customerID)
                                {
                                    sw.WriteLine(cryptography.encryptStr(customerInfo[i].RawData)); // wrtie each line exept for the selected one 
                                }
                                else
                                {
                                        string finalString = cryptography.encryptStr(
                                                            editedCustomerInfo.customerID.ToString() + "," +
                                                            editedCustomerInfo.surname + "," +
                                                            editedCustomerInfo.forename + "," +
                                                            editedCustomerInfo.phoneNumber + "," +
                                                            editedCustomerInfo.email
                                                            );

                                        sw.WriteLine(finalString);                              
                                }
                            }
                        }

                        using (StreamWriter sw = new StreamWriter(settings.SundayBookingsFile, false)) // save customer data 
                        {
                            for (int i = 0; i < bookingInfo.Length; i++)
                            {
                                if (i != BookingID)
                                {
                                    sw.WriteLine(cryptography.encryptStr(bookingInfo[i].RawData)); // wrtie each line exept for the selected one 
                                }
                                else
                                {
                                    string finalString = cryptography.encryptStr(
                                                        editedBookingInfo.bookingID.ToString() + "," +
                                                        editedBookingInfo.customerID.ToString() + "," +
                                                        editedBookingInfo.numberOfPeople.ToString() + "," +
                                                        editedBookingInfo.bookingDate + "," +
                                                        editedBookingInfo.bookingTime
                                                        );

                                    sw.WriteLine(finalString);

                                    MessageBox.Show("Succesfully saved change !");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(validator.validateBooking(editedBookingInfo).Message);
                        MessageBox.Show(validator.validateCustomer(editedCustomerInfo).Message);
                    }
                } 
            }
        }
        public void CreateBooking(Panel View_panel)
        {

            Size textSize = new Size(250, 24);
            Size panelSize = new Size(View_panel.Size.Width - defaultPadding * 6, 125);
            Settings settings = new Settings(); //create nenw instance of login settings
            Cryptography cryptography = new Cryptography();

            StreamReader SrLineCount = new StreamReader(settings.staffDetailsFile);      // create new stream reader         
            int NumLines = 0; // number of lines in file
            while (SrLineCount.Peek() >= 0) // if not at end of file
            {
                SrLineCount.ReadLine(); //read line to advance file pointer 
                NumLines++; // incriment number of lines 
            }
            SrLineCount.Close(); // close file



            Panel panels = new Panel();
            TextBox bookingID_TextBox = new TextBox();
            TextBox customerID_TextBox = new TextBox();
            TextBox numberOfPeople_TextBox = new TextBox();
            TextBox bookingDate_TextBox = new TextBox();
            TextBox bookingTime_TextBox = new TextBox();

            // - customer information -
            TextBox CustomerSurname_TextBox = new TextBox();
            TextBox CustomerForename_TextBox = new TextBox();
            TextBox CustomerPhonenumber_TextBox = new TextBox();
            TextBox CustomerEmail_TextBox = new TextBox();

            Button createEntry_button = new Button();

            //setup controlls

            // - Panel -
            panels = new Panel();
            panels.Parent = View_panel;
            panels.Location = new Point(defaultPadding, defaultPadding);
            panels.Size = panelSize;
            panels.BackColor = Color.FromArgb(66, 96, 138);

            // - Booking ID -
            bookingID_TextBox = new TextBox();
            bookingID_TextBox.Parent = panels;
            bookingID_TextBox.Text = (GetBookingInfo().Length != 0) ? (GetBookingInfo()[GetBookingInfo().Length - 1].bookingID + 1).ToString() : "0"; // get next availabele booking ID, i hate this but ohh well it stays
            bookingID_TextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bookingID_TextBox.Location = new Point(defaultPadding, defaultPadding);
            bookingID_TextBox.ForeColor = Color.Black;

            // - Customer ID -
            customerID_TextBox = new TextBox();
            customerID_TextBox.Parent = panels;
            customerID_TextBox.Text = (GetCustomerInfo().Length != 0) ? (GetCustomerInfo()[GetCustomerInfo().Length - 1].customerID + 1).ToString() : "0"; // get next availabele customer ID, i also hate this but my ability has not changed since 6 lines ago 
            customerID_TextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            customerID_TextBox.Enabled = false;
            customerID_TextBox.Size = textSize;
            customerID_TextBox.Location = new Point(defaultPadding * 2 + 200 + bookingID_TextBox.Size.Width, defaultPadding);
            customerID_TextBox.ForeColor = Color.Black;

            // - Number Of People -
            numberOfPeople_TextBox = new TextBox();
            numberOfPeople_TextBox.Parent = panels;
            numberOfPeople_TextBox.PlaceholderText = "Number Of People";
            numberOfPeople_TextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            numberOfPeople_TextBox.Size = textSize;
            numberOfPeople_TextBox.Location = new Point(defaultPadding, bookingID_TextBox.Location.Y + bookingID_TextBox.Size.Height);
            numberOfPeople_TextBox.ForeColor = Color.Black;

            // - Booking Date -
            bookingDate_TextBox = new TextBox();
            bookingDate_TextBox.Parent = panels;
            bookingDate_TextBox.PlaceholderText = "Booking Date";
            bookingDate_TextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bookingDate_TextBox.Location = new Point(defaultPadding, numberOfPeople_TextBox.Location.Y + numberOfPeople_TextBox.Size.Height);
            bookingDate_TextBox.Size = textSize;
            bookingDate_TextBox.ForeColor = Color.Black;

            // - Booking Time  -
            bookingTime_TextBox = new TextBox(); // new label
            bookingTime_TextBox.Parent = panels;
            bookingTime_TextBox.Size = textSize;
            bookingTime_TextBox.PlaceholderText = "Booking Time";
            bookingTime_TextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bookingTime_TextBox.Location = new Point(defaultPadding, bookingDate_TextBox.Location.Y + bookingDate_TextBox.Size.Height);
            bookingDate_TextBox.Size = textSize;
            bookingTime_TextBox.ForeColor = Color.Black;

            // - customer surname -
            CustomerSurname_TextBox = new TextBox(); // new label
            CustomerSurname_TextBox.Parent = panels;
            CustomerSurname_TextBox.Size = textSize;
            CustomerSurname_TextBox.PlaceholderText = "Surname";
            CustomerSurname_TextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CustomerSurname_TextBox.Location = new Point(defaultPadding * 2 + 200 + bookingID_TextBox.Size.Width, bookingID_TextBox.Location.Y + bookingID_TextBox.Size.Height);
            CustomerSurname_TextBox.Size = textSize;
            CustomerSurname_TextBox.ForeColor = Color.Black;

            // - customer ForeName -
            CustomerForename_TextBox = new TextBox(); // new label
            CustomerForename_TextBox.Parent = panels;
            CustomerForename_TextBox.Size = textSize;
            CustomerForename_TextBox.PlaceholderText = "Forename";
            CustomerForename_TextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CustomerForename_TextBox.Location = new Point(defaultPadding * 2 + 200 + bookingID_TextBox.Size.Width, CustomerSurname_TextBox.Location.Y + CustomerSurname_TextBox.Size.Height);
            CustomerForename_TextBox.Size = textSize;
            CustomerForename_TextBox.ForeColor = Color.Black;

            // - customer Phone Number -
            CustomerPhonenumber_TextBox = new TextBox(); // new label
            CustomerPhonenumber_TextBox.Parent = panels;
            CustomerPhonenumber_TextBox.Size = textSize;
            CustomerPhonenumber_TextBox.PlaceholderText = "Phonenumber";
            CustomerPhonenumber_TextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CustomerPhonenumber_TextBox.Location = new Point(defaultPadding * 2 + 200 + bookingID_TextBox.Size.Width, CustomerForename_TextBox.Location.Y + CustomerForename_TextBox.Size.Height);
            CustomerPhonenumber_TextBox.Size = textSize;
            CustomerPhonenumber_TextBox.ForeColor = Color.Black;

            // - customer Email -
            CustomerEmail_TextBox = new TextBox(); // new label
            CustomerEmail_TextBox.Parent = panels;
            CustomerEmail_TextBox.Size = textSize;
            CustomerEmail_TextBox.PlaceholderText = "Email";
            CustomerEmail_TextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CustomerEmail_TextBox.Location = new Point(defaultPadding * 2 + 200 + bookingID_TextBox.Size.Width, CustomerPhonenumber_TextBox.Location.Y + CustomerPhonenumber_TextBox.Size.Height);
            CustomerEmail_TextBox.Size = textSize;
            CustomerEmail_TextBox.ForeColor = Color.Black;

            // - Create Entry button -
            createEntry_button = new Button();
            createEntry_button.Text = "Save Changes!";
            createEntry_button.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            createEntry_button.BackColor = Color.FromArgb(64, 199, 73);
            createEntry_button.ForeColor = Color.White;
            createEntry_button.Location = new Point(panelSize.Width - createEntry_button.Size.Width - defaultPadding, defaultPadding);
            createEntry_button.Parent = panels;
            createEntry_button.Click += delegate (object sender, EventArgs e) { CreateEntry(sender, e); }; // delegate function to be run on click and pass i to later refer to witch button was pressed
            
            void CreateEntry(object sender, EventArgs e)
            {
                BookingInfo bookingInfo = new BookingInfo();
                CustomerInfo customerInfo = new CustomerInfo();
                Validator validator = new Validator();

                try
                {
                    customerInfo.customerID = int.Parse(customerID_TextBox.Text);
                    customerInfo.surname = CustomerSurname_TextBox.Text;
                    customerInfo.forename = CustomerForename_TextBox.Text;
                    customerInfo.phoneNumber = CustomerPhonenumber_TextBox.Text;
                    customerInfo.email = CustomerEmail_TextBox.Text;

                    bookingInfo.bookingID = int.Parse(bookingID_TextBox.Text);
                    bookingInfo.customerID = int.Parse(customerID_TextBox.Text);
                    bookingInfo.numberOfPeople = int.Parse(numberOfPeople_TextBox.Text);
                    bookingInfo.bookingDate = bookingDate_TextBox.Text;
                    bookingInfo.bookingTime = bookingTime_TextBox.Text;
                }catch
                {
                    MessageBox.Show("Error! please ensure that all information is corrent !");
                    return;
                }


                // validate string
                if (!validator.validateBooking(bookingInfo).IsError && !validator.validateCustomer(customerInfo).IsError)
                {
                    string finalString = cryptography.encryptStr(
                                        bookingInfo.bookingID.ToString() + "," +
                                        bookingInfo.customerID.ToString() + "," +
                                        bookingInfo.numberOfPeople + "," +
                                        bookingInfo.bookingDate + "," +
                                        bookingInfo.bookingTime
                                        );
                
                
                    using (StreamWriter sw = File.AppendText(settings.SundayBookingsFile))
                    {
                        sw.WriteLine(finalString);
                
                    }

                    finalString = cryptography.encryptStr(
                                        customerInfo.customerID.ToString() + "," +
                                        customerInfo.surname.ToString() + "," +
                                        customerInfo.forename + "," +
                                        customerInfo.phoneNumber + "," +
                                        customerInfo.email
                                        );


                    using (StreamWriter sw = File.AppendText(settings.CustomersFile))
                    {
                        sw.WriteLine(finalString);

                    }



                    MessageBox.Show("Created New Booking !");
                
                }
                else
                {
                    MessageBox.Show(validator.validateBooking(bookingInfo).Message);
                    MessageBox.Show(validator.validateCustomer(customerInfo).Message);
                }
            }
        }
        private BookingInfo[] GetBookingInfo()
        {

            Settings settings = new Settings();
            Cryptography cryptography = new Cryptography();
            // - get number of entrys in file -------------------------------------------------------------------------------------------------

            int NumberOfBookings = 0; // number of lines in file
            int NumberOfCustomers = 0; // number of lines in file

            using (StreamReader Sr = new StreamReader(settings.SundayBookingsFile)) // create new stream reader  
            {
                while (Sr.Peek() >= 0) // if not at end of file
                {
                    Sr.ReadLine(); //read line to advance file pointer 
                    NumberOfBookings++; // incriment number of lines 
                }
            }      
            // --------------------------------------------------------------------------------------------------------------------------------


            // - get of entrys from file and store in array -----------------------------------------------------------------------------------

            BookingInfo[] bookingInfo = new BookingInfo[NumberOfBookings];

            using (StreamReader Sr = new StreamReader(settings.SundayBookingsFile)) // create new stream reader
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
            // --------------------------------------------------------------------------------------------------------------------------------
            return bookingInfo;

        }
        private CustomerInfo[] GetCustomerInfo()
        {
            Settings settings = new Settings(); //create nenw instance of login settings
            Cryptography cryptography = new Cryptography();
            // --------------------------------------------------------------------------------------------------------------------------------


            // - get number of entrys in file -------------------------------------------------------------------------------------------------

            int NumberOfBookings = 0; // number of lines in file
            int NumberOfCustomers = 0; // number of lines in file

            using (StreamReader Sr = new StreamReader(settings.CustomersFile)) // create new stream reader  
            {
                while (Sr.Peek() >= 0) // if not at end of file
                {
                    Sr.ReadLine(); //read line to advance file pointer 
                    NumberOfCustomers++; // incriment number of lines 
                }
            }
            // --------------------------------------------------------------------------------------------------------------------------------


            // - get of entrys from file and store in array -----------------------------------------------------------------------------------

            CustomerInfo[] customerInfo = new CustomerInfo[NumberOfCustomers];

            using (StreamReader Sr2 = new StreamReader(settings.CustomersFile)) // create new stream reader
            {
                int i = 0;
                while (Sr2.Peek() >= 0) // if not at end of file
                {
                    customerInfo[i].RawData = cryptography.decryptStr(Sr2.ReadLine());            //read line from file and decrypt
                    string[] entry = customerInfo[i].RawData.Split(","); // split read line by ,
                    customerInfo[i].customerID = int.Parse(entry[0]); // parse first field "Customer ID"
                    customerInfo[i].surname = entry[1]; // parse second field "Surname"
                    customerInfo[i].forename = entry[2]; // parse third field "Forename"
                    customerInfo[i].phoneNumber = entry[3];// parse fourth field "PhoneNumber"
                    customerInfo[i].email = entry[4];// parse fith field "Email"
                    i++;
                }
            }

            return customerInfo;
        }
    }
}
