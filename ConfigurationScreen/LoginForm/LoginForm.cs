namespace ConfigurationScreen.LoginForm
{
    public partial class LoginForm : Form
    {
        public static string? username;

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Password_txtbox.Focus();
            this.AcceptButton = Login_btn;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (User_txtbox.Text.ToUpper() == "ADMIN" && Password_txtbox.Text == "123")
            {
                username = User_txtbox.Text;
                Configuration_Screen ConfigurationScreen = new Configuration_Screen();
                ConfigurationScreen.FormClosed += (s, args) => Application.Exit();
                ConfigurationScreen.Show();
                this.Hide();
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
            Password_txtbox.Text = null;
            User_txtbox.Text = null;
        }
    }
}
