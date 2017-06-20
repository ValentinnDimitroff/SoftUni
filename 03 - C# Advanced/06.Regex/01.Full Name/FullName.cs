using System;
using System.Text.RegularExpressions;

namespace _01.Full_Name
{
    public class FullName
    {
        public static void Main()
        {
            var pattern = @"(^[A-Z][a-z]+ [A-Z][a-z]+)";

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "end")
            {
                if (inputLine != "" && Regex.IsMatch(inputLine, pattern))
                {
                    Console.WriteLine(inputLine); 
                }
            }
        }
    }
}
