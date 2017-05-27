using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Periodic_Table
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var compound = Console.ReadLine()
                    .Split();
                    //.ToArray();

                foreach (var element in compound)
                {
                    elements.Add(element);
                }
                //elements.UnionWith(compound); //Slower
            }
            
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
