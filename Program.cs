using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyDictionary Demo 29.01.2020 Armağan Bice");
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Armağan");
            myDictionary.Add(2, "Engin");
            myDictionary.Add(3, "Seda");
            // foreach list sample
            Console.WriteLine("foreach sample for access MyDictionary Values");
            foreach (string item in myDictionary.Values)
            {
                Console.WriteLine(item);
            }
            // myDictionary.List sample
            Console.WriteLine("MyDictionary.List");
            myDictionary.List();
            Console.ReadLine();
        }
    }
}
