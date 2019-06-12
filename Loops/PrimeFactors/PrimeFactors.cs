using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    class PrimeFactors
    {
        static void Main(string[] args)
        {
            // Write a program that finds the prime factors of a given non-prime number.List the factors in ascending order.
            // 12 = 2 2 3
            // 100 = 2 2 5 * 5

            int N = int.Parse(Console.ReadLine());

            for (int i = 2; i <= N; i++)
            {
                while (N % i == 0)
                {
                    N = N / i;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
