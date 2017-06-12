using System;
using System.Collections.Generic;
using System.Linq;

    public class PredicateForNames
    {
        public static void Main()
        {
            var maxLength = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(' ').ToList();

            var filteredNames = FilterNames(names, n => n.Length - maxLength <= 0);

            foreach (var name in filteredNames)
            {
                Console.WriteLine(name);
            }
        }

        private static List<string> FilterNames(List<string> names, Func<string, bool> isShortEnough)
        {
            var result = new List<string>();

            foreach (var name in names)
            {
                if (isShortEnough(name))
                {
                    result.Add(name);
                }
            }

            return result;
        }
    }
