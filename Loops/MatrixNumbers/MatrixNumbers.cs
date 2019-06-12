using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixNumbers
{
    class MatrixNumbers
    {
        static void Main(string[] args)
        {
            // Write a program that reads from the console a positive integer number N and prints a matrix like in the examples below.Use two nested loops.
            // 1 2 3
            // 2 3 4
            // 3 4 5

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int j = i; j <= (i + N - 1); j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}
