namespace _09.Linked_List_Traversal
{
    using System;

    public class Program
    {
        public static void Main()
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();

            int inputCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputCount; i++)
            {
                string[] commandTokens = Console.ReadLine().Split(' ');
                switch (commandTokens[0])
                {
                    case "Add":
                        myLinkedList.Add(int.Parse(commandTokens[1]));
                        break;
                    case "Remove":
                        myLinkedList.Remove(int.Parse(commandTokens[1]));
                        break;
                }
            }

            Console.WriteLine(myLinkedList.Count);
            Console.WriteLine(string.Join(" ", myLinkedList));
        }
    }
}
