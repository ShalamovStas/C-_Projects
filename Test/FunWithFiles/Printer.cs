using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithFiles
{
    class Printer
    {
        internal void Print(string directory, int tabCount, Type type, int lineNumber)
        {
            PrintTabulation(lineNumber, tabCount);
            PrintSymbol(type);
            Console.WriteLine(directory);
        }

        private void PrintSymbol(Type type)
        {
            switch (type)
            {
                case Type.File:
                    Console.Write("-");
                    break;
                case Type.Folder:
                    Console.Write(">");
                    break;
            }
        }

        internal void PrintNoRootsMessage(string v, int tabCount, int lineNumber)
        {
            PrintTabulation(lineNumber, tabCount);
            
            Console.WriteLine(v);
        }

        private void PrintTabulation(int lineNumber, int tebCount)
        {
            Console.Write(lineNumber.ToString() + new string(' ', 5 - lineNumber.ToString().Length));
            for (int i = 0; i < tebCount; i++)
            {
                Console.Write("    ");
            }
        }
    }
}
