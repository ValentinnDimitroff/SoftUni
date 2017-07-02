namespace FamilyTree
{
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        private List<Person> children;

        public Person()
        {
            this.children = new List<Person>();
        }

        public Person(string nameOrDate) : this()
        {
            if (nameOrDate.Contains("/"))
            {
                this.BirthDate = nameOrDate;
            }
            else
            {
                this.Name = nameOrDate;
            }
        }

        public Person(string name, string date) : this()
        {
            this.Name = name;
            this.BirthDate = date;
        } 

        public string BirthDate { get; set; }
        public string Name { get; set; }

        public IReadOnlyList<Person> Children => this.children.AsReadOnly(); 

        public void AddChild(Person child) => this.children.Add(child);

        public void AddChildInfo(Person child)
        {
            if (this.children.SingleOrDefault(c => c.Name == child.Name) != null)
                this.children.SingleOrDefault(c => c.Name == child.Name).BirthDate = child.BirthDate;
            else if (this.children.SingleOrDefault(c => c.BirthDate == child.BirthDate) != null)
                this.children.SingleOrDefault(c => c.BirthDate == child.BirthDate).Name = child.Name;
        }

        public Person FindChild(Person child) => this.children.SingleOrDefault(c => c.Name == child.Name);
    }
}
