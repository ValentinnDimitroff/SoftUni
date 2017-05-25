using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.Matrix_Of_Palindromes
{
    public class MatrixPalindromes
    {
        public static void Main()
        {
            var dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];

            var palindromes = new string[rows][];
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int row = 0; row < rows; row++)
            {
                palindromes[row] = new string[cols];

                for (int col = 0; col < cols; col++)
                {
                    var palindrome = new StringBuilder();
                    palindrome.Append(alphabet[row]);
                    palindrome.Append(alphabet[col + row]);
                    palindrome.Append(alphabet[row]);
                    palindromes[row][col] = palindrome.ToString();
                }
            }

            PrintJaggedArray(palindromes);            
        }

        private static void PrintJaggedArray(string[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));
            }
        }
    }
}
