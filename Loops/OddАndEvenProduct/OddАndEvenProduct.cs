using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddАndEvenProduct
{
    class OddАndEvenProduct
    {
        static void Main(string[] args)
        {
            // You are given N integers(given in a N lines).
            // Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to N, so the first element is odd, the second is even, etc

            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int productOdd = 1;
            int productEven = 1;

            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    productOdd *= numbers[i];
                }
                else
                {
                    productEven *= numbers[i];
                }
            }

            if (productOdd == productEven)
            {
                Console.WriteLine("yes " + productOdd);
            }
            else
            {
                Console.WriteLine("no {0} {1}", productOdd, productEven);
            }
        }
    }
}
