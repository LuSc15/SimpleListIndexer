using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimpleListIndexer.models
{
    internal class Entry<T> where T: IComparable
    {


        private T _data;
        private Entry<T> _next;
        public Entry(T data)
        {
            _data = data;
            _next = null;
            
        }
        public T GetData()
        {
            return _data;
        }
        public void SetNext(Entry<T> next)
        {
            _next = next;
        }
        public Entry<T> GetNext()
        {
            return _next;
        }
    }
}
