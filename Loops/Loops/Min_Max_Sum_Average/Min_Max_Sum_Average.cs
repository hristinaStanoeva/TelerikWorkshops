using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max_Sum_Average
{
    class Min_Max_Sum_Average
    {
        static void Main(string[] args)
        {
            // Write a program that reads from the console a sequence of N real numbers and returns the minimal, the maximal number, the sum and the average of all numbers(displayed with 2 digits after the decimal point).

            int N = int.Parse(Console.ReadLine());
            double min = double.MaxValue;
            double max = 0;
            double sum = 0;
            double avg;

            double work;

            for (int i = 0; i < N; i++)
            {
                work = double.Parse(Console.ReadLine());

                if (work > max)
                {
                    max = work;
                }

                if (work < min)
                {
                    min = work;
                }

                sum += work;
            }

            avg = sum / N;

            Console.WriteLine("min={0:0.00}",min);
            Console.WriteLine("max={0:0.00}", max);
            Console.WriteLine("sum={0:0.00}", sum);
            Console.WriteLine("avg={0:0.00}", avg);
        }
    }
}
