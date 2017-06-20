using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class CubicMessages
{
    public static void Main()
    {
        string inputMessage; 
        while ((inputMessage = Console.ReadLine()) != "Over!")
        {
            var messageLenght = int.Parse(Console.ReadLine());
            var match = Regex.Match(inputMessage, @"(^[\d]+)([a-zA-Z]+)([^a-zA-Z]*$)");

            if (match.Groups.Count < 2)
                continue;
            var prefix = match.Groups[1].Value;
            var message = match.Groups[2].Value;
            string ending = String.Empty;
            if (match.Groups.Count > 2)
            {
                ending = match.Groups[3].Value;
            }

            if (message.Length != messageLenght)
                continue;

            var verificationEncrypted = Regex.Replace(string.Concat(prefix + ending), @"[^\d]*", String.Empty);
            var verificationCode = new StringBuilder();
            foreach (var element in verificationEncrypted)
            {
                var index = int.Parse(element.ToString());
                if (index >= 0 && index < messageLenght)
                {
                    verificationCode.Append(message[index]);
                }
                else
                {
                    verificationCode.Append(" ");
                }
            }

            Console.WriteLine(message + " == " + verificationCode);
        }
    }
}