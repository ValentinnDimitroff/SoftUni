namespace _09.Collection_Hierarchy
{
    using System.Collections.Generic;

    public abstract class Collection<T>
    {
        private const int MaxSize = 100;
        protected IList<T> items;

        protected Collection()
        {
            this.items = new List<T>(MaxSize);
        }
    }
}
