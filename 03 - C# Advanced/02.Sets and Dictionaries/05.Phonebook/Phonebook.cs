using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Phonebook
{
    public class Program
    {
        public static void Main()
        {
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            var message = "";
            var phoneBook = new Dictionary<string, string>();
#pragma warning restore CS0219 // Variable is assigned but its value is never used
            while (message != "search")
            {
                message = Console.ReadLine();
                var contactParams = message
                    .Split('-')
                    .ToArray();
                if (contactParams.Length == 2)
                {
                    phoneBook[contactParams[0]] = contactParams[1];
                }
            }
            message = Console.ReadLine();
            while (message != "stop")
            {
                if (phoneBook.ContainsKey(message))
                {
                    Console.WriteLine($"{message} -> {phoneBook[message]}");
                }
                else
                {
                    Console.WriteLine($"Contact {message} does not exist.");
                }
                message = Console.ReadLine();
            } 

        }
    }
}
