using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Word_Count
{
    public class WordCount
    {
        public static void Main()
        {
            var words = new Dictionary<string, int>();
            using (var wordsReader = new StreamReader("words.txt"))
            {
                var line = wordsReader.ReadLine();
                while (line != null)
                {
                    words.Add(line, 0);
                    line = wordsReader.ReadLine();
                }
            }

            using (var textReader = new StreamReader("text.txt"))
            {
                var line = textReader.ReadLine();
                while (line != null)
                {
                    var lineWords = Regex.Matches(line.ToLower(), @"[\w'+]+");

                    foreach (Match match in lineWords)
                    {
                        var word = match.Groups[0].ToString();
                        if (words.ContainsKey(word))
                        {
                            words[word]++;
                        }
                    }
                    line = textReader.ReadLine();
                }
            }

            foreach (var word in words.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }
}
