using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySearch
{
    class ArraySearch
    {
        static void Main(string[] args)
        {
            // Given an array of integers, some elements appear twice and others appear once. Each integer is in the range of[1, N], where N is the number of elements in the array.
            // Find all the integers of[1, N] inclusive that do NOT appear in this array.

            var arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            List<int> missingNumbers = new List<int>();

            for (int i = 1; i <= arr.Length; i++)
            {
                bool check = false;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == i)
                    {
                        check = true;
                    }
                }

                if (!check)
                {
                    missingNumbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(",",missingNumbers));
        }
    }
}
