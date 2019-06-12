using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLargestThreeValues
{
    class FindLargestThreeValues
    {
        static void Main(string[] args)
        {
            // Write a program that, that finds the three largest numbers in a sequence and prints them in descending order in the following format:
            // { largest}, { second_largest} and { third_largest}.

            int N = int.Parse(Console.ReadLine());
            int first = -500;
            int second = -500;
            int third = -500;
            int compare;

            for (int i = 0; i < N; i++)
            {
                compare = int.Parse(Console.ReadLine());

                if (compare > third)
                {
                    if (compare >= first)
                    {
                        third = second;
                        second = first;
                        first = compare;
                    }
                    else
                    {
                        if (compare >= second)
                        {
                            third = second;
                            second = compare;
                        }
                        else
                        {
                            third = compare;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("{0}, {1} and {2}", first, second, third);
        }
    }
}
