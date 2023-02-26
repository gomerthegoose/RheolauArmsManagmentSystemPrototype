using System.Security.Cryptography.X509Certificates;

namespace RheolauArmsManagmentSystemPrototype
{
    public partial class LgnFrm : Form
    {
        public static UserInfo CurrentUserInfo;

        public LgnFrm()
        {
            InitializeComponent();
        }
        private void LgnFrm_Resize(object sender, EventArgs e)
        {
            lgnPnl.Location = new Point(this.Size.Width / 2 - (lgnPnl.Size.Width / 2), this.Size.Height / 2 - (lgnPnl.Size.Height / 2)); // place the panel within the center of the login window
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            LoginHandle loginHandler = new LoginHandle(); //create new instance of loginHandle

            if (loginHandler.Login(UsernameTxt.Text, PasswordTxt.Text)) // check for user details against data base return ture if user found
            {
                CurrentUserInfo = loginHandler.getCurrentUser(UsernameTxt.Text, PasswordTxt.Text); // gather the current logedin users information to use for access level
                MainMenu mainMenu = new MainMenu();
                this.Hide(); // hide login window
                mainMenu.Show(); // show main menu
            }
            else
            {
                MessageBox.Show("Failed To find Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // display error if user or password not found
            }
        }
    }
}