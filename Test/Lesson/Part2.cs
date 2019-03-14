using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Part2
    {
        public enum Faces
        {
            Face1 = 1,
            Face2

        }

        public void Run()
        {
            //IEnumerator<T>
            //IEnumerable<T>

            //IList<T>

            //IDictionary<>
            Faces face = Faces.Face1;
            int a = (int)face;
            Console.WriteLine(a);
            //List<int> list = new List<int>();
            //list.Add(2);
            //list.AddRange(new int[] { 1, 2, 3, 4 });

            //list.Insert(5, 123);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("====================");

            //var stopWatch = new Stopwatch();

            //List<int> list1 = new List<int>(60);
            //Console.WriteLine(list1.Capacity);
            //Console.WriteLine(list1.Count);
            //stopWatch.Start();
            //for (int i = 0; i < 10000; i++)
            //{
            //    list1.Add(i);
            //    //Console.WriteLine("Capasity: {0}", list1.Capacity);
            //    //Console.WriteLine("Count: {0}", list1.Count);
            //}
            //stopWatch.Stop();
            //Console.WriteLine(stopWatch.ElapsedTicks);
            ////3486

            Console.ReadKey();
        }
    }
}
