using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PointInTheFigure
{
    public class Program
    {
        public static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ((x >= 0 && x <= 3 * h) && (y >= 0 && y <= h))
            {
                if (y == 0 || x == 0 || x == 3 * h || (y == h && (x >= 0 && (x <= h || (x >= 2 * h && x <= 3 * h)))))
                {
                    Console.WriteLine("Border");
                }
                else Console.WriteLine("Inside");
            }
            else if ((y > h && y <= 4 * h) && (x >= h && x <= 2 * h))
            {
                if (x == h || x == 2 * h || y == 4 * h)
                {
                    Console.WriteLine("Border");
                }
                else Console.WriteLine("Inside");
            }
            else Console.WriteLine("Outside");
        }
    }
}
