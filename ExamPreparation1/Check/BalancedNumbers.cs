using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    class BalancedNumbers
    {
        static void Main(string[] args)
        {
            // A balanced number is a 3-digit number whose second digit is equal to the sum of the first and last digit. Write a program which reads and sums balanced numbers.You should stop when an unbalanced number is given.

            int N = int.Parse(Console.ReadLine());
            int sum = 0;
           
            while (true)
            {
                if (((N / 100) + (N % 10)) == ((N / 10) % 10))
                {
                    sum += N;
                    N = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
