using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class From1toN
    {
        static void Main(string[] args)
        {
            // Write a program that enters from the console a positive integer n and prints all the numbers from 1 to N inclusive, on a single line, separated by a whitespace.

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i == N)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
