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




    public partial class MainMenu : Form
    {
        SundayBookings sundayBookings;

        public MainMenu()
        {
            InitializeComponent();
            sundayBookings = new SundayBookings(ActionsPanel,navigationPanel);
        }

        private void SundayBookingsBtn_Click(object sender, EventArgs e)
        {
            ShowNavBtns(false);
            sundayBookings.DrawActions();
            sundayBookings.DrawNavBar();
        }

        private void ThursdayBookingsBtn_Click(object sender, EventArgs e)
        {
            sundayBookings.hideMenu();
        }


        public void ShowNavBtns(bool show) //true = show btns false = hide
        {
            if (show)
            {
                SundayBookingsBtn.Show();
                ThursdayBookingsBtn.Show();
                StaffMenuBtn.Show();
                StockMenuBtn.Show();
                ExitBtn.Show();
            }
            else
            {
                SundayBookingsBtn.Hide();
                ThursdayBookingsBtn.Hide();
                StaffMenuBtn.Hide();
                StockMenuBtn.Hide();
                ExitBtn.Hide();
            }
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
