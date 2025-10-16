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
    public partial class ChannelMappingScreen : UserControl
    {
        public ChannelMappingScreen()
        {
            InitializeComponent();
            DAQbtn_click();
        }

        private void DAQ_btn_Click(object sender, EventArgs e)
        {
            DAQbtn_click();
        }

        private void PLC_btn_Click(object sender, EventArgs e)
        {
            ChannelMapping_panel.Controls.Clear();

            PLCScreen PLC = new PLCScreen();

            ChannelMapping_panel.Controls.Add(PLC);

            ChannelMapping_panel.Visible = true;
        }

        private void DAQbtn_click()
        {
            ChannelMapping_panel.Controls.Clear();

            DaqScreen daq = new DaqScreen();

            ChannelMapping_panel.Controls.Add(daq);

            ChannelMapping_panel.Visible = true;
        }
    }
}
