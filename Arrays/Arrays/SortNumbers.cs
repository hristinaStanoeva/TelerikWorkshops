using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            // Write a program that reads a list of numbers separated by a comma and space.
            // Arrange the numbers in descending order.
            // Output all numbers on a single line, separated by a comma and a space.
            // 2, 1, 3, 5, 4
            // 5, 4, 3, 2, 1
            string input = Console.ReadLine();
            string[] split = { ", " };

            string[] stringAsNumbers = input.Split(split, StringSplitOptions.RemoveEmptyEntries);     // 1 2 3 4 5
            int[] numbers = Array.ConvertAll(stringAsNumbers, int.Parse);                             // parse string array into int

            int temp = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
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

            // First Solution
            // Console.WriteLine(string.Join(", ", Array.ConvertAll(Console.ReadLine().Split(), int.Parse).OrderByDescending(x => x)));

            // Second Solution
            // var n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
            // var numbers = Console.ReadLine().Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).OrderByDescending(x => x).ToArray();

            // help - Console.WriteLine($"{n:f0}");
            // help - Console.WriteLine($"{firstName}");
        }
    }
}
