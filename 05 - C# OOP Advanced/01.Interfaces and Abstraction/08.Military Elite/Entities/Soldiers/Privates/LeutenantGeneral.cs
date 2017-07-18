namespace _08.Military_Elite.Entities
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastName, double salary, List<ISoldier> privates) : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }

        public List<ISoldier> Privates { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .Append("Privates:");
            if (this.Privates.Any())
            {
                sb.AppendLine();
                sb.Append($"{"  " + string.Join(Environment.NewLine + "  ", this.Privates)}");
            }

            return sb.ToString();
        }
    }
}
