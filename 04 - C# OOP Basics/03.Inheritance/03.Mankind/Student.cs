namespace Mankind
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string secondName, string facultyNumber) : base(firstName, secondName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (!Regex.IsMatch(value, "^([A-Za-z\\d]{5,10})$"))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

       public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString())
                .Append("Faculty number: ").Append(this.FacultyNumber)
                .AppendLine();
            
            return sb.ToString();
        }
    }
}
