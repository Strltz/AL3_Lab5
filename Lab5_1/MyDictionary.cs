using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    public class MyDictionary<TKey, TValue>
    {
        public TValue[] theList { get; }
        public TKey[] allKeys { get; }
        public MyDictionary(TKey[] theKey, TValue[] theList)
        {
            this.theList = theList;
            this.allKeys = theKey;
        }

        public void add_elem(TKey key, TValue value)
        {
            theList.Append(value);
            allKeys.Append(key);
        }
        
        public TValue this[TKey key]
        {
            get
            {
                int right_index = 0;
                for(int i = 0; i < theList.Length; ++i)
                {
                    if (allKeys[i].Equals(key))
                    {
                        right_index = i;
                        break;
                    }
                }
                return theList[right_index];
            }
        }

        public int length { get => allKeys.Length; }

        public IEnumerable<TValue> GetEnumerator()
        {
            for(int i = 0; i < this.length; ++i)
            {
                yield return theList[i];
            }
        }


    }
}
