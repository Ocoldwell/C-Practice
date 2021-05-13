using System;

namespace _24HourClockCheckFormatString
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a time between 00:00 and 23:59: ");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid time");
            }
            else
            {
                var hour = Convert.ToInt32(input?.Split(':')[0]);
                var minute = Convert.ToInt32(input?.Split(':')[1]);

                if (isValidHour(hour) && isValidMinute(minute))
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Invalid Time");
                }
            }
        }
        private static bool isValidHour(int hour)
        {
            return hour >= 0 && hour <= 23;
        }
        private static bool isValidMinute(int minute)
        {
            return minute >= 0 && minute <= 59;
        }
    }
}
