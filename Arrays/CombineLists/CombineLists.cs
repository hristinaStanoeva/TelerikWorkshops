using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombineLists
{
    class CombineLists
    {
        static void Main(string[] args)
        {
            // Write a program that reads two lists of numbers and combines them by alternatingly taking elements:

            // combine 1,2,3 and 7,8,9-> 1,7,2,8,3,9
            // you can assume that the input lists will have the same length.
            // Print the resulting combined list to the output, separating elements with a comma.

            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            string[] separators = { ",", ", " };

            string[] firstLineSeparate = firstLine.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] secondLineSeparate = secondLine.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[] firstLineNumbers = Array.ConvertAll(firstLineSeparate, int.Parse);
            int[] secondLineNumbers = Array.ConvertAll(secondLineSeparate, int.Parse);

            for (int i = 0; i < firstLineNumbers.Length; i++)
            {
                if (i == firstLineNumbers.Length - 1)
                {
                    Console.Write($"{firstLineNumbers[i]},");
                    Console.WriteLine($"{secondLineNumbers[i]}");
                }
                else
                {
                    Console.Write($"{firstLineNumbers[i]},");
                    Console.Write($"{secondLineNumbers[i]},");
                }
            }

        }
    }
}
