using System.IO;
using System.Text;

namespace ReadFileDisplayWords
{
    class ReadFiles
    {
        public static string ReadFileToString(string filePath)
        {
            var streamReader = new StreamReader(@filePath, Encoding.UTF8);
            return streamReader.ReadToEnd();
        }
    }
}
