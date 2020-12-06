using System;
using System.IO;
using System.Text;

// Write a program that reads a file and displays the longest word in the file.

namespace practice.beginners.files
{
    public class LongestWordInFile
    {
        public static void Run()
        {
            var text = ReadFileToString("/words.txt");
            var words = text.Split(' ');
            var longestWord = "";
            foreach (var word in words)
            {
                if (longestWord.Length < word.Length)
                    longestWord = word;
            }
            Console.WriteLine("The longest word in the word.txt file is: " + longestWord);
        }

        private static string ReadFileToString(string filePath)
        {
            using (var streamReader = new StreamReader(@"" + filePath + "", Encoding.UTF8))
                return streamReader.ReadToEnd();
        }
    }
}
