using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingSquashing
{
    class MergingSquashing
    {
        static void Main(string[] args)
        {
            // We have the following operations defined for two - digit numbers.There are two possible ways of merging them:

            // Merging ab and cd produces bc - 42 merged with 17 produces 21
            // Squashing ab and cd produces a(b + c)d - 39 squashed with 57 produces 347(9 + 5 = 14, we use only the 4)
            // Input: You have a sequence of N two - digit numbers.Your task is to merge and squash each pair of adjacent numbers.
            // Output: On the first output line print the merged numbers; On the second output line print the squashed numbers (Separate them by spaces)

            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int[] mergedNumbers = new int[N - 1];
            int[] squashedNumbers = new int[N - 1];

            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if (i > 0)
                {
                    mergedNumbers[i - 1] = ((numbers[i - 1] % 10) * 10) + (numbers[i] / 10);
                    squashedNumbers[i - 1] = ((numbers[i - 1] / 10) * 100) + ((((numbers[i - 1] % 10) + (numbers[i] / 10)) % 10) * 10) + (numbers[i] % 10);
                }
            }

            Console.WriteLine(string.Join(" ",mergedNumbers));
            Console.WriteLine(string.Join(" ", squashedNumbers));
        }
    }
}







