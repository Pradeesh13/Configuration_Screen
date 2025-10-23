using ConfigurationScreen.UserControls.ConfigurationFile;
using ConfigurationScreen.UserControls.FunctionalSequence;
using ConfigurationScreen.UserControls.InstrumentConfiguration;
using ConfigurationScreen.UserControls.IOChannelMapping;
using ConfigurationScreen.UserControls.UserConfiguration;
using System.Windows.Forms;

namespace ConfigurationScreen
{
    public partial class Configuration_Screen : Form
    {
        public Button[] Allbuttons;

        public Configuration_Screen()
        {
            InitializeComponent();
            Allbuttons = new Button[] { TestSequence_btn , InstrumentConfig_btn , UserConfig_btn , IOChannelMapping_btn ,
                CylinderSequence_btn , FunctionalSequence_btn , SaveAsConfiguration_btn, SaveConfiguration_btn, DeleteConfiguration_btn,
                SwitchUser_btn, RollBack_btn, ExtractZip_btn, NewConfiguration_btn, OpenConfiguration_btn };

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

        private void CylinderSequence_Click(object sender, EventArgs e)
        {
            Config_panel.Controls.Clear();

            CylinderSequenceScreen CylinderScreen = new CylinderSequenceScreen();

            Config_panel.Controls.Add(CylinderScreen);

            Config_panel.Visible = true;
        }

        private void FunctionalSequence_Click(object sender, EventArgs e)
        {
            Config_panel.Controls.Clear();

            FunctionalSequenceScreen FunctionalSequence = new FunctionalSequenceScreen();

            Config_panel.Controls.Add(FunctionalSequence);

            Config_panel.Visible = true;
        }

        #endregion

        public void init()
        {
            UserName_txtbox.Text = ConfigurationScreen.LoginForm.LoginForm.username?.ToUpper();

            Disable_buttons();

            OpenConfiguration_btn.Enabled = true;
            NewConfiguration_btn.Enabled = true;
            SwitchUser_btn.Enabled = true;
            ExtractZip_btn.Enabled = true;
        }

        public void Disable_buttons()
        {
            foreach (var button in Allbuttons)
            {
                button.Enabled = false;
            }
        }

        public void Enable_buttons()
        {
            foreach (var button in Allbuttons)
            {
                button.Enabled = true;
            }
        }

        private void NewConfiguration_btn_Click(object sender, EventArgs e)
        {
            NewFileConfigurationScreen NewFileConfiguration = new NewFileConfigurationScreen();

            var result = ShowPopup(NewFileConfiguration, "Important");

            if (result == DialogResult.OK)
            {
                ConfigurationFile_txtbox.Text = NewFileConfiguration.InputConfigFileName;
                Enable_buttons();
            }
        }

        private void OpenConfiguration_btn_Click(object sender, EventArgs e)
        {
            OpenFileConfigurationScreen OpenFileConfiguration = new OpenFileConfigurationScreen();

            ShowPopup(OpenFileConfiguration, "Important");
        }

        private DialogResult ShowPopup(UserControl userControl, string title = "Popup")
        {
            Form popupForm = new Form
            {
                Text = title,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MinimizeBox = false,
                MaximizeBox = false,
                ShowInTaskbar = false,
                Size = new Size(userControl.Width + 20, userControl.Height + 40)
            };

            userControl.Dock = DockStyle.Fill;
            popupForm.Controls.Add(userControl);

            if (userControl is NewFileConfigurationScreen configScreen)
            {
                configScreen.OnConfigSaved += (s, fileName) =>
                {
                    popupForm.DialogResult = DialogResult.OK;
                    popupForm.Close();
                };
            }

            return popupForm.ShowDialog();
        }
    }
}
