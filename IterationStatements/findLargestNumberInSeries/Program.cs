using System;

namespace findLargestNumberInSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int highNumber = 0;
            int valueTemp;
            Console.Write("Enter a series of numbers seperated by commas:");
            var userInput = Console.ReadLine();
            string[] list = userInput.Split(',');

            for (var i = 0; i < list.Length; i++)
            {
                if(int.TryParse(list[i], out valueTemp))
                {
                    if (valueTemp > highNumber)
                    {
                        highNumber = valueTemp;
                    }
                }
            }
            Console.WriteLine($"The largest number is {highNumber}");
        }
    }
}
