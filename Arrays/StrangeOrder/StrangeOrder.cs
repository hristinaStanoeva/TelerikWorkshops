using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeOrder
{
    class StrangeOrder
    {
        static void Main(string[] args)
        {
            // Write a program that orders a list of numbers in the following way:
            // 3,-2,1,0,-1,0,-2,1-> - 2,-1,-2,0,0,3,1,1
            // the negative, the zeros, the positives in the same order

            var arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();   // read > split > parse into int
            List<int> negative = new List<int>();
            List<int> zero = new List<int>();
            List<int> positive = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    negative.Add(arr[i]);
                }
                else if (arr[i] == 0)
                {
                    zero.Add(arr[i]);
                }
                else
                {
                    positive.Add(arr[i]);
                }
            }

            var allNumbersSorted = new List<int>(negative.Count + zero.Count + positive.Count);
            allNumbersSorted.AddRange(negative);
            allNumbersSorted.AddRange(zero);
            allNumbersSorted.AddRange(positive);

            Console.WriteLine(string.Join(",", allNumbersSorted));
        }
    }
}
