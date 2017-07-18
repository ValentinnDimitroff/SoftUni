namespace _04.Telephony
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var smartPhone = new Smartphone();
            var phoneNumbers = Console.ReadLine().Split(' ');
            var webSites = Console.ReadLine().Split(' ');

            foreach (var phoneNumber in phoneNumbers)
            {
                var result = smartPhone.Call(phoneNumber);
                Console.WriteLine(result);
            }

            foreach (var webSite in webSites)
            {
                var result = smartPhone.Browse(webSite);
                Console.WriteLine(result);
            }
        }
    }
}
