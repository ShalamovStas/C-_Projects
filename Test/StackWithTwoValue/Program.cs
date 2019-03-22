using StackWithTwoValue;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedStack
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable hashtable = new Hashtable();
            hashtable.Add("One", 1);           
            hashtable.Add("Two", 2);           
            hashtable.Add("Three", 3);

            var keys = hashtable.Keys;
            var values = hashtable.Values;


            foreach (var item in keys)
            {
                Console.Write(item + " => " + hashtable[item] + "\n");
            }
            

            Console.ReadKey();

        }
    }
}
