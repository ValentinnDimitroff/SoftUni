using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Fix_Emails
{
    public class Program
    {
        public static void Main()
        {
            var emailBook = new Dictionary<string, string>();
            var message = Console.ReadLine();
            var lineCounter = 1;
            var person = "";

            while (message != "stop")
            {
                if (lineCounter % 2 != 0)
                {
                    person = message;
                }
                else
                {
                    if (!message.EndsWith("uk") && !message.EndsWith("us"))
                    {
                        emailBook[person] = message;
                    }
                }
                message = Console.ReadLine();
                lineCounter++;
            }

            foreach (var pair in emailBook)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
