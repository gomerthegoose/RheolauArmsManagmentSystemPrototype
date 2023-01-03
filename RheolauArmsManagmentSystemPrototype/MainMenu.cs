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

    struct staffDetails
    {
        string
    }

    public partial class MainMenu : Form
    {
        static string staffFileLocation = "";

        public MainMenu()
        {
            InitializeComponent();

        }


        #region - Main menu  -

        private void StockMenuBtn_Click(object sender, EventArgs e)
        {
            navigationPanel.Hide();
            StockControls_panel.Show();
            StockControls_panel.BringToFront();
            View_panel.Location = new Point(StockControls_panel.Width, StockControls_panel.Location.Y);
        }

        private void StaffMenuBtn_Click(object sender, EventArgs e)
        {
            navigationPanel.Hide();
            StaffControls_panel.Show();
            StaffControls_panel.BringToFront();
            View_panel.Location = new Point(StaffControls_panel.Width, StaffControls_panel.Location.Y);
        }

        private void ThursdayBookingsBtn_Click(object sender, EventArgs e)
        {
            navigationPanel.Hide();
            ThursdayControls_panel.Show();
            ThursdayControls_panel.BringToFront();
            View_panel.Location = new Point(ThursdayControls_panel.Width , ThursdayControls_panel.Location.Y);
        }
        private void SundayBookingsBtn_Click(object sender, EventArgs e)
        {
            navigationPanel.Hide();
            SundayControlls_panel.Show();
            SundayControlls_panel.BringToFront();
            View_panel.Location = new Point(SundayControlls_panel.Width, SundayControlls_panel.Location.Y);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

        #region - Staff menu  -

        private void ViewStaff_button_Click(object sender, EventArgs e)
        {

        }

        private void StaffReturn_button_Click(object sender, EventArgs e)
        {
            navigationPanel.BringToFront();
            StaffControls_panel.Hide();
            navigationPanel.Show();
            View_panel.Location = new Point(navigationPanel.Width, navigationPanel.Location.Y); // reset location of view panel
        }

        #region View Staff 
        private void loadViewStaff()
        {
            LoginSettings settings = new LoginSettings(); //create nenw instance of login settings
            using (StreamReader Sr = new StreamReader(settings.staffDetailsFile)) // create new stream reader
            {
                UsrInfo[] usrInfo = new UsrInfo[NumLines]; // create new usr info variable
                int i = 0;
                while (Sr.Peek() >= 0) // if not at end of file
                {
                    usrInfo[i].RawData = cryptography.decryptStr(Sr.ReadLine());            //read line from file and decrypt
                    string[] usrDataSingleLine = usrInfo[i].RawData.Split(","); // split read line by ,
                    usrInfo[i].ID = int.Parse(usrDataSingleLine[0]); // parse first segment ID
                    usrInfo[i].Username = usrDataSingleLine[1]; // parse second segment Username
                    usrInfo[i].password = usrDataSingleLine[2]; // parse 3rd secmend password
                    usrInfo[i].accessLevel = int.Parse(usrDataSingleLine[3]); // parse 4th segment access level
                    i++;
                }
                return usrInfo; // return usr info
            }
        }

        private void ClearViewStaff()
        {

        }

        #endregion
        #endregion

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

    }
}
