using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cities = new MyDictionary<int, string>();
            cities.Add(05, "Amasya");
            cities.Add(06, "Ankara");
            cities.Add(34, "İstanbul");
            Console.WriteLine(cities.count);
        }
    }
}
