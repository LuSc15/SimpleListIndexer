using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SimpleListIndexer.models
{
    internal class SimpleList<T> where T : IComparable
    {
        private Entry<T>[] arr = new Entry<T>[100];   
        string[] zehner = { "erster", "zweiter","dritter","vierter","fünfter","sechster","siebter","achter","neunter","zehnter" };
        public Entry<T> this[int i] { get { return arr[i]; } set { arr[i] = value; } }
        public Entry<T> this[string s] { get { return arr[Array.IndexOf(zehner, s)]; } set { arr[Array.IndexOf(zehner,s)] = value; } }

        static int zähler = 0;
        private Entry<T> _head;
        private Entry<T> _tail;

        public void Indexer(Entry<T> entry)
        {
            this[zähler] = entry;
            zähler++;
        }

        public SimpleList(T startwert) 
            {
            Console.WriteLine("Erstelle neue Liste:");
            Console.WriteLine(startwert + " hinzugefügt");
            Entry<T> entry = new Entry<T>(startwert);
                _head = entry;
                _tail = entry;
            Indexer(entry);
            }
        public void AddToList(T value)
        {
            Console.WriteLine(value+" hinzugefügt");
            Entry<T>entry = new Entry<T>(value);
            Indexer(entry);
            _tail.SetNext(entry);
            _tail = entry;
        }
        public void ReCount()
        {
            int count = 0;
            this.arr[count] = _head;
            while (this.arr[count] != null && this.arr[count].GetNext() != null)
            {
                count++;
                this.arr[count] = this.arr[count].GetNext();
            }
        }
        public void RemoveFirstFromList()
        {
            if (_head != null)
            {
                Console.WriteLine(_head.GetData()+" hat die Liste verlassen");
                
                _head = _head.GetNext();
                ReCount();

            }
            else
            {
                Console.WriteLine("Liste ist leer, entfernen nicht möglich");
            }
        }
        public void PrintList()
        {
            Console.WriteLine("Liste ausgeben:");
            if(_head != null)
            {
                Entry<T> nächster = _head.GetNext();
                Console.WriteLine(_head.GetData());
                while(nächster != null)
                {
                    Console.WriteLine(nächster.GetData());
                    nächster = nächster.GetNext();
                }
            }
            else
            {
                Console.WriteLine("Liste ist leer");
            }
        }
    }
}
