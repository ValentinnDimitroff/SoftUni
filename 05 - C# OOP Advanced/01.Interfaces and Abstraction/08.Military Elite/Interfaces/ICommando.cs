namespace _08.Military_Elite.Interfaces
{
    using System.Collections.Generic;

    public interface ICommando
    {
        IEnumerable<IMission> Missions { get; }
    }
}
