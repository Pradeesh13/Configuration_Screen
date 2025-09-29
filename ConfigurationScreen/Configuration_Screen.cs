using ConfigurationScreen.UserControls.InstrumentConfiguration;
using ConfigurationScreen.UserControls.UserConfiguration;

namespace ConfigurationScreen
{
    public partial class Configuration_Screen : Form
    {
        public Configuration_Screen()
        {
            InitializeComponent();
        }

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

            UserConfiguration UserConfig_Panel = new UserConfiguration();

            Config_panel.Controls.Add(UserConfig_Panel);

            Config_panel.Visible = true;
        }
    }
}
