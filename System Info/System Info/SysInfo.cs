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
    public class SysInfo
    {
        private int val = 1073741824; //number of bytes in GB

        public string OsInfo()
        {
            string os = "SELECT * FROM Win32_OperatingSystem";
            ManagementObjectSearcher osSearch = new ManagementObjectSearcher(os);
            string result = string.Empty;

            foreach (ManagementObject info in osSearch.Get())
            {
                //get os and service pack
                result = info.Properties["Caption"].Value.ToString().Trim() + " (" + info.Properties["OSArchitecture"].Value.ToString() +")" + " Service Pack: " + info.Properties["ServicePackMajorVersion"].Value.ToString();
            }
            return result;
        }

        public string MemoryInfo()
        {
            ObjectQuery o = new ObjectQuery("SELECT * FROM Win32_PhysicalMemory");
            ManagementObjectSearcher memSearch = new ManagementObjectSearcher(o);
            string result = string.Empty;
            foreach (ManagementObject info in memSearch.Get())
            {
                double size = Convert.ToDouble(info.Properties["Capacity"].Value);
               result = (size / val).ToString() + " GB";
            }
            return result;
        }

        public string ProcessorInfo()
        {          
            RegistryKey Rkey = Registry.LocalMachine;
            Rkey = Rkey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
            string processor = (string)Rkey.GetValue("ProcessorNameString");
            string bit = string.Empty;
             if (!Environment.Is64BitOperatingSystem) bit = "(32-bit)";
            else bit = "(64-bit)";

             return processor + " " + bit;
        }

        public string HardDriveInfo()
        {
            StringBuilder st = new StringBuilder();
            foreach (System.IO.DriveInfo label in System.IO.DriveInfo.GetDrives())
            {
                if (label.IsReady)
                {
                    if (label.Name.CompareTo("E:\\") == 1) break;
                    st.Append(label.RootDirectory);
                    long volumeSize = label.TotalSize / val;
                    st.Append("  " + volumeSize.ToString() + " GB" + Environment.NewLine);
                }
            }
            return st.ToString();
        }

        public string GetIP(int num)
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

                    if (network.Name == "Local Area Connection")
                    {
                        //rework split -> adm 161.xx or 161.xxx && sfa 64.xxx
                        string str = address.Address.ToString();
                        string[] arr = str.Split('.');
                        string str2 = String.Join(string.Empty, arr).Trim();
                        int length = str2.Length;
                        string sub = str2.Substring(9);
                        switch (num)
                        {
                            case 1: //adm range 64 - 95 and 160 - 191
                                if (sub.CompareTo("64") == 1 && sub.CompareTo("95") == -1) sb.Append(address.Address.ToString() + " (" + network.Name + ")");
                                else if (sub.CompareTo("160") == 1 && sub.CompareTo("191") == -1) sb.Append(address.Address.ToString() + " (" + network.Name + ")");
                                else sb.Append("DHCP");
                                break;
                            case 2: //sfa range 
                                if (sub.CompareTo("112") == 1 && sub.CompareTo("188") == -1) sb.AppendLine(address.Address.ToString() + " (" + network.Name + ")");
                                else sb.Append("DHCP");
                                break;
                            default:
                                break;
                        }
                        
                    }
                    else break;
                }
            }
            return sb.ToString();
        }
    }
}
