using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
using Microsoft.VisualBasic;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;

namespace System_Info
{
    public class System
    {
        public string OsInfo()
        {
            string os = "SELECT * FROM Win32_OperatingSystem";
            ManagementObjectSearcher osSearch = new ManagementObjectSearcher(os);
            string result = string.Empty;
            foreach (ManagementObject info in osSearch.Get())
            {
                //get os and service pack
                result = info.Properties["Caption"].Value.ToString().Trim() + " Service Pack: " + info.Properties["ServicePackMajorVersion"].Value.ToString();
            }
            return result;
        }



    }
}
