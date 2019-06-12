using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAverage
{
    class FindAverage
    {
        static void Main(string[] args)
        {
            // You need to calculate the average of a collection of values.Every value will be valid number. The average must be printed with two digits after the decimal point.

            int N = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < N; i++)
            {
                sum += double.Parse(Console.ReadLine());
            }

            Console.WriteLine("{0:0.00}", sum / N);
        }
    }
}
