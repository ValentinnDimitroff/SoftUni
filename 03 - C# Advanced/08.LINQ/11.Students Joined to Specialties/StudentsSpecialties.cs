using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Students_Joined_to_Specialties
{
    public class StudentsSpecialties
    {
        public static void Main()
        {
            var specialties = new List<StudentSpecialty>();
            var students = new List<Student>();
            var input = Console.ReadLine();

            while (input != "Students:")
            {
                var tokens = input.Split(' ');
                specialties.Add(new StudentSpecialty(tokens[0] +" "+ tokens[1], int.Parse(tokens[2])));
                input = Console.ReadLine();
            }

            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split(new []{' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
                students.Add(new Student(tokens[1] + " " + tokens[2], int.Parse(tokens[0])));
            }

            students
                .Join(specialties, st => st.FacultyNumber, sp => sp.FacultyNumber, (st, sp) => new
                {
                    Name = st.StudentName,
                    FacultyNum = st.FacultyNumber,
                    Specialty = sp.SpecialtyName
                })
                .OrderBy(j => j.Name)
                .ToList()
                .ForEach(res => Console.WriteLine($"{res.Name} {res.FacultyNum} {res.Specialty}"));
        }
    }

    public class StudentSpecialty
    {
        public string SpecialtyName { get; set; }
        public int FacultyNumber { get; set; }

        public StudentSpecialty(string name, int number)
        {
            this.FacultyNumber = number;
            this.SpecialtyName = name;
        }
    }

    public class Student
    {
        public string StudentName { get; set; }
        public int FacultyNumber { get; set; }

        public Student(string name, int number)
        {
            this.FacultyNumber = number;
            this.StudentName = name;
        }
    }
}
