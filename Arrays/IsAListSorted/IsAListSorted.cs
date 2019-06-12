using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAListSorted
{
    class IsAListSorted
    {
        static void Main(string[] args)
        {
            // Write a program that checks if a list is already sorted. For a list to be sorted, the next element must NOT be smaller than the previous one.
            // There are N lines of output for each list you receive, print 'true' if sorted or 'false' otherwise.
            // 3
            // 1,2,3,4,5, 
            // 1,2,8,9,9
            // 1,2,2,3,2

            StringBuilder sb = new StringBuilder();
            // pesho, pesho +=  dimitrov - wrong
            // sb.appendLine("pesho")
            // sb.append(" dimitrov")

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                bool isValid = true;
                var input = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        isValid = false;
                        break;
                    }
                }

                sb.AppendLine(isValid.ToString().ToLower());
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
