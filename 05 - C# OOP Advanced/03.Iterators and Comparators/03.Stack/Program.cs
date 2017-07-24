namespace _03.Stack
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var myStack = new Stack<int>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "END")
            {
                var tokens = inputLine
                    .Split(new []{ ' ' , ','}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var command = tokens[0];
                tokens.Remove(command);

                switch (command)
                {
                    case "Push":
                        foreach (var token in tokens)
                        {
                            myStack.Push(int.Parse(token));
                        }
                        break;
                    case "Pop":
                        try
                        {
                            myStack.Pop();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var element in myStack)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
