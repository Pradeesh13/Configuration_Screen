using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfigurationScreen.UserControls.IOChannelMapping;

namespace ConfigurationScreen.UserControls.IOChannelMapping
{
    public partial class IOChannelMappingScreen : UserControl
    {
        public IOChannelMappingScreen()
        {
            InitializeComponent();
            ChannelMappingBtn_click();
        }


        private void ChannelMapping_btn_Click(object sender, EventArgs e)
        {
            ChannelMappingBtn_click();
        }

        private void ChannelMappingBtn_click()
        {
            IOChannel_panel.Controls.Clear();

            ChannelMappingScreen ChannelMapping = new ChannelMappingScreen();

            IOChannel_panel.Controls.Add(ChannelMapping);

            IOChannel_panel.Visible = true;
        }

        private void IOMapping_btn_Click(object sender, EventArgs e)
        {
            IOChannel_panel.Controls.Clear();

            IOMappingScreen IOMapping = new IOMappingScreen();

            IOChannel_panel.Controls.Add(IOMapping);

            IOChannel_panel.Visible = true;
        }
    }
}
