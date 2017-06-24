using System;
using System.Text;

public class NMS
{
    public static void Main()
    {
        var message = new StringBuilder();

        string input;
        while ((input = Console.ReadLine()) != "---NMS SEND---")
            message.Append(input);
        var delimiter = Console.ReadLine();

        var output = new StringBuilder();
        output.Append(message[0]);
        for (int i = 1; i < message.Length; i++)
        {
            if (char.ToLower(message[i]) >= char.ToLower(message[i - 1]))
            {
                output.Append(message[i]);
            }
            else
            {
                output.Append(delimiter);
                output.Append(message[i]);
            }
        }

        Console.WriteLine(output);
    }
}