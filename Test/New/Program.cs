using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Concurrent;

namespace Test
{

    public class Program
    {
        public static bool Check(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var ch in str)
            {
                switch (ch)
                {
                    case '[':
                    case '{':
                        stack.Push(ch);
                        break;
                    case ']':
                        {
                            if (stack.Count == 0) return false;
                            var temp = stack.Pop();
                            if (temp != '[') return false;
                        }
                        break;
                    case '}':
                        {
                            if (stack.Count == 0) return false;
                            var temp = stack.Pop();
                            if (temp != '{') return false;
                        }
                        break;
                    default:
                        return false;
                }
            }
            return stack.Count == 0;

        }

        public static void Main(string[] args)
        {
            string brackets = "[{}][][";
            bool result = Check(brackets);
            Console.WriteLine($"Brackets: {brackets} = {result}");


            ConcurrentDictionary<int, string> kv = new ConcurrentDictionary<int, string>();

            kv[0] = "Kharkiv";
            kv[1] = "Moskov";

            foreach (var item in kv)
            {
                Console.WriteLine(item);
                
            }
            Console.ReadKey();
        }

        
    }

}
