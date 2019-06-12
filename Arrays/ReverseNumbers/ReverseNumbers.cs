using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            // Write a program that reads a list of numbers separated by a comma and space. Reverse the numbers.
            // Output all numbers on a single line, separated by a comma and a space.
            // 2, 3, 1, 5, 6   ->   6, 5, 1, 3, 2

            string input = Console.ReadLine();
            string[] split = { ", " };

            string[] stringAsNumbers = input.Split(split, StringSplitOptions.RemoveEmptyEntries);     // 1 2 3 4 5
            int[] numbers = Array.ConvertAll(stringAsNumbers, int.Parse);                             // parse string array into int

            int temp;

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers.Length - 1)
                {
                    Console.WriteLine($"{numbers[i]}");
                }
                else
                {
                    Console.Write($"{numbers[i]}, ");
                }
            }
        }
    }
}
