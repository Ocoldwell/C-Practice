using System;

namespace NumberCounterDisvisibleby3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDivBy3 = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    numDivBy3++;
                }
            }
            Console.WriteLine($"The number of numbers between 1 and 100 that can be divided by 3 is {numDivBy3}");
        }
    }
}
