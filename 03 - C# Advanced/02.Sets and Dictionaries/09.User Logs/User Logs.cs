using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.User_Logs
{
    public class Program
    {
        public static void Main()
        {
            var users = new SortedDictionary<string, Dictionary<string, int>>();
            var message = Console.ReadLine();
            while (message != "end")
            {
                var messageParams = message
                    .Split(' ')
                    .ToArray();
                var ip = messageParams[0].Substring(3, messageParams[0].Length - 3);
                var username = messageParams[2].Substring(5, messageParams[2].Length - 5);

                if (users.ContainsKey(username))
                {
                    if (users[username].ContainsKey(ip))
                    {
                        users[username][ip] += 1;
                    }
                    else
                    {
                        users[username][ip] = 1;
                    }
                }
                else
                {
                    users[username] = new Dictionary<string, int>{ { ip, 1 } };
                }

                message = Console.ReadLine();
            }
            foreach (var user in users)
            {
                Console.WriteLine(user.Key + ":");
                Console.WriteLine("{0}.", string.Join(", ", user.Value.Select(ip => $"{ip.Key} => {ip.Value}")));
            }
        }
    }
}
