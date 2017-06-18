using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Weak_Students
{
    public class WeakStudents
    {
        public static void Main()
        {
            var group = new List<string[]>();
            string student;

            while ((student = Console.ReadLine()) != "END")
                group.Add(student.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            group
                .Where(s => s.Skip(2).Count(num => int.Parse(num) <= 3) >= 2)
                .Select(st => $"{st[0]} {st[1]}")
                .ToList()
                .ForEach(res => Console.WriteLine(res));
        }
    }
}
