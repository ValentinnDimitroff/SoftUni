using System;
using System.Text;
using System.Text.RegularExpressions;

public class Regeh
{
    public static void Main()
    {
        var inputStr = Console.ReadLine();
        //var inputStr = "";
        //using (var reader = new StreamReader("../../Tests/test.010.in.txt"))
        //    inputStr = reader.ReadToEnd();

        var rgx = new Regex("[\\[][^\\[\\]\\s]+<(?<frontDigits>\\d+)REGEH(?<backDigits>\\d+)>[^\\[\\]\\s]+[]]");
        var index = 0;
        var output = new StringBuilder();

        var matches = rgx.Matches(inputStr);
        if (matches.Count > 0)
        {
            foreach (Match match in matches)
            {
                index += int.Parse(match.Groups["frontDigits"].Value);
                output.Append(inputStr[index % inputStr.Length]);
                index += int.Parse(match.Groups["backDigits"].Value);
                output.Append(inputStr[index % inputStr.Length]);
            }
        }

        Console.WriteLine(output);
    }
}