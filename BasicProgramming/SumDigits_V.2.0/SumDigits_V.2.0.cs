using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits_V._2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a four - digit number and displays the sum of its digits

            int N = int.Parse(Console.ReadLine());

            int one = N / 1000;
            int two = (N / 100) % 10;
            int three = (N / 10) % 10;
            int four = N % 10;

            Console.WriteLine(one + two + three + four);
        }
    }
}
