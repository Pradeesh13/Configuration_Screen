using ConfigurationScreen.UserControls.LoginControl;

namespace ConfigurationScreen.LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Login_panel.Controls.Clear();

            MainLoginScreen MainScreen_Panel = new MainLoginScreen();

            Login_panel.Controls.Add(MainScreen_Panel);

            Login_panel.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login_panel.Controls.Clear();

            PasswordResetScreen PasswordResetScreen_Panel = new PasswordResetScreen();

            Login_panel.Controls.Add(PasswordResetScreen_Panel);

            Login_panel.Visible = true;
        }
    }
}
