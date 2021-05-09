using System;

namespace SpeedCameraLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speed Camera");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Hi, what is the speed limit?");
            var SPEED_LIMIT = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the speed the car was going at");
            var speedOfCar = int.Parse(Console.ReadLine());
            if (speedOfCar <= SPEED_LIMIT)
            {
                    Console.WriteLine("Okay");
            }
            else
            {
                var difference = speedOfCar - SPEED_LIMIT;
                var demerits = difference / 5;
                if (demerits > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine($"You have received {demerits} demerits");
                }
            }
        }
    }
}
