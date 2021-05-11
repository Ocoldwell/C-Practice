using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers seperated by hyphens: ");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) Environment.Exit(0);
            var numbers = input.Split('-').Select(number => Convert.ToInt32(number)).ToList();
            Console.WriteLine(HasDuplicate(numbers) ? "Has duplicate" : "No duplicates were found");
        }

        static bool HasDuplicate(List<int> numbers)
        {
            return numbers.GroupBy(number => number).Any(duplicate => duplicate.Count() > 1);
        }
    }
}
