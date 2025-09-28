using ConfigurationScreen.UserControls.InstrumentConfiguration;

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
    }
}
