using System;

namespace ReverseANameUsingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine().ToLower();
            var namesArr = name.ToCharArray();
            Array.Reverse(namesArr);
            Console.WriteLine(new String(namesArr));
        }
    }
}
