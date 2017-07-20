namespace _08.Custom_List_Sorter
{
    using System;
    using System.Linq;

    public class Sorter
    {
        public static CustomList<T> Sort<T>(CustomList<T> customList)
            where T : IComparable
        {
            var temp = customList.ToArray();
            Array.Sort(temp);
            return new CustomList<T>(temp);
        }
    }
}
