using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigurationScreen.UserControls.ConfigurationFile
{
    public partial class NewFileConfigurationScreen : UserControl
    {
        public string? InputConfigFileName;

        public event EventHandler<string>? OnConfigSaved;

        public NewFileConfigurationScreen()
        {
            InitializeComponent();
        }


        private void Ok_btn_Click(object sender, EventArgs e)
        {
            if (InputText_txtbox.Text != "")
            {
                InputConfigFileName = InputText_txtbox.Text;

                OnConfigSaved?.Invoke(this, InputConfigFileName);
            }
            else
            {
                MessageBox.Show("Please enter a file name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
