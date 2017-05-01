using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TradeCommision
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (sales >= 0)
                {
                    if (sales <= 500)
                    {
                        Console.WriteLine("{0:f2}", sales * 5 / 100);
                    }
                    else if (sales <= 1000)
                    {
                        Console.WriteLine("{0:f2}", sales * 7 / 100);
                    }
                    else if (sales <= 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 8 / 100);
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 12 / 100);
                    }
                }
                else Console.WriteLine("error");
            }
            else if (city == "Varna")
            {
                if (sales >= 0)
                {
                    if (sales <= 500)
                    {
                        Console.WriteLine("{0:f2}", sales * 4.5 / 100);
                    }
                    else if (sales <= 1000)
                    {
                        Console.WriteLine("{0:f2}", sales * 7.5 / 100);
                    }
                    else if (sales <= 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 10 / 100);
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 13 / 100);
                    }
                }
                else Console.WriteLine("error");
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0)
                {
                    if (sales <= 500)
                    {
                        Console.WriteLine("{0:f2}", sales * 5.5 / 100);
                    }
                    else if (sales <= 1000)
                    {
                        Console.WriteLine("{0:f2}", sales * 8 / 100);
                    }
                    else if (sales <= 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 12 / 100);
                    }
                    else if (sales > 10000)
                    {
                        Console.WriteLine("{0:f2}", sales * 14.5 / 100);
                    }
                }
                else Console.WriteLine("error");
            }
            else Console.WriteLine("error");
        }
    }
}
