using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.A_Miner_Task
{
    public class Program
    {
        public static void Main()
        {
            var message = Console.ReadLine();
            var lineCounter = 1;
            var resources = new Dictionary<string, int>();
            var currentResource = "";

            while (message != "stop")
            {
                if (lineCounter % 2 != 0)
                {
                    currentResource = message;
                }
                else
                {
                    if (resources.ContainsKey(currentResource))
                    {
                        resources[currentResource] += int.Parse(message);
                    }
                    else
                    {
                        resources[currentResource] = int.Parse(message);
                    }
                }
                message = Console.ReadLine();
                lineCounter++;
            }

            foreach (var pair in resources)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
