using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new[] { -3, 0, 1, 2, 3, 5, 7, 11, 13, 17, 19, 23, 24, 26};
            var myList = new MyList(array);

            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }

            #region Question

            
            //foreach (var item in myList)
            //{
            //    if ((int)item == 2)
            //    {
            //        myList.array[4] = 0;
            //    }
            //    Console.Write(item + " ");
            //}


            #endregion

            Console.WriteLine();

            Console.ReadKey();

        }
    }

    class MyList : IEnumerable
    {
        public int[] array;

        public MyList(int[] array)
        {
            this.array = array;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(this);
        }

        class MyEnumerator : IEnumerator
        {
            private int index;
            private MyList myList;

            public MyEnumerator(MyList myList)
            {
                index = -1;
                this.myList = myList;
            }

            public object Current => myList.array[index];

            public bool MoveNext()
            {
                index++;
                while (index != myList.array.Length)
                {
                    if (CheckIfValueIsPrime(myList.array[index]))
                        return true;
                    index++;
                }
                return false;
            }

            private bool CheckIfValueIsPrime(int value)
            {
                if (value <= 1) return false;
                for (int i = 2; i < value; i++)
                {
                    if (value % i == 0) return false;
                }
                return true;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }


}
