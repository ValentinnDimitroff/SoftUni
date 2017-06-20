using System;
using System.Text;
using System.Text.RegularExpressions;

public class ReplaceATag
{
    public static void Main()
    {
        var html = new StringBuilder();
        string inputLine;
        while ((inputLine = Console.ReadLine()) != "end")
        {
            html.Append(inputLine).Append(Environment.NewLine);
        }

        var htmlText = html.ToString();

        var endTagPattern = @"</a>";
        var beginningTagPattern = "(<a href=([^>]*)>)";

        var editedHtml = Regex.Replace(htmlText, beginningTagPattern, "[URL href=$2]");
        editedHtml = Regex.Replace(editedHtml, endTagPattern, "[/URL]");
        Console.WriteLine(editedHtml);
    }
}