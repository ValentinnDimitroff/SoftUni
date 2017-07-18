namespace _08.Military_Elite.Entities.Soldiers.Privates.SpecialisedSoldiers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Interfaces;

    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, double salary, string corps, List<IMission> missions) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }

        public IEnumerable<IMission> Missions { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .Append("Missions:");
            if (this.Missions.Any())
            {
                sb.AppendLine();
                sb.Append("  " + string.Join(Environment.NewLine + "  ", this.Missions));
            }

            return sb.ToString();
        }
    }
}
