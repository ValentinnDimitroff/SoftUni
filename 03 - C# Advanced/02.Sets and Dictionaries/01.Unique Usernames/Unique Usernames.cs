using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Unique_Usernames
{
    public class Program
    {
        public static void Main()
        {
            var numberUsernames = int.Parse(Console.ReadLine());
            var usernames = new HashSet<string>();

            for (int i = 0; i < numberUsernames; i++)
            {
                usernames.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join("\n", usernames));
        }
    }
}
