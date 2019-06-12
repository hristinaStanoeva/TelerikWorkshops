using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumValue
{
    class FindMaximumValue
    {
        static void Main(string[] args)
        {
            // Write a program that finds the maximum number from a given sequence.

            int N = int.Parse(Console.ReadLine());
            int max = -200;
            int compare;

            for (int i = 0; i < N; i++)
            {
                compare = int.Parse(Console.ReadLine());
                if (compare >= max)
                {
                    max = compare;
                }
            }

            Console.WriteLine(max);
        }
    }
}
