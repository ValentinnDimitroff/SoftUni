using System;
using System.Text.RegularExpressions;

public class MatchPhoneNumbers
{
    public static void Main()
    {
        var pattern = @"^[\+]359(?<del> |-)[2](\k<del>)[\d]{3}(\k<del>)[\d]{4}\b";

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