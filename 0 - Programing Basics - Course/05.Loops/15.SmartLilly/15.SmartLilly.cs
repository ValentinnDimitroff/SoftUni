using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.SmartLilly
{
    public class Program
    {
        public static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            double machinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toysCount = 0;
            double sumMoney = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0) sumMoney += i / 2 * 10 - 1;
                else toysCount++;
            }

            sumMoney += toysCount * toyPrice;

            if (machinePrice <= sumMoney)
            {
                Console.WriteLine("Yes! {0:f2}", sumMoney - machinePrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", machinePrice - sumMoney);
            }
        }
    }
}
