using System;

namespace FindLongestWordInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            const string FILE_PATH ="/Users/olliecoldwell/Projects/C#Practice/Files/FindLongestWordInFile/test.txt";

            var text = FileReader.ReadFileToString(FILE_PATH);
            var words = text.Split(' ');
            string longestWord = "";
            foreach (var word in words)
            {
                var tmpWord = word;
                if (tmpWord.Length > longestWord.Length)
                {
                    longestWord = tmpWord;
                }
            }
            Console.WriteLine("The longest word is {0} at {1}", longestWord, longestWord.Length);
        }
    }
    
}
