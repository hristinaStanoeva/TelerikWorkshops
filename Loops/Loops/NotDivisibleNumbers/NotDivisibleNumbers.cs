using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDivisibleNumbers
{
    class NotDivisibleNumbers
    {
        static void Main(string[] args)
        {
            // Write a program that reads from the console a positive integer N and  prints all the numbers from 1 to N not divisible by 3 or 7, on a single line, separated by a space.

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                else
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
}
