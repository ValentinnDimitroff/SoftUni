using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Program
{
    public static void Main()
    {
        Spy spy = new Spy();
        string result = spy.CollectGettersAndSetters("Hacker");
        Console.WriteLine(result);
    }
}