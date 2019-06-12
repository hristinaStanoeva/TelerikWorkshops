using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateList
{
    class RotateList
    {
        static void Main(string[] args)
        {
            // Write a program that rotates a list several times(the first element becomes last).
            // list = 1,2,3,4,5 and N = 2 -> result = 3,4,5,1,2

            // Note that N could be larger than the length of the list.
            // list = 1,2,3,4,5 and N = 6 -> result = 2,3,4,5,1

            string input = Console.ReadLine();
            int N = int.Parse(Console.ReadLine());

            string[] separators = { ",", ", " };
            List<string> separatedNumbers = input.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            for (int i = 1; i <= N; i++)
            {
                separatedNumbers.Add(separatedNumbers[0]);
                separatedNumbers.RemoveAt(0);
            }

            for (int i = 0; i < separatedNumbers.Count; i++)
            {
                if (i == separatedNumbers.Count - 1)
                {
                    Console.WriteLine($"{separatedNumbers[i]}");
                }
                else
                {
                    Console.Write($"{separatedNumbers[i]},");
                }
            }
        }
    }
}
