﻿namespace Google
{
    public class Company
    {
        public Company(string name, string department, decimal salary)
        {
            this.Name = name;
            this.Department = department;
            this.Salary = salary;
        }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }
}
