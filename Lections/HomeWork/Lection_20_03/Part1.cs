using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_20_03
{
    class Part1
    {
        public static void Run()
        {
            var path = @"D:\C#\ITCloud_Projects";

            var drive = DriveInfo.GetDrives();

            foreach (var item in drive)
            {
                Console.WriteLine($"Disk Name: {item.Name}, Type: {item.DriveType}, " +
                    $"TotalSize: {item.TotalSize/1024/1024/1024}GB, " +
                    $"FreeSpace: {item.AvailableFreeSpace}, VolumeLabel: {item.VolumeLabel}");
            }
            //DriveInfo driveInfo = new DriveInfo();
            Console.ReadKey();
        }
    }
}
