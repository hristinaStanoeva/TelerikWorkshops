using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation1
{
    class CrookedDigit
    {
        static void Main(string[] args)
        {
            // The crooked digit of a given number N is calculated using the number's digits in a very weird and bendy algorithm. The algorithm takes the following steps:
            // 1. Sums the digits of the number N and stores the result back in N.
            // 2. If the obtained result is bigger than 9, step 1. is repeated, otherwise the algorithm finishes.
            // The last obtained value of N is the result, calculated by the algorithm.

            double N = 0;
            // double N = double.Parse(Console.ReadLine());
            var arr = Console.ReadLine().ToString().ToCharArray().ToList();

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == '-' || arr[i] == '.')
                {
                    arr.Remove(arr[i]);
                }

                N += int.Parse(arr[i].ToString());
            }

            while (N > 9)
            {
                var calculationArr = N.ToString().ToCharArray();
                N = 0;
                for (int i = 0; i < calculationArr.Length; i++)
                {
                    N += int.Parse(calculationArr[i].ToString());
                }
            }

            Console.WriteLine(N);


            // Best Solution

            //string inputNumber = Console.ReadLine();
            //int sum = 0;

            //while (true)
            //{
            //    for (int i = 0; i < inputNumber.Length; i++)
            //    {
            //        char ch = inputNumber[i];
            //        if (!(ch == '.' || ch == '-'))
            //        {
            //            sum += (ch - '0');
            //        }
            //    }
            //    if (sum < 10)
            //    {
            //        break;
            //    }
            //    inputNumber = sum.ToString();
            //    sum = 0;
            //}
            //Console.WriteLine(sum);
        }
    }
}