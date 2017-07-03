namespace Mankind
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            try
            {
                var studentInfo = Console.ReadLine().Split(' ');
                var workerInfo = Console.ReadLine().Split(' ');

                var student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                var worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]), double.Parse(workerInfo[3]));

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
