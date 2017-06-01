using System;
using System.IO;

namespace _02.Line_Numbers
{
    public class LineNumbers
    {
        public static void Main(string[] args)
        {
            using (var reader = new StreamReader("somefile.txt"))
            {
                using (var writer = new StreamWriter("numberedFile.txt"))
                {
                    int lineNumber = 1;
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(lineNumber + line);
                        line = reader.ReadLine();
                        lineNumber++;
                    }
                }
            }
        }
    }
}