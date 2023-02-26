namespace RheolauArmsManagmentSystemPrototype
{

    public partial class MainMenu : Form
    {
        //------------------------------------------------------------------
        public MainMenu()
        {
            InitializeComponent();
        }
        private void RemoveControlls(Panel panel)
        {
            while (panel.Controls.Count > 0)
            {
                panel.Controls[0].Dispose(); // remove child if there is one remaining
            }
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            // display correct access level to user 
            switch (LgnFrm.CurrentUserInfo.accessLevel)
            {
                case 0:
                    AccessLevel_Label.Text = "Access Level: Admin";
                    break;
                case 1:
                    AccessLevel_Label.Text = "Access Level: Manager";
                    break;
                case 2:
                    AccessLevel_Label.Text = "Access Level: Staff";
                    break;
            }
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
            View_panel.Size = new Size(this.Width - StaffControls_panel.Size.Width - 15, StaffControls_panel.Size.Height);

        }
        private void ThursdayBookingsBtn_Click(object sender, EventArgs e)
        {
            navigationPanel.Hide();
            ThursdayControls_panel.Show();
            ThursdayControls_panel.BringToFront();
            View_panel.Location = new Point(ThursdayControls_panel.Width, ThursdayControls_panel.Location.Y);
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
            if (LgnFrm.CurrentUserInfo.accessLevel == 0)
            {
                navigationPanel.Hide();
                SettingsControls_panel.Show();
                SettingsControls_panel.BringToFront();
                View_panel.Location = new Point(SettingsControls_panel.Width, SettingsControls_panel.Location.Y);
                View_panel.Size = new Size(this.Width - SettingsControls_panel.Size.Width - 15, SettingsControls_panel.Size.Height);
            }
            else
            {
                MessageBox.Show("Please Contact Administrator To change Settings !");
            }

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
            StaffMenu staffMenu = new StaffMenu();
            staffMenu.ViewStaff(View_panel);
        }
        private void EditStaff_button_Click(object sender, EventArgs e)
        {
            if(LgnFrm.CurrentUserInfo.accessLevel < 2) // ensure only admin and manager can edit staff information
            {
                StaffMenu staffMenu = new StaffMenu();
                staffMenu.EditStaff(View_panel);
            }
            else
            {
                MessageBox.Show("Access Level Too Low !");
            }
        }
        private void createStaff_button_Click(object sender, EventArgs e)
        {
            if (LgnFrm.CurrentUserInfo.accessLevel < 2)// ensure only admin and manager can edit staff information
            {
                StaffMenu staffMenu = new StaffMenu();
                staffMenu.CreateStaff(View_panel);
            }
            else
            {
                MessageBox.Show("Access Level Too Low !");
            }
        }
        private void StaffSearch_Button_Click(object sender, EventArgs e)
        {
            StaffMenu staffMenu = new StaffMenu();
            staffMenu.SearchStaff(View_panel, StaffSearch_TextBox.Text);
        }

        private void StaffReturn_button_Click(object sender, EventArgs e)
        {
            navigationPanel.BringToFront(); // bring main nav panel to front 
            StaffControls_panel.Hide(); // hide current nav panel
            navigationPanel.Show(); // show main nav panel
            View_panel.Location = new Point(navigationPanel.Width, navigationPanel.Location.Y); // reset location of view panel

            // remove all children of view panel to clear old information
            RemoveControlls(View_panel);

        }

        #endregion
        //------------------------------------------------------------------
        #region - Stock -
        private void ViewStock_button_Click(object sender, EventArgs e)
        {
            stockMenu stockMenu = new stockMenu();
            stockMenu.ViewStock(View_panel);
        }
        private void StockEdit_Button_Click(object sender, EventArgs e)
        {
            stockMenu stockMenu = new stockMenu();
            stockMenu.EditStock(View_panel);
        }
        private void CreateStock_Button_Click(object sender, EventArgs e)
        {
            stockMenu stockMenu = new stockMenu();
            stockMenu.CreateStock(View_panel);
        }
        private void SearchStock_Button_Click(object sender, EventArgs e)
        {
            stockMenu stockMenu = new stockMenu();
            stockMenu.SearchStock(View_panel, StockSearch_textBox.Text);
        }

        private void StockReturn_button_Click(object sender, EventArgs e)
        {

            navigationPanel.BringToFront();
            StockControls_panel.Hide();
            navigationPanel.Show();
            View_panel.Location = new Point(navigationPanel.Width, navigationPanel.Location.Y); // reset location of view panel
            RemoveControlls(View_panel);
        }

        #endregion
        //------------------------------------------------------------------
        #region - Sunday Bookings -
        private void ViewSunBookings_button_Click(object sender, EventArgs e)
        {
            SundayBookingsMenu sundayBookingsMenu = new SundayBookingsMenu();// create new instance of sunday bookings
            sundayBookingsMenu.ViewBookings(View_panel);
        }
        private void EditBookings_Button_Click(object sender, EventArgs e)
        {
            SundayBookingsMenu sundayBookingsMenu = new SundayBookingsMenu();// create new instance of sunday bookings
            sundayBookingsMenu.EditBookings(View_panel);
        }
        private void CreateBookings_Button_Click(object sender, EventArgs e)
        {
            SundayBookingsMenu sundayBookingsMenu = new SundayBookingsMenu(); // create new instance of sunday bookings
            sundayBookingsMenu.CreateBooking(View_panel);
        }
        private void SundaySearch_Button_Click(object sender, EventArgs e)
        {
            SundayBookingsMenu sundayBookingsMenu = new SundayBookingsMenu();
            sundayBookingsMenu.SearchBooking(View_panel, SundaySearch_TextBox.Text);
        }
        private void SundayReturn_button_Click(object sender, EventArgs e)
        {
            navigationPanel.BringToFront();
            SundayControlls_panel.Hide();
            navigationPanel.Show();
            View_panel.Location = new Point(navigationPanel.Width, navigationPanel.Location.Y); // reset location of view panel
            RemoveControlls(View_panel);
        }
        #endregion
        //------------------------------------------------------------------
        #region - Thursday Bookings -
        private void ViewThuBookings_button_Click(object sender, EventArgs e)
        {
            ThursdayBookingsMenu thursdayBookingsMenu = new ThursdayBookingsMenu();
            thursdayBookingsMenu.ViewBookings(View_panel);
        }
        private void ThursdayEditBookings_button_Click(object sender, EventArgs e)
        {
            ThursdayBookingsMenu thursdayBookingsMenu = new ThursdayBookingsMenu();
            thursdayBookingsMenu.EditBookings(View_panel);
        }
        private void ThursdayCreateBookings_button_Click(object sender, EventArgs e)
        {
            ThursdayBookingsMenu thursdayBookingsMenu = new ThursdayBookingsMenu();
            thursdayBookingsMenu.CreateBooking(View_panel);
        }
        private void ThursdaySearch_Button_Click(object sender, EventArgs e)
        {
            ThursdayBookingsMenu thursdayBookingsMenu = new ThursdayBookingsMenu();
            thursdayBookingsMenu.SearchBooking(View_panel, ThursdaySearch_TextBox.Text);
        }
        private void ThursdayReturn_button_Click(object sender, EventArgs e)
        {
            RemoveControlls(View_panel);
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
        private void SearchTest_Button_Click(object sender, EventArgs e)
        {
            // test of search algorythm

            Search searcher = new Search(); // instanciate nmew searcher
            int[] SearchArray = { 2, 2, 3, 4, 8, 9, 10, 35, 40, 100, 200 }; // array to search through, must be in order 
            int Quiery = 10; // what we are looking for

            int result = searcher.binarySearch(SearchArray, 0, SearchArray.Length - 1, Quiery); // call search function

            if (result == -1) // -1 represents result not found
                MessageBox.Show("Element not present");
            else
                MessageBox.Show("Element found at index " + result);
        }

        private void SettingsReturn_Button_Click(object sender, EventArgs e)
        {
            navigationPanel.BringToFront(); // bring main nav panel to front 
            SettingsControls_panel.Hide(); // hide current nav panel
            navigationPanel.Show(); // show main nav panel
            View_panel.Location = new Point(navigationPanel.Width, navigationPanel.Location.Y); // reset location of view panel
            RemoveControlls(View_panel);
        }

        #endregion
        //------------------------------------------------------------------
    }
}
