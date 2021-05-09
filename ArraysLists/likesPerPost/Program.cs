using System;
using System.Collections.Generic;

namespace likesPerPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var listFriends = new List<string>();
            Console.WriteLine("A display logic for adding likes to a post.");
            
            
            do
            {
              Console.Write("Enter a name: ");
              var name = Console.ReadLine();
              if (String.IsNullOrEmpty(name))
                {
                    break;
                }
              listFriends.Add(name);
                if (listFriends.Count == 1)
                {
                    Console.WriteLine($"{listFriends[0]} likes your post");
                }
                else if (listFriends.Count == 2)
                {
                    Console.WriteLine($"{listFriends[0]} and {listFriends[1]} like your post");
                }
                else
                {
                    Console.WriteLine($"{listFriends[0]}, {listFriends[1]} and {listFriends.Count -2} others like your post");
                }
            }
            while (listFriends.Count > 0);
        }
    }
}
