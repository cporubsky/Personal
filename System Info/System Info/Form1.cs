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
        FileFormat f = new FileFormat();
        
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
            string location = textBox2.Text;
            string user = textBox3.Text;

            uxOs.Text = osName + " Service Pack:" + osServicePack + " (" + osArch +"-bit)";
            uxMemory.Text = memory + " GB";    
            uxMachineName.Text = machineName; //get machine name
            uxProcessor.Text = processor + " (" + cpuBit +"-bit)";
            textBox1.Text = hardDrive;

            if (uxRadioButton1.Checked == true) ip = s.GetIP(1);     
            else ip = s.GetIP(2);

            uxIP.Text = ip;

            if (uxCheckBox1.Checked)
            {
                if (uxCheckBox2.Checked && !uxCheckBox3.Checked) //location checked
                {
                    try
                    { //location
                        using (StreamWriter stream = File.AppendText("SystemInfo.txt"))
                        {
                            f.AddToFile2(machineName, ip, location, osName, osArch, osServicePack, cpuBit, processor, memory, cDrive, stream);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }          
                }
                if (uxCheckBox3.Checked && !uxCheckBox2.Checked) //user checked
                {
                    try
                    {
                        using (StreamWriter stream = File.AppendText("SystemInfo.txt"))
                        {
                            f.AddToFile3(machineName, ip, user, osName, osArch, osServicePack, processor, cpuBit, memory, hardDrive, stream);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }     
                }
                else if (uxCheckBox2.Checked && uxCheckBox3.Checked) //location checked and user checked
                {
                    try
                    {
                        using (StreamWriter stream = File.AppendText("SystemInfo.txt"))
                        {
                            f.AddToFile4(machineName, ip, location, user, osName, osArch, osServicePack, cpuBit, processor, memory, cDrive, stream);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                }
                else //neither location, nor user checked
                {
                    try
                    {
                        using (StreamWriter stream = File.AppendText("SystemInfo.txt"))
                        {
                            f.AddToFile1(machineName, ip, osName, osArch, osServicePack, cpuBit, processor, memory, cDrive, stream);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                }        
            }    
        }   
    }
}
