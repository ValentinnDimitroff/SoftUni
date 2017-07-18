namespace _08.Military_Elite.Entities.Soldiers.Privates.SpecialisedSoldiers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Interfaces;
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, double salary, string corps, List<IRepair> repairs) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = repairs;
        }

        public List<IRepair> Repairs { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .Append("Repairs:");
            if (this.Repairs.Any())
            {
                sb.AppendLine();
                sb.Append("  " + string.Join(Environment.NewLine + "  ", this.Repairs));
            }

            return sb.ToString();
        }
    }
}
