using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Logs_Aggregator
{
    public class Logs_Aggregator
    {
        public static void Main()
        {
            var linesNumber = int.Parse(Console.ReadLine());
            var logIps = new Dictionary<string, HashSet<string>>();
            var loggedDuration = new Dictionary<string, int>();
            for (int i = 0; i < linesNumber; i++)
            {
                var logParams = Console.ReadLine()
                    .Split();
                var ip = logParams[0];
                var user = logParams[1];
                var duration = int.Parse(logParams[2]);

                if (logIps.ContainsKey(user))
                {
                    logIps[user].Add(ip);
                    loggedDuration[user] += duration;
                }
                else
                {
                    logIps[user] = new HashSet<string>{ ip };
                    loggedDuration[user] = duration;
                }
            }

            foreach (var user in logIps.OrderBy(user => user.Key))
            {
                Console.WriteLine($"{user.Key}: {loggedDuration[user.Key]} [{string.Join(", ", user.Value.OrderBy(ip => ip))}]");
            }
        }
    }
}
