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
        /// <summary>
        /// 
        /// </summary>
        private static int val = 1073741824; //number of bytes in GB

        /// <summary>
        /// 
        /// </summary>
        public string osName1 { get { return OsName(); } }
        
        /// <summary>
        /// 
        /// </summary>
        public string osArch1 { get { return OsArch(); } }
        
        /// <summary>
        /// 
        /// </summary>
        public string osServicePack1 { get { return osServicePack(); } }
        
        /// <summary>
        /// 
        /// </summary>
        public string memory1 { get { return MemoryInfo(); } }
        
        /// <summary>
        /// 
        /// </summary>
        public string processor1 { get { return ProcessorInfo(); } }

        /// <summary>
        /// 
        /// </summary>
        public string cpuBit1 { get { return CpuBit(); } }

        /// <summary>
        /// 
        /// </summary>
        public string hardDrive1 { get { return HardDriveInfo(); } } 

        /// <summary>
        /// 
        /// </summary>
        public string Cdrive1 { get { return Cdrive(); } } 

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string OsName()
        {
            string os = "SELECT * FROM Win32_OperatingSystem";
            ManagementObjectSearcher osSearch = new ManagementObjectSearcher(os);
            string result = string.Empty;

            foreach (ManagementObject info in osSearch.Get())
            {
                //get os
                result = info.Properties["Caption"].Value.ToString().Trim();
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string OsArch()
        {
            string os = "SELECT * FROM Win32_OperatingSystem";
            ManagementObjectSearcher osSearch = new ManagementObjectSearcher(os);
            string result = string.Empty;

            foreach (ManagementObject info in osSearch.Get())
            {
                //get if x86 or x64
                result = info.Properties["OSArchitecture"].Value.ToString();
                if (result.CompareTo("64-bit") == 0) result = "64";
                else result = "32";
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string osServicePack()
        {
            string os = "SELECT * FROM Win32_OperatingSystem";
            ManagementObjectSearcher osSearch = new ManagementObjectSearcher(os);
            string result = string.Empty;

            foreach (ManagementObject info in osSearch.Get())
            {
                //get service pack
                result = info.Properties["ServicePackMajorVersion"].Value.ToString();
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string MemoryInfo()
        {
            ObjectQuery o = new ObjectQuery("SELECT * FROM Win32_PhysicalMemory");
            ManagementObjectSearcher memSearch = new ManagementObjectSearcher(o);
            string result = string.Empty;
            foreach (ManagementObject info in memSearch.Get())
            {
               double size = Convert.ToDouble(info.Properties["Capacity"].Value);
               result = (size / val).ToString();
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string ProcessorInfo()
        {          
            RegistryKey Rkey = Registry.LocalMachine;
            Rkey = Rkey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
            string processor = (string)Rkey.GetValue("ProcessorNameString");
            string bit = string.Empty;
            //if (!Environment.Is64BitOperatingSystem) bit = "(32-bit)";
            //else bit = "(64-bit)";
            //return processor + " " + bit;
            return processor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string CpuBit()
        {
            string bit = string.Empty;
            if (!Environment.Is64BitOperatingSystem) return bit = "32";
            else return bit = "64";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string HardDriveInfo()
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string Cdrive()
        {
            string result = "";
            foreach (System.IO.DriveInfo label in System.IO.DriveInfo.GetDrives())
            {
                if (label.IsReady)
                {
                    if (label.Name.CompareTo("C:\\") == 0)
                    {                
                        long volumeSize = label.TotalSize / val;
                        result = volumeSize.ToString();
                        break;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
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

                    //network.Name is "Local Area Connection"
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
                                if (sub.CompareTo("63") == 1 && sub.CompareTo("96") == -1) sb.Append(address.Address.ToString());
                                else if (sub.CompareTo("159") == 1 && sub.CompareTo("192") == -1) sb.Append(address.Address.ToString());
                                else sb.Append("DHCP");
                                break;
                            case 2: //sfa range  112 - 188
                                if (sub.CompareTo("111") == 1 && sub.CompareTo("189") == -1) sb.AppendLine(address.Address.ToString());
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
