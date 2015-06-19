using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;

namespace RecorderFileFolderDialog
{
    public class WMIhelper
    {
        public static DriveInfo[] GetDrives()
        {
            return DriveInfo.GetDrives();
        }


        public void Test()
        {
            var scope = new ManagementScope("\\\\RONW403644\\root\\CIMV2");
            var query = new ObjectQuery("SELECT * FROM Win32_DiskDrive");

            var searcher = new ManagementObjectSearcher(scope, query);


            ManagementObjectCollection allDrives = searcher.Get();

            foreach (var allDrive in allDrives)
            {
                Console.WriteLine(allDrive.ClassPath.ToString());
            }
        }

    }
}
