using SimpleListIndexer.models;

namespace SimpleListIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleList<int> s1 = new SimpleList<int>(3);
            Console.WriteLine(s1[0].GetData()); 
        }
    }
}
