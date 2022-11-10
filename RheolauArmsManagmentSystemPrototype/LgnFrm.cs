namespace RheolauArmsManagmentSystemPrototype
{
    public partial class LgnFrm : Form
    {
        public LgnFrm()
        {
            InitializeComponent();
        }
        private void LgnFrm_Resize(object sender, EventArgs e)
        {
            lgnPnl.Location = new Point(this.Size.Width/2 - (lgnPnl.Size.Width / 2), this.Size.Height/2 - (lgnPnl.Size.Height / 2));


        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            LoginHandle loginHandler = new LoginHandle(); //create new instance of loginHandle

            if (loginHandler.Login(UsernameTxt.Text, PasswordTxt.Text))
            {

            }
            else
            {
                MessageBox.Show("Failed To find Username Or Password", "Login Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}