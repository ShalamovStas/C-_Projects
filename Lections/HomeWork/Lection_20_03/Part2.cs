using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_20_03
{
    class Part2
    {
        internal static void Run()
        {
            var path = @"D:\C#\";
            var path1 = @"D:\C#\ITCloud_Projects\NewFolder";
            //if (Directory.Exists(path))
            //{
            //    Console.WriteLine("Connected");
            //    var directories = Directory.GetDirectories(path);
            //    foreach (var item in directories)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    Console.WriteLine("\nFiles");
            //    var files = Directory.GetFiles(path);
            //    foreach (var file in files)
            //    {
            //        Console.WriteLine(file);
            //    }
            //}

            var pathForDir = @"D:\C#\ITCloud_Projects\SubFolder\";
            var dir = new DirectoryInfo(pathForDir);

            if (dir.Exists) dir.Create();

            //var dirInfo = dir.CreateSubdirectory("SubFolder");
            //File.Move(@"D:\C#\ITCloud_Projects\test.txt", @"D:\C#\ITCloud_Projects\SubFolder\test.txt");

            for (int i = 0; i < 2; i++)
            {
                File.Create(pathForDir.ToString() + "_" + i);
            }

            //в текст док имена и пути всех файлов которые созданы больше чем 17 дней назад
            // папка текущего пользователя на компе
            // список должен быть древовидный
            // текстовый док заархивировать и положить на рабочий стол правый верхний угол
        }

    }
}
