using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StackForCalc
{
    public class PolishCalc
    {
        public static int Compute(string str)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var item in str)
            {
                if (item >= '0' && item <= '9')
                {
                    stack.Push(Int32.Parse(new string(item, 1)));
                }
                else
                {
                    var numFirst = stack.Pop();
                    var numSecond = stack.Pop();
                    switch (item)
                    {
                        case '*':
                            stack.Push(numFirst * numSecond);
                            break;
                        case '/':
                            stack.Push(numFirst / numSecond);
                            break;
                        case '+':
                            stack.Push(numFirst + numSecond);
                            break;
                        case '-':
                            stack.Push(numFirst - numSecond);
                            break;
                    }
                }
            }
            return stack.Pop();
        }

        public static int ComputeWithBetterWay(string str)
        {
            var stack = new Stack<int>();
            var operations = new Dictionary<char, Func<int, int, int>>();
            operations['+'] = (a, b) => a + b;
            operations['-'] = (a, b) => a - b;
            operations['*'] = (a, b) => a * b;
            operations['/'] = (a, b) => a / b;

            foreach (var item in str)
            {
                if (item >= '0' && item <= '9')
                {
                    stack.Push(int.Parse(new string(item, 1)));
                }
                else
                {
                    var one = stack.Pop();
                    var two = stack.Pop();

                    stack.Push(operations[item](one, two));
                }

            }
            return stack.Pop();
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Compute("25*"));
            Console.WriteLine(ComputeWithBetterWay("25*"));


            Console.WriteLine();

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Russia");
            dict.Add(2, "USA");
            dict[3] = "Canada";

            foreach (var item in dict)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Dictionary<int, Action<int>> bank = new Dictionary<int, Action<int>>();
            bank[0] = i => { var charCount = 3 - i;
                Console.Write("Printing " + new string('.', i)
                + new string(' ', 3 - i));
            };
           

            Console.CursorVisible = false;
            



            for (int i = 0; i < 5; i++)
            {


                for (int k = 0; k <= 3; k++)
                {
                    bank[0](k);
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Thread.Sleep(400);
                }
            }
            Console.ReadKey();
        }


        public static bool TryGetVaue(out int value)
        {
            int count = 0;
            for (int i = 0; i < 20; i++)
            {

                if (Console.KeyAvailable)
                {
                    Console.SetCursorPosition(0, Console.CursorTop + 2);
                    value = new Random().Next(10);
                    return true;
                }
                string label = "";
                switch (count)
                {
                    case 0:
                        label = "Processing    ";
                        count++;
                        break;
                    case 1:
                        label = "Processing .  ";
                        count++;
                        break;
                    case 2:
                        label = "Processing .. ";
                        count++;
                        break;
                    case 3:
                        label = "Processing ...";
                        count = 0;
                        break;
                }
                Console.WriteLine(label);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Thread.Sleep(500);
            }


            value = -1;
            return false;
        }



    }

}
