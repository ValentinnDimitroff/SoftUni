using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Students_By_First_And_Last_Name
{
    public class StudentsByFirstLastName
    {
        public static void Main()
        {
            var group = new List<string[]>();
            string student;

            while ((student = Console.ReadLine()) != "END")
                group.Add(student.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            group
                .Where(s => s[0].CompareTo(s[1]) == -1)
                .ToList()
                .ForEach(x => Console.WriteLine(x[0] + " " + x[1]));
        }
    }
}
