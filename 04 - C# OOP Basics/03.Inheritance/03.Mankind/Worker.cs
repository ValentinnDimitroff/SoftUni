namespace Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;
        private string _secondName;

        public Worker(string firstName, string secondName, decimal weekSalary, double workHoursPerDay) : base(firstName, secondName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }   
                this.workHoursPerDay = value;
            }
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString())
                .Append("Week Salary: ").AppendLine($"{this.WeekSalary:f2}")
                .Append("Hours per day: ").AppendLine($"{this.WorkHoursPerDay:f2}")
                .Append("Salary per hour: ").AppendLine($"{this.WeekSalary / ((decimal)this.WorkHoursPerDay * 5m):f2}");

            return sb.ToString();
        }
    }
}
