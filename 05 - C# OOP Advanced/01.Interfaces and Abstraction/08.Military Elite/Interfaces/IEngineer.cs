namespace _08.Military_Elite.Interfaces
{
    using System.Collections.Generic;
    using Entities;

    public interface IEngineer
    {
        List<IRepair> Repairs { get; }
    }
}
