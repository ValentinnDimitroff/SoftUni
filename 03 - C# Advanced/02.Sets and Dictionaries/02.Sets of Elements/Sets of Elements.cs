﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sets_of_Elements
{
    public class Program
    {
        public static void Main()
        {
            var setsSizes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var n = setsSizes[0];
            var m = setsSizes[1];

            var elementsN = new HashSet<int>();
            var commonElements = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                elementsN.Add(int.Parse(Console.ReadLine()));   
            }

            for (int i = 0; i < m; i++)
            {
                var newNumber = int.Parse(Console.ReadLine());
                if (elementsN.Contains(newNumber))
                {
                    commonElements.Add(newNumber);
                }
            }

            Console.WriteLine(string.Join(" ", commonElements));
        }
    }
}
