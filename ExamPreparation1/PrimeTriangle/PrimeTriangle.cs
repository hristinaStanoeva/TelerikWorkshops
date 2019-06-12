using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTriangle
{
    class PrimeTriangle
    {
        static void Main(string[] args)
        {
            // By a given N number, from which you need to generate a sequence of 1 to N inclusive.For every prime number in that sequence, you need to print out all the other numbers before it(and the number itself), whether they are prime or not

            //Example: Let's say N=10
            //We have the sequence 1, 2, 3, 4, 5, 6, 7, 8, 9, 10   -   The prime numbers are 1, 2, 3, 5, 7 - 5 prime numbers, so we prive 5 rows
            //Each row contains all the numbers for 1 to PRIME_NUMBER
            //Result:
            // 1
            // 1 2
            // 1 2 3
            // 1 2 3 4 5
            // 1 2 3 4 5 6 7

            //Print 0 if the numbers is not prime - Print 1 if the number is prime
            //Final result:
            // 1
            // 1 1
            // 1 1 1
            // 1 1 1 0 1
            // 1 1 1 0 1 0 1

            int N = int.Parse(Console.ReadLine());
            List<int> primeNumbers = new List<int>() { 1 };

            for (int i = 2; i <= N; i++)
            {
                bool isPrime = true;
                
                    for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeNumbers.Add(i);
                }
            }

            foreach (var item in primeNumbers)
            {
                for (int i = 1; i <= item; i++)
                {
                    if (primeNumbers.Contains(i))
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
