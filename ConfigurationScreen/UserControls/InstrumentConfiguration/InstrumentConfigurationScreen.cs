using ConfigurationScreen.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigurationScreen.UserControls.InstrumentConfiguration
{
    public partial class InstrumentConfigurationScreen : UserControl
    {
        public TextBox[] PSUControls;
        public TextBox[] CANControls;
        public TextBox[] DAQControls;
        public TextBox[] ParameterControls;

        private List<DeviceConfigurationParameters> devices = new List<DeviceConfigurationParameters>();


        public InstrumentConfigurationScreen()
        {
            InitializeComponent();

            PSUControls = new TextBox[] { OCP_txtbox, OVP_txtbox, OPP_txtbox, MaxC_txtbox, MaxV_txtbox, MaxP_txtbox };
            CANControls = new TextBox[] { TxID_txtbox, RxID_txtbox, Size_txtbox, DLLFilepath_txtbox };
            DAQControls = new TextBox[] { DLLFilepath_txtbox };

            ParameterControls = new TextBox[] { PortNumber_txtbox, SubnetMask_txtbox,BaudRate_txtbox,Parity_txtbox,DataBits_txtbox,StopBits_txtbox,OCP_txtbox,OVP_txtbox,OPP_txtbox,
                                          MaxC_txtbox,MaxV_txtbox,MaxP_txtbox,TxID_txtbox,RxID_txtbox,Size_txtbox,DLLFilepath_txtbox };


            DisableControls();
            DisablePanel();
        }


        #region EventForms
        private void DeviceType_cmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeviceType_cmbbox.SelectedItem != null && DeviceType_cmbbox.SelectedItem.ToString() == "PSU")
            {
                DisableControls();
                EnableControls(PSUControls);
            }

            else if (DeviceType_cmbbox.SelectedItem != null && DeviceType_cmbbox.SelectedItem.ToString() == "CAN")
            {
                DisableControls();
                EnableControls(CANControls);
            }

            else if (DeviceType_cmbbox.SelectedItem != null && (DeviceType_cmbbox.SelectedItem.ToString() == "DAQ" || DeviceType_cmbbox.SelectedItem.ToString() == "DMM"))
            {
                DisableControls();
                EnableControls(DAQControls);
            }
        }

        private void NewFile_picbox(object sender, EventArgs e)
        {
            DeviceControls_panel.Enabled = true;
            ClearControlInputs();
        }

        private void AddFile_picbox(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DeviceName_txtbox.Text))
            {
                MessageBox.Show("Please enter the device name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AddDevices();
            }
        }

        private void RemoveFile_picbox(object sender, EventArgs e)
        {
            if (DeviceList_grid.SelectedRows.Count == 1)
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected device?", "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = DeviceList_grid.SelectedRows[0].Index;
                    devices.RemoveAt(rowIndex);
                    DeviceList_grid.Rows.RemoveAt(rowIndex);

                    ClearControlInputs();
                }
            }
            else if (DeviceList_grid.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only one device at a time.", "Multiple Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please select a device to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateDevice_picbox_Click(object sender, EventArgs e)
        {
            if (DeviceList_grid.SelectedRows.Count == 1)
            {
                int rowIndex = DeviceList_grid.SelectedRows[0].Index;
                if (rowIndex < 0 || rowIndex >= devices.Count)
                    return;

                DeviceConfigurationParameters device = devices[rowIndex];

                device.DeviceName = DeviceName_txtbox.Text;
                device.DeviceMake = DeviceMake_cmbbox.SelectedItem?.ToString();
                device.DeviceType = DeviceType_cmbbox.SelectedItem?.ToString();
                device.PollTimeout = (int)PollTimeout_numbox.Value;
                device.InterfaceType = InterfaceType_cmbbox.SelectedItem?.ToString();
                device.VisaNetworkAddress = Visa_txtbox.Text;
                device.OpenFP = OnlyFP_chkbox.Checked;
                device.OnlyLaunch = OnlyLaunch_chkbox.Checked;
                device.PortNumber = PortNumber_txtbox.Text;
                device.SubnetMask = SubnetMask_txtbox.Text;
                device.BaudRate = BaudRate_txtbox.Text;
                device.Parity = Parity_txtbox.Text;
                device.Databits = DataBits_txtbox.Text;
                device.StopBit = StopBits_txtbox.Text;
                device.OCP = OCP_txtbox.Text;
                device.OVP = OVP_txtbox.Text;
                device.OPP = OPP_txtbox.Text;
                device.MaxC = MaxC_txtbox.Text;
                device.MaxV = MaxV_txtbox.Text;
                device.MaxP = MaxP_txtbox.Text;
                device.TxID = TxID_txtbox.Text;
                device.RxID = RxID_txtbox.Text;
                device.Size = Size_txtbox.Text;
                device.DLLFilePath = DLLFilepath_txtbox.Text;
                device.CalibrationDate = CalibrationDate_box.Value;
                device.CalibrationExpiryDate = CalibrationDateExpiry_box.Value;
                device.CalibrationEnable = CalibrationEnable_chkbox.Checked;

                DeviceList_grid.Rows[rowIndex].Cells[0].Value = device.DeviceName;
            }
            else
            {
                MessageBox.Show("Please select one device to update.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeviceList_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DeviceConfigurationParameters selectedDevice = devices[e.RowIndex];

                DeviceName_txtbox.Text = selectedDevice.DeviceName;
                DeviceType_cmbbox.SelectedItem = selectedDevice.DeviceType;
                DeviceMake_cmbbox.SelectedItem = selectedDevice.DeviceMake;
                PollTimeout_numbox.Value = selectedDevice.PollTimeout;
                InterfaceType_cmbbox.SelectedItem = selectedDevice.InterfaceType;
                Visa_txtbox.Text = selectedDevice.VisaNetworkAddress;
                OnlyFP_chkbox.Checked = selectedDevice.OpenFP;
                OnlyLaunch_chkbox.Checked = selectedDevice.OnlyLaunch;
                PortNumber_txtbox.Text = selectedDevice.PortNumber;
                SubnetMask_txtbox.Text = selectedDevice.SubnetMask;
                BaudRate_txtbox.Text = selectedDevice.BaudRate;
                Parity_txtbox.Text = selectedDevice.Parity;
                DataBits_txtbox.Text = selectedDevice.Databits;
                StopBits_txtbox.Text = selectedDevice.StopBit;
                OCP_txtbox.Text = selectedDevice.OCP;
                OVP_txtbox.Text = selectedDevice.OVP;
                OPP_txtbox.Text = selectedDevice.OPP;
                MaxC_txtbox.Text = selectedDevice.MaxC;
                MaxV_txtbox.Text = selectedDevice.MaxV;
                MaxP_txtbox.Text = selectedDevice.MaxP;
                TxID_txtbox.Text = selectedDevice.TxID;
                RxID_txtbox.Text = selectedDevice.RxID;
                Size_txtbox.Text = selectedDevice.Size;
                DLLFilepath_txtbox.Text = selectedDevice.DLLFilePath;
                CalibrationDate_box.Value = selectedDevice.CalibrationDate ?? DateTime.Today;
                CalibrationDateExpiry_box.Value = selectedDevice.CalibrationDate ?? DateTime.Today;
                CalibrationEnable_chkbox.Checked = selectedDevice.CalibrationEnable;

                DeviceControls_panel.Enabled = true;
            }
        }
        #endregion


        #region User methods
        private void EnableControls(TextBox[] controls)
        {
            foreach (var control in controls)
            {
                control.Enabled = true;
            }
        }

        private void DisableControls()
        {
            foreach (var control in ParameterControls)
            {
                control.Enabled = false;
            }
        }

        private void DisablePanel()
        {
            DeviceControls_panel.Enabled = false;
        }

        private void AddDevices()
        {
            DeviceConfigurationParameters device = new DeviceConfigurationParameters
            {
                DeviceName = DeviceName_txtbox.Text,
                DeviceMake = DeviceMake_cmbbox.SelectedItem?.ToString(),
                DeviceType = DeviceType_cmbbox.SelectedItem?.ToString(),
                PollTimeout = (int)PollTimeout_numbox.Value,
                InterfaceType = InterfaceType_cmbbox.SelectedItem?.ToString(),
                VisaNetworkAddress = Visa_txtbox.Text,
                OpenFP = OnlyFP_chkbox.Checked,
                OnlyLaunch = OnlyLaunch_chkbox.Checked,
                PortNumber = PortNumber_txtbox.Text,
                SubnetMask = SubnetMask_txtbox.Text,
                BaudRate = BaudRate_txtbox.Text,
                Parity = Parity_txtbox.Text,
                Databits = DataBits_txtbox.Text,
                StopBit = StopBits_txtbox.Text,
                OCP = OCP_txtbox.Text,
                OVP = OVP_txtbox.Text,
                OPP = OPP_txtbox.Text,
                MaxC = MaxC_txtbox.Text,
                MaxV = MaxV_txtbox.Text,
                MaxP = MaxP_txtbox.Text,
                TxID = TxID_txtbox.Text,
                RxID = RxID_txtbox.Text,
                Size = Size_txtbox.Text,
                DLLFilePath = DLLFilepath_txtbox.Text,
                CalibrationDate = CalibrationDate_box.Value,
                CalibrationExpiryDate = CalibrationDateExpiry_box.Value,
                CalibrationEnable = CalibrationEnable_chkbox.Checked,
            };
            devices.Add(device);

            DeviceList_grid.Rows.Add(device.DeviceName);                                       // Update UI list with new device name

            ClearControlInputs();

            DisablePanel();

            DisableControls();
        }

        private void ClearControlInputs()
        {
            DeviceName_txtbox.Text = "";
            DeviceType_cmbbox.SelectedIndex = -1;
            DeviceMake_cmbbox.SelectedIndex = -1;
            PollTimeout_numbox.Value = 0;
            InterfaceType_cmbbox.SelectedIndex = -1;
            Visa_txtbox.Text = " ";
            OnlyFP_chkbox.Checked = false;
            OnlyLaunch_chkbox.Checked = false;
            PortNumber_txtbox.Text = " ";
            SubnetMask_txtbox.Text = " ";
            BaudRate_txtbox.Text = " ";
            Parity_txtbox.Text = " ";
            DataBits_txtbox.Text = " ";
            StopBits_txtbox.Text = " ";
            OCP_txtbox.Text = " ";
            OVP_txtbox.Text = " ";
            OPP_txtbox.Text = " ";
            MaxC_txtbox.Text = " ";
            MaxV_txtbox.Text = " ";
            MaxP_txtbox.Text = " ";
            TxID_txtbox.Text = " ";
            RxID_txtbox.Text = " ";
            Size_txtbox.Text = " ";
            DLLFilepath_txtbox.Text = " ";
            CalibrationDate_box.Value = DateTime.Today;
            CalibrationDateExpiry_box.Value = DateTime.Today;
            CalibrationEnable_chkbox.Checked = false;
        }

        #endregion
    }
        
}
