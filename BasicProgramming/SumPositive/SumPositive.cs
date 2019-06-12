using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPositive
{
    class SumPositive
    {
        static void Main(string[] args)
        {
            // Write a program that reads a positive integer(n) You must print the sum of all integers from 1 to n.

            int n = int.Parse(Console.ReadLine());
            int sum = n * (n + 1) / 2;
            Console.WriteLine(sum);
        }
    }
}
