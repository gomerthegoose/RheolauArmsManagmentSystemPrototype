﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            StaffMenu staffMenu = new StaffMenu();
            staffMenu.ViewStaff(View_panel);
        }
        private void EditStaff_button_Click(object sender, EventArgs e)
        {
            // remove all children of view panel to clear old information
            while (View_panel.Controls.Count > 0)
            {
                View_panel.Controls[0].Dispose();
            }
            StaffMenu staffMenu = new StaffMenu();
            staffMenu.EditStaff(View_panel);
        }
        private void createStaff_button_Click(object sender, EventArgs e)
        {
            // remove all children of view panel to clear old information
            while (View_panel.Controls.Count > 0)
            {
                View_panel.Controls[0].Dispose();
            }
            StaffMenu staffMenu = new StaffMenu();
            staffMenu.CreateStaff(View_panel); ;
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
 