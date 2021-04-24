using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string , int>();
            myDictionary.Add("Computer", 5);
            myDictionary.Add("Software", 6);

            Console.WriteLine(myDictionary.Count);
        }
    }
}
