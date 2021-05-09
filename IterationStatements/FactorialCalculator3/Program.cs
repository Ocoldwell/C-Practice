using System;
using System.Numerics;

namespace FactorialCalculator3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial calculator, enter a number and the calculator will work out and display the factorial");
            Console.WriteLine("For example 5! is equal to 5x4x3x2x1 = 120");
            Console.Write("Enter a number: ");
            var bi = new BigInteger(1);
            var factorial = int.Parse(Console.ReadLine());
            for (var i = 1; i <= factorial; i++)
            {
                bi *= i;
            }

            Console.WriteLine("Factorial of {0}! = {1}", factorial, bi);
        }
    }
}
