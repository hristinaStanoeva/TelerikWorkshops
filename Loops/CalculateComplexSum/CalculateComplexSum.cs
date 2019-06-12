using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateComplexSum
{
    class CalculateComplexSum
    {
        static void Main(string[] args)
        {
            // Write a program that, for a given two numbers N and x, calculates the sum below.

            // S = 1 + (1!/x) + (2!/x^2) + ⋯ + (N!/x^N)
            // Use only one loop. Print the result with 5 digits after the decimal point.

            int N = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double S = 1;
            double factoriel = 1;
            double stepen = 1;

            for (int i = 1; i <= N; i++)
            {
                factoriel *= i;
                stepen *= x;
                S += factoriel / stepen;
            }

            Console.WriteLine("{0:0.00000}", S);
        }
    }
}
