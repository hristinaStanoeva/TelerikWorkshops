using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortThreeNumbers
{
    class SortThreeNumbers
    {
        static void Main(string[] args)
        {
            // Write a program that enters 3 real numbers and prints them sorted in descending order.
            // Use nested if statements.
            // Don’t use arrays and the built-in sorting functionality.

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = a;
            int mid = b;
            int min = c;

            if (a >= b && a >= c)
            {
                max = a;
                if (b >= c)
                {
                    mid = b;
                    min = c;
                }
                else
                {
                    mid = c;
                    min = b;
                }
            }

            if (b >= a && b >= c)
            {
                max = b;
                if (a >= c)
                {
                    mid = a;
                    min = c;
                }
                else
                {
                    mid = c;
                    min = a;
                }
            }

            if (c >= a && c >= b)
            {
                max = c;
                if (b >= a)
                {
                    mid = b;
                    min = a;
                }
                else
                {
                    mid = a;
                    min = b;
                }
            }

            Console.WriteLine("{0} {1} {2}", max, mid, min);
        }
    }
}
