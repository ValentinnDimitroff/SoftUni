namespace _08.Custom_List_Sorter
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;

    public class CustomList<T> : ICustomList<T>, IEnumerable<T>
        where T : IComparable
    {
        private IList<T> list;

        public CustomList()
            : this(Enumerable.Empty<T>()) 
        {
        }

        public CustomList(IEnumerable<T> collection)
        {
            this.list = new List<T>(collection);
        }
        
        public void Add(T element) => this.list.Add(element);

        public T Remove(int index)
        {
            var temp = this.list[index];
            this.list.RemoveAt(index);
            return temp;
        }

        public bool Contains(T element) => this.list.Contains(element);

        public void Swap(int index1, int index2)
        {
            var temp = this.list[index1];
            this.list[index1] = this.list[index2];
            this.list[index2] = temp;
        }

        public int CountGreaterThan(T element) => this.list.Count(x => x.CompareTo(element) > 0);

        public T Max() => this.list.Max();
        
        public T Min() => this.list.Min();

        public IEnumerator<T> GetEnumerator() => this.list.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}