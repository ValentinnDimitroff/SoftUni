using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Extract_Hyperlinks
{
    public class ExtractHyperlinks
    {
        public static void Main()
        {
            var text = new StringBuilder();

            var line = Console.ReadLine();
            while (line != "END")
            {
                text.Append(line);
                line = Console.ReadLine();
            }

            var wholeText = text.ToString();
            var openTag = "<a";
            var closeTag = ">";
            var href = "href";

            var aTags = new List<string>();
            while (true)
            {
                int startAtag = wholeText.IndexOf(openTag);
                if (startAtag == -1) break;
                int endAtag = wholeText.IndexOf(closeTag, startAtag);
                if (endAtag == -1) break;

                var aHrefTag = wholeText.Substring(startAtag, endAtag - startAtag);
                aTags.Add(aHrefTag);
                wholeText = wholeText.Remove(startAtag, aHrefTag.Length);
            }

            for (int i = 0; i < aTags.Count; i++)
            {
                var startIndex = aTags[i].IndexOf(href) + href.Length;
                while (startIndex < aTags[i].Length && aTags[i][startIndex] != '=')
                {
                    if (aTags[i][startIndex] != ' ') //If fake href found search for the next one
                    {
                        var oldHrefIndex = aTags[i].IndexOf(href);
                        aTags[i] = aTags[i].Remove(oldHrefIndex, href.Length);
                        startIndex = aTags[i].IndexOf(href, oldHrefIndex) + href.Length;
                    }
                    else
                        startIndex++;
                }
                if (startIndex == -1) continue; //No real hrefs

                while (startIndex < aTags[i].Length)
                {
                    if (char.IsWhiteSpace(aTags[i][startIndex]) ||
                        aTags[i][startIndex] == '=' ||
                        aTags[i][startIndex] == '\'' ||
                        aTags[i][startIndex] == '\"')
                    {
                        startIndex++;
                    }
                    else
                        break;
                }
                var delimiter = aTags[i][startIndex - 1] != '=' ? aTags[i][startIndex - 1] : ' ';

                var endOfLink = aTags[i].IndexOf(delimiter, startIndex);
                if (endOfLink == -1) continue;

                var link = aTags[i].Substring(startIndex, endOfLink - startIndex);
                if (link != "") Console.WriteLine(link);
            }
        }
    }
}
