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
        /// <summary>
        /// 
        /// </summary>
        SysInfo s = new SysInfo();
        
        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            string memory = s.memory1;
            string machineName = System.Environment.MachineName;
            string processor = s.processor1;
            string hardDrive = s.hardDrive1;
            string ip = string.Empty;
            string cpuBit = s.cpuBit1;
            string osName = s.osName1;
            string osArch = s.osArch1;
            string osServicePack = s.osServicePack1;
            string cDrive = s.Cdrive1;

            uxOs.Text = osName + " Service Pack:" + osServicePack + " (" + osArch +"-bit)";
            uxMemory.Text = memory + " GB";    
            uxMachineName.Text = machineName; //get machine name
            uxProcessor.Text = processor + " (" + cpuBit +"-bit)";
            textBox1.Text = hardDrive;

            if (uxRadioButton1.Checked == true) ip = s.GetIP(1);     
            else ip = s.GetIP(2);

            uxIP.Text = ip;

            if (uxCheckBox.Checked)
            {
                try
                {
                    using (StreamWriter stream = File.AppendText("SystemInfo.txt"))
                    {
                        AddToFile(machineName, ip, osName, osArch, osServicePack, cpuBit, processor, memory, cDrive, stream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }    
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="machineName"></param>
        /// <param name="ip"></param>
        /// <param name="osName"></param>
        /// <param name="osArch"></param>
        /// <param name="osServicePack"></param>
        /// <param name="cpuInfo"></param>
        /// <param name="cpuBit"></param>
        /// <param name="memory"></param>
        /// <param name="hardDrive"></param>
        /// <param name="w"></param>
        public static void AddToFile(string machineName,string ip ,string osName, string osArch, string osServicePack, string cpuInfo, string cpuBit, string memory, string hardDrive, TextWriter w)
        {
            w.Write("{0},{1},,,{2},{3},{4},{5},{6},{7},{8}", machineName, ip, osName, osArch, osServicePack, cpuInfo, cpuBit, memory, hardDrive);           
        }

    }
}
