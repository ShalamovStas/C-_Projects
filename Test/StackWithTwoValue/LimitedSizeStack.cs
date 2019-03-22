using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedStack
{
    public class LimitedSizeStack<T>
    {
        private int limit;
        private int count;
        private Stack<T> internalStack;


        public LimitedSizeStack(int limit)
        {
            this.limit = limit;
            internalStack = new Stack<T>();
        }

        public void Push(T item)
        {

            internalStack.Push(item);
            if (count < limit) count++;

        }

        public T Pop()
        {
            if (count != 0)
            {
                count--;
                return internalStack.Pop();
            }
            else return default(T);


        }

        public int Count
        {
            get
            {
                return count;
            }
        }


    }

}

