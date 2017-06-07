using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace _02.ParseURLs
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = Console.ReadLine();

            var urlTokens = url.Split(new[] {"://"}, StringSplitOptions.RemoveEmptyEntries);
            if (urlTokens.Length != 2 || urlTokens[1].IndexOf('/') == -1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }
            else
            {
                var protocol = urlTokens[0];
                var serverEndIndex = urlTokens[1].IndexOf('/');
                var server = urlTokens[1].Substring(0, serverEndIndex);
                var resource = urlTokens[1].Substring(serverEndIndex + 1);

                Console.WriteLine("Protocol = " + protocol);
                Console.WriteLine("Server = " + server);
                Console.WriteLine("Resources = " + resource);
            }
        }
    }
}