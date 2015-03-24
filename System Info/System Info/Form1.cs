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
        SysInfo s = new SysInfo();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uxOs.Text = s.OsInfo();
            uxMemory.Text = s.MemoryInfo();           
            uxMachineName.Text = System.Environment.MachineName; //get machine name
            uxProcessor.Text = s.ProcessorInfo();
            textBox1.Text = s.HardDriveInfo();
            if (uxRadioButton1.Checked == true)
            {
                uxIP.Text = s.GetIP(1);
            }
            else uxIP.Text = s.GetIP(2);
            


            /*if (!Environment.Is64BitOperatingSystem) uxIP.Text = "32 Bit";
            else uxIP.Text = "64 Bit";*/

            
        }

    }
}
