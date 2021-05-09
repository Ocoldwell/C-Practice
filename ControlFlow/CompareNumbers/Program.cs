using System;

namespace CompareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compare two numbers here:");
            Console.WriteLine("Enter number 1");
            var number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            var number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("The first number {0} is larger", number1);
            }
            else
            {
                Console.WriteLine($"The second number {number2} is larger");
            }
        }
    }
}
