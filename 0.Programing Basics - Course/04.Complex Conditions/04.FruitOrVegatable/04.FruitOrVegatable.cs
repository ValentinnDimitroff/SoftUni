using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FruitOrVegatable
{
    public class Program
    {
        public static void Main()
        {
            string produce = Console.ReadLine();

            if (produce == "tomato" || produce == "cucumber" || produce == "pepper" || produce == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else if (produce == "banana" || produce == "apple" || produce == "kiwi" || produce == "cherry" || produce == "lemon" || produce == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else Console.WriteLine("unknown");
        }
    }
}
