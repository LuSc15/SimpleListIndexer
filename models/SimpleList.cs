using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleListIndexer.models
{
    internal class SimpleList<T> where T : IComparable
    {

        private Entry<T>[] arr = new Entry<T>[100];

        public Entry<T> this[int i] { get { return arr[i]; } set { arr[i] = value; } }

        static int zähler = 0;
        private Entry<T> _head;
        private Entry<T> _tail;
        public SimpleList(T startwert) 
            { 
                Entry<T> dummy = new Entry<T>(startwert);
                _head = dummy;
                _tail = dummy;
                this.arr[zähler] = dummy;
                zähler++;
            }
    }
}
