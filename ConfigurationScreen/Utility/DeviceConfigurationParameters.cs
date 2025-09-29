using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationScreen.Utility
{
    public class DeviceConfigurationParameters
    {
        public string? DeviceName { get; set; }
        public string? DeviceMake { get; set; }
        public string? DeviceType { get; set; }
        public int PollTimeout { get; set; }
        public string? InterfaceType { get; set; }
        public string? VisaNetworkAddress { get; set; }
        public bool OpenFP { get; set; }
        public bool OnlyLaunch { get; set; }
        public bool CalibrationEnable { get; set; }
        public DateTime? CalibrationDate { get; set; }
        public DateTime? CalibrationExpiryDate { get; set; }
        public string? PortNumber { get; set; }
        public string? SubnetMask { get; set; }
        public string? BaudRate { get; set; }
        public string? Parity { get; set; }
        public string? Databits { get; set; }
        public string? StopBit { get; set; }
        public string? OCP { get; set; }
        public string? OVP { get; set; }
        public string? OPP { get; set; }
        public string? MaxC { get; set; }
        public string? MaxV { get; set; }
        public string? MaxP { get; set; }
        public string? TxID { get; set; }
        public string? RxID { get; set; }
        public string? Size { get; set; }
        public string? DLLFilePath { get; set; }

    }
}
