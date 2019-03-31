using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            // Write a program that reads a four - digit number and displays the sum of its digits

            string N = Console.ReadLine();
            Console.WriteLine((int)char.GetNumericValue(N[0]) + (int)char.GetNumericValue(N[1]) + (int)char.GetNumericValue(N[2]) + (int)char.GetNumericValue(N[3]));
        }
    }
}
