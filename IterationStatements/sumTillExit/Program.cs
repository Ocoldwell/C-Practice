using System;

namespace sumTillExit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int accumulator= 0;
            do
            {
                Console.WriteLine("Sum all inputs");
                Console.WriteLine("Enter a number, or ok to exit");
                input = Console.ReadLine();
                if (input != "ok")
                {
                    accumulator += int.Parse(input);
                }
            } while (input != "ok");
            Console.WriteLine(accumulator);
        }
    }
}
