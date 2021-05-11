using System;
using System.Linq;

namespace ConsecutiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a few numbers seperated by a hyphen: ");
            var input = Console.ReadLine();
            var inputParsed = input.Split('-').Select(int.Parse).ToList();
            if (AreConsecutive.Consecutive(inputParsed))
                Console.WriteLine("Consecutive");
        }
    }
}
