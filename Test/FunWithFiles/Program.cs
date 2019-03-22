using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            bool result;
            var baseFolderPath = FindMainFolder(out result);
            if (result) new FolderExplorer(baseFolderPath).Run();
            else Console.WriteLine("Sorry, user folder was not found");
            


            while (true)
            {

                Console.ReadKey();
                
            }
        }

        private static void WorkWithBaseDirectory(string baseFolder)
        {
            Console.WriteLine(baseFolder);
            DirectoryInfo directoryInfo = new DirectoryInfo(baseFolder);
            FileInfo fileInfo = new FileInfo(baseFolder);

            var directories = directoryInfo.GetDirectories();
            var files = directoryInfo.GetFiles();


            Console.WriteLine("\n\nFiles:");
            foreach (var file in files)
            {
                Console.WriteLine("\t-" + file.Name);
            }
            Console.WriteLine("\n\nDirectories:");
            foreach (var dir in directories)
            {
                Console.WriteLine("\t" + dir.Name);
            }


        }

        private static string FindMainFolder(out bool folderWasFound)
        {
            string userName = Environment.UserName;
            string[] drives = Directory.GetLogicalDrives();

            foreach (var drive in drives)
            {
                var path = drive + "users\\" + userName;
                if (Directory.Exists(path))
                {
                    folderWasFound = true;
                    return path;
                }
            }

            folderWasFound = true;
            return "";
        }
    }
}
