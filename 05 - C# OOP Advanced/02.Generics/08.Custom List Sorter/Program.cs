namespace _08.Custom_List_Sorter
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var myCustomList = new CustomList<string>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                var args = inputLine.Split(' ');

                switch (args[0])
                {
                    case "Add":
                        myCustomList.Add(args[1]);
                        break;
                    case "Remove":
                        myCustomList.Remove(int.Parse(args[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(myCustomList.Contains(args[1]));
                        break;
                    case "Swap":
                        myCustomList.Swap(int.Parse(args[1]), int.Parse(args[2]));
                        break;
                    case "Greater":
                        int count = myCustomList.CountGreaterThan(args[1]);
                        Console.WriteLine(count);
                        break;
                    case "Max":
                        Console.WriteLine(myCustomList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(myCustomList.Min());
                        break;
                    case "Print":
                        foreach (var element in myCustomList)
                        {
                            Console.WriteLine(element);
                        }
                        break;
                    case "Sort":
                        myCustomList = Sorter.Sort(myCustomList);
                        break;
                }
            }
        }
    }
}
