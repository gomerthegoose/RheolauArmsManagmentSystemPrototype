using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace RheolauArmsManagmentSystemPrototype
{
    internal class SundayBookings : Form
    {


        private Label SundayBookingsLbl;
        private Button BackButton;
        //private MainMenu mainMenu = new MainMenu();

        public SundayBookings(Panel ActionsPnl, Panel NavBarPnl)
        {

            // - lbl -
            this.SundayBookingsLbl = new System.Windows.Forms.Label();
            SundayBookingsLbl.Parent = ActionsPnl;
            SundayBookingsLbl.Location = new Point(10, 10);
            SundayBookingsLbl.Size = new System.Drawing.Size(250, 32);
            SundayBookingsLbl.Text = " - Sunday Bookings - ";
            SundayBookingsLbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            SundayBookingsLbl.ForeColor = Color.White;
            SundayBookingsLbl.Hide();

            // - exit btn -
            this.BackButton = new System.Windows.Forms.Button();
            BackButton.Parent = NavBarPnl;
            this.BackButton.BackColor = System.Drawing.Color.Maroon;
            this.BackButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(3, 416);
            this.BackButton.Size = new System.Drawing.Size(171, 29);
            this.BackButton.Text = "Back";
            this.BackButton.Click += new EventHandler(returnToMain);
            BackButton.Hide();
            

        }

        public void DrawActions()
        {
            SundayBookingsLbl.Show();


        }

        public void DrawNavBar()
        {
            BackButton.Show();
        }

        public void hideMenu()
        {
            SundayBookingsLbl.Hide();
            BackButton.Hide();
        }

        private void returnToMain(object sender, EventArgs e)
        {
            hideMenu();
            //mainMenu.ShowNavBtns(true);

        }
    }
}
