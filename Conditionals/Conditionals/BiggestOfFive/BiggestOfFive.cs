using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOfFive
{
    class BiggestOfFive
    {
        static void Main(string[] args)
        {
            // Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            double max = a;

            if (max <= b)
            {
                max = b;
            }
            if (max <= c)
            {
                max = c;
            }
            if (max<=d)
            {
                max = d;
            }
            if (max<=e)
            {
                max = e;
            }

            Console.WriteLine(max);
        }
    }
}
