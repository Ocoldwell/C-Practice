using System;

namespace PortraitLandscape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determine if an image is portrait or landscape");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Enter the width");
            var width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height");
            var height = int.Parse(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("This is a landscape image");
            }
            else if (height > width)
            {
                Console.WriteLine("This is a portrait image");
            }
            else if (width == height)
            {
                Console.WriteLine("This is a square image");
            }
        }
    }
}
