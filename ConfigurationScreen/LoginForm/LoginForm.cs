namespace ConfigurationScreen.LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = Login_btn;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (UserName_txtbox.Text.ToUpper() == "ADMIN" && Password_txtbox.Text == "123")
            {
                Configuration_Screen ConfigurationScreen = new Configuration_Screen();
                ConfigurationScreen.FormClosed += (s, args) => Application.Exit();
                ConfigurationScreen.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            UserName_txtbox.Text = null;
            Password_txtbox.Text = null;
        }
    }
}
