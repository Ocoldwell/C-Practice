using System;

namespace ReadFileDisplayWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change this path and it will display word count of target file.
            const string FILE_PATH = "/Users/olliecoldwell/Projects/C#Practice/Files/ReadFileDisplayWords/test.txt";

            var text = ReadFiles.ReadFileToString(FILE_PATH);
            var words = text.Split(' ');
            Console.WriteLine($"The file has {words.Length} words in it");
        }
        
    }
}
