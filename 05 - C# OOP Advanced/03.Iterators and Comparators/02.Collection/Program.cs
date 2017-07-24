namespace _02.Collection
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var inputCommand = Console.ReadLine();
            var listyIterator = new ListyIterator<string>(inputCommand.Split(' ').Skip(1));

            while ((inputCommand = Console.ReadLine()).ToLower() != "end")
            {
                var tokens = inputCommand.Split(' ');

                switch (tokens[0])
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "PrintAll":
                        Console.WriteLine(string.Join(" ", listyIterator));
                        //foreach (var element in listyIterator)
                        //{
                        //    Console.Write($"{element} ");
                        //}
                        //Console.WriteLine();
                        break;
                }
            }
        }
    }
}
