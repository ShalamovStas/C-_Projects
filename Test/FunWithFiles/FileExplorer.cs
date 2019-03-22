using System;
using System.IO;

namespace FunWithFiles
{
    enum Type
    {
        File,
        Folder
    }

    class FolderExplorer
    {
        private readonly string startDirectoryPath;
        private readonly Printer printer;

        private readonly DirectoryInfo startDirectoryInfo;
        private readonly FileInfo fileInfo;

      
        private int lineCount;
      
        private readonly int consoleDefaultBufferHeight = 15000;

        public FolderExplorer(string path)
        {
            Console.SetBufferSize(300, consoleDefaultBufferHeight);
            startDirectoryPath = path;
            printer = new Printer();
            startDirectoryInfo = new DirectoryInfo(startDirectoryPath);
            fileInfo = new FileInfo(startDirectoryPath);
        }

        public void Run()
        {
            Console.WriteLine(startDirectoryPath);
            ProcessFolder(startDirectoryInfo, 1);
            if(Console.BufferHeight < lineCount)
            {
                Console.Clear();
                Console.WriteLine("Your console buffer heigh is less than lines count.\n" +
                    "Press any button to set matching heigh");
                Console.ReadKey();
                Console.Clear();
                Console.SetBufferSize(300, lineCount + 100);
                ProcessFolder(startDirectoryInfo, 1);
            }
            Console.WriteLine($"Line count = {lineCount}");
        }

        private void ProcessFolder(DirectoryInfo directoryInfo, int tabCount)
        {
            try
            {
                //foreach (var file in directoryInfo.GetFiles())
                //{
                //    lineCount++;
                //    printer.Print(file.Name, tabCount, Type.File);
                //}
                foreach (var directory in directoryInfo.GetDirectories())
                {
                    
                    lineCount++;
                    printer.Print(directory.Name, tabCount, Type.Folder, lineCount);
                    ProcessFolder(directory, tabCount + 1);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                printer.PrintNoRootsMessage("<This folder has a link to other folder>", tabCount, lineCount);
            }

        }
        

    }
}
