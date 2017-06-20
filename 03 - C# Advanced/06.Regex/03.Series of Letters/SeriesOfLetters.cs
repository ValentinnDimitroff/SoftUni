using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class SeriesOfLetters
{
    public static void Main()
    {
        var inputStr = Console.ReadLine();

        var reg = new Regex(@"([\w])(\1+)");
        var result = reg.Replace(inputStr, "$1");
        Console.WriteLine(result);
    }
}