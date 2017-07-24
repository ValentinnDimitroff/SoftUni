namespace _05.Generic_Count_Method_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            IList<Box<string>> boxes = new List<Box<string>>();
            var numberOfStrings = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStrings; i++)
            {
                var currentString = Console.ReadLine();
                boxes.Add(new Box<string>(currentString));
            }

            var element = new Box<string>(Console.ReadLine());
            var result = GetGreaterElementsCount(boxes, element);
            Console.WriteLine(result);
        }

        public static int GetGreaterElementsCount<T>(IList<T> list, T element)
            where T : IComparable<T>
        {
            return list.Count(x => x.CompareTo(element) > 0);
        }

        //public static int GetGreaterElementsCount<T>(IList<Box<T>> list, Box<T> element)
        //    where T : IComparable
        //{
        //    return list.Count(x => x.Value.CompareTo(element.Value) > 0);
        //}
    }
}
