using SimpleListIndexer.models;

namespace SimpleListIndexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleList<int> s1 = new SimpleList<int>(3);
            s1.AddToList(4);
            s1.AddToList(5);

            Console.WriteLine("Erster:");
            Console.WriteLine(s1["erster"].GetData());
            Console.WriteLine("Zweiter:");
            Console.WriteLine(s1["zweiter"].GetData());
            Console.WriteLine("Dritter:");
            Console.WriteLine(s1["dritter"].GetData());

            Console.WriteLine("Index [0]:");
            Console.WriteLine(s1[0].GetData());
            s1.RemoveFirstFromList();
            Console.WriteLine("Gebe komplette Liste aus:");
            s1.PrintList();
            Console.WriteLine("Gebe s1[0] aus:");
            Console.WriteLine(s1[0].GetData());
        }
    }
}
