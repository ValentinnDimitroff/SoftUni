namespace _04.Generic_Swap_Method_Integer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var boxes = new List<Box<int>>();
            var numberOfStrings = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStrings; i++)
            {
                var currentString = int.Parse(Console.ReadLine());
                boxes.Add(new Box<int>(currentString));
            }

            var indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            SwapElements(boxes, indexes[0], indexes[1]);

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }

        public static void SwapElements<T>(List<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
