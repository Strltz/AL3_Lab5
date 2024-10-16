using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    public class MyList<T> : IEnumerable<T>
    {
        private T[] theList;

        private int elem_counter;
        public MyList()
        {
            theList = new T[4];
            elem_counter = 0;   
        }

        public MyList(T[] theList)
        {
            this.theList = theList;
            elem_counter = theList.Length;
        }


        public T this[int a]
        {
            get
            {
                return theList[a];
            }
        }

        public int length()
        {
            return theList.Length;
        }

        public void Add(T elem)
         {
            elem_counter++;
            if(theList.Length == elem_counter)
            {
                Array.Resize(ref theList, length() * 2);
                            }
            theList[elem_counter-1] = elem;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < elem_counter; ++i)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return theList.GetEnumerator();
        }
    }
}
