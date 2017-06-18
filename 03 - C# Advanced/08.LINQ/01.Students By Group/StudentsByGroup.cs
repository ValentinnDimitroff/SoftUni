using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Students_By_Group
{
    public class StudentsByGroup
    {
        public static void Main()
        {
            var group = new List<string[]>();
            string student;

            while ((student = Console.ReadLine()) != "END")
                group.Add(student.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries));

            group
                .Where(s => s.Last() == "2")
                .OrderBy(a => a[0])
                .ToList()
                .ForEach(x => Console.WriteLine(x[0] + " " + x[1]));
        }
    }
}
