using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minutesArrive = int.Parse(Console.ReadLine());

            int timeExam = hourExam * 60 + minutesExam;
            int timeArrive = hourArrive * 60 + minutesArrive;
            int minutesDiff = timeExam - timeArrive;
            if (minutesDiff <= 30 && minutesDiff >= 0)
            {
                Console.WriteLine("On time");
                if (minutesDiff != 0)
                {
                    Console.WriteLine("{0} minutes before the start", minutesDiff);
                }
            }
            else if (minutesDiff > 30)
            {
                Console.WriteLine("Early");
                if (minutesDiff < 60)
                {
                    Console.WriteLine("{0} minutes before the start", minutesDiff);
                }
                else
                {
                    int hours = minutesDiff / 60;
                    int minutes = minutesDiff % 60;
                    Console.WriteLine("{0}:{1:d2} hours before the start", hours, minutes);
                }

            }
            else if (minutesDiff < 0)
            {
                Console.WriteLine("Late");
                if (minutesDiff > -60)
                {
                    Console.WriteLine("{0} minutes after the start", Math.Abs(minutesDiff));
                }
                else
                {
                    int hours = minutesDiff / 60;
                    int minutes = minutesDiff % 60;
                    Console.WriteLine("{0}:{1:d2} hours after the start", Math.Abs(hours), Math.Abs(minutes));
                }
            }
        }
    }
}
