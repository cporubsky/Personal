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
    public partial class Form1 : Form
    {
        private int val = 1073741824; //number of bytes in GB

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OsInfo();
            MemoryInfo();
            //get machine name
            uxMachineName.Text = System.Environment.MachineName;
            ProcessorInfo();
            HardDriveInfo();
            GetIP();
        }

        public void OsInfo()
        {
            string os = "SELECT * FROM Win32_OperatingSystem";
            ManagementObjectSearcher osSearch = new ManagementObjectSearcher(os);

            foreach (ManagementObject info in osSearch.Get())
            {
                //get os and service pack
                uxOs.Text = info.Properties["Caption"].Value.ToString().Trim() + " Service Pack: " + info.Properties["ServicePackMajorVersion"].Value.ToString();
            }
        }

        public void MemoryInfo()
        {
            ObjectQuery o = new ObjectQuery("SELECT * FROM Win32_PhysicalMemory");
            ManagementObjectSearcher memSearch = new ManagementObjectSearcher(o);
            foreach (ManagementObject info in memSearch.Get())
            {
                double size = Convert.ToDouble(info.Properties["Capacity"].Value);             
                uxMemory.Text = (size / val).ToString() + " GB";
            }
        }

        public void ProcessorInfo()
        {
            //get processor
            RegistryKey Rkey = Registry.LocalMachine;
            Rkey = Rkey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
            uxProcessor.Text = (string)Rkey.GetValue("ProcessorNameString");
        }

        public void HardDriveInfo()
        {
            StringBuilder st = new StringBuilder();
            foreach (System.IO.DriveInfo label in System.IO.DriveInfo.GetDrives())
            {
                if (label.IsReady)
                {
                    if (label.Name.Equals("X:\\") || label.Name.Equals("U:\\") || label.Name.Equals("W:\\") || label.Name.Equals("I:\\")) break;
                    st.Append(label.RootDirectory);
                    long volumeSize = label.TotalSize / val;
                    st.Append("  " + volumeSize.ToString() + " GB" + Environment.NewLine);
                }
            }
            textBox1.Text = st.ToString();
        }

        public void GetIP()
        {          
            StringBuilder sb = new StringBuilder();

            // Get a list of all network interfaces (usually one per network card, dialup, and VPN connection) 
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface network in networkInterfaces)
            {
                // Read the IP configuration for each network 
                IPInterfaceProperties properties = network.GetIPProperties();

                // Each network interface may have multiple IP addresses 
                foreach (IPAddressInformation address in properties.UnicastAddresses)
                {
                    // We're only interested in IPv4 addresses for now 
                    if (address.Address.AddressFamily != AddressFamily.InterNetwork) continue;
                       
                    // Ignore loopback addresses (e.g., 127.0.0.1) 
                    if (IPAddress.IsLoopback(address.Address)) continue;
                       
                    if (network.Name == "Local Area Connection") sb.AppendLine(address.Address.ToString() + " (" + network.Name + ")");
                    else break;               
                }
            }
            textBox2.Text = sb.ToString();
        }

    }
}
