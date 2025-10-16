using ConfigurationScreen.UserControls.InstrumentConfiguration;
using ConfigurationScreen.UserControls.IOChannelMapping;
using ConfigurationScreen.UserControls.UserConfiguration;

namespace ConfigurationScreen
{
    public partial class Configuration_Screen : Form
    {
        public Configuration_Screen()
        {
            InitializeComponent();
            init();
        }

        #region Form Events
        private void InstrumentConfig_btn_Click(object sender, EventArgs e)
        {
            Config_panel.Controls.Clear();

            InstrumentConfigurationScreen InstrumentConfig_Panel = new InstrumentConfigurationScreen();

            Config_panel.Controls.Add(InstrumentConfig_Panel);

            Config_panel.Visible = true;
        }

        private void Configuration_Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(
            "Are you sure you want to exit?",
            "Confirm Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void UserConfig_btn_Click(object sender, EventArgs e)
        {
            Config_panel.Controls.Clear();

            UserConfigurationScreen UserConfig_Panel = new UserConfigurationScreen();

            Config_panel.Controls.Add(UserConfig_Panel);

            Config_panel.Visible = true;
        }

        private void IOChannelMapping_btn_Click(object sender, EventArgs e)
        {
            Config_panel.Controls.Clear();

            IOChannelMappingScreen IOChannelMapping = new IOChannelMappingScreen();

            Config_panel.Controls.Add(IOChannelMapping);

            Config_panel.Visible = true;
        }
        #endregion

        public void init()
        {
            UserName_txtbox.Text = ConfigurationScreen.LoginForm.LoginForm.username?.ToUpper();
        }
    }
}
