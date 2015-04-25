using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace System_Info
{
    public class FileFormat
    {

        //no user, no location
        public void AddToFile1(string machineName, string ip, string osName, string osArch, string osServicePack, string cpuInfo, string cpuBit, string memory, string hardDrive, TextWriter w)
        {
            w.Write("{0},{1},,,{2},{3},{4},{5},{6},{7},{8}", machineName, ip, osName, osArch, osServicePack, cpuInfo, cpuBit, memory, hardDrive);
        }

        //has location
        public void AddToFile2(string machineName, string ip, string location, string osName, string osArch, string osServicePack, string cpuInfo, string cpuBit, string memory, string hardDrive, TextWriter w)
        {
            w.Write("{0},{1},{2},,{3},{4},{5},{6},{7},{8},{9}", machineName, ip, location, osName, osArch, osServicePack, cpuInfo, cpuBit, memory, hardDrive);
        }

        //has user
        public void AddToFile3(string machineName, string ip, string User, string osName, string osArch, string osServicePack, string cpuInfo, string cpuBit, string memory, string hardDrive, TextWriter w)
        {
            w.Write("{0},{1},,{2},{3},{4},{5},{6},{7},{8},{9}", machineName, ip, User, osName, osArch, osServicePack, cpuInfo, cpuBit, memory, hardDrive);
        }

        //has both user, and location
        public void AddToFile4(string machineName, string ip, string location, string user, string osName, string osArch, string osServicePack, string cpuInfo, string cpuBit, string memory, string hardDrive, TextWriter w)
        {
            w.Write("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", machineName, ip, location, user, osName, osArch, osServicePack, cpuInfo, cpuBit, memory, hardDrive);
        }
    }
}
