
using System;
using System.Collections.Generic;
using System.Text;


namespace _07.Sum_Big_Numbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            var firstNumber = new Stack<char>(Console.ReadLine());
            var secondNumber = new Stack<char>(Console.ReadLine());

            var result = new StringBuilder();
            var residue = 0;
            while (firstNumber.Count > 0 || secondNumber.Count > 0)
            {
                var sum = residue;
                if (firstNumber.Count > 0) sum += (int) char.GetNumericValue(firstNumber.Pop());
                if (secondNumber.Count > 0) sum += (int) char.GetNumericValue(secondNumber.Pop());
                
                residue = sum / 10;
                result.Insert(0, sum % 10);
            }

            result.Insert(0, residue);

            Console.WriteLine(result.ToString().TrimStart('0'));
        }
    }
}
