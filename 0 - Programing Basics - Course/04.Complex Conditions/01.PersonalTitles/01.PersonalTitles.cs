using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PersonalTitles
{
    public class Program
    {
        public static void Main()
        {
            double age = double.Parse(Console.ReadLine());
            string gen = Console.ReadLine();

            if (gen == "m")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else Console.WriteLine("Master");

            }
            else if (gen == "f")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else Console.WriteLine("Miss");
            }
        }
    }
}
