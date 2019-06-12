using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelowandAbovеAverage
{
    class BelowandAbovеAverage
    {
        static void Main(string[] args)
        {
            // Write a program that calculates the average of a list of numbers. Display the average, all the numbers below the average, and all the numbers above the average. Maintain the relative order of numbers.
            // avg: 0.89
            // below: -12,0,0,0,-2
            // above: 3,13,5,1

            var arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            double sum = arr.Sum();
            double avg = sum / arr.Length;
            List<int> belowAVG = new List<int>();
            List<int> aboveAVG = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > avg)
                {
                    aboveAVG.Add(arr[i]);
                }
                else if (arr[i] < avg)
                {
                    belowAVG.Add(arr[i]);
                }
            }

            Console.WriteLine($"avg: {avg:f2}");
            Console.WriteLine($"below: {string.Join(",", belowAVG)}");
            Console.WriteLine($"above: {string.Join(",", aboveAVG)}");
        }
    }
}
