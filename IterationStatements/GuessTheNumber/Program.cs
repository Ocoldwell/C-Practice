using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var numberToGuess = random.Next(1, 10);
            int numberOfGuesses = 4;
            Console.WriteLine("Hey, I've picked a number between 1 and 10, can you guess it?");
            while (numberOfGuesses > 0)
            {
                Console.Write("Enter a number: ");
                var guess = int.Parse(Console.ReadLine());
                
                if (guess == numberToGuess)
                {
                    Console.WriteLine("You guessed {0} correctly!", numberToGuess);
                    break;
                }
                else
                {
                    Console.WriteLine("You guessed incorrectly");
                    numberOfGuesses--;
                }
            }
            Console.WriteLine("You lose. The number was {0}", numberToGuess);
        }
    }
}
