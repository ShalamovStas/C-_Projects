using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Part1
    {
        public void Run()
        {
            //IEnumerator
            //IEnumerable

            //ICollection
            //IList

            //IDictionary

            ArrayList arrayList = new ArrayList();
            arrayList.Add(new string[] { "One", "Two"});

            string[] arr = arrayList[0] as string[];

            Console.WriteLine(arr[0]);

            //if(arrayList[0] as Array != null)
            //{

            //}



            Console.ReadKey();

        }
    }
}
