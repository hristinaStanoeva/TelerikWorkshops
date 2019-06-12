using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class ArraySort
    {
        static void Main(string[] args)
        {
            //Given an array integers, write a program that moves all of the zeroes to the end of it, while maintaining the relative order of the non-zero elements.

            var arr = Console.ReadLine().Split(',').ToArray();
            int counter = 0;
            var list = new List<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]=="0")
                {
                    counter++;
                }
                else
                {
                    list.Add(arr[i]);
                }
            }

            for (int i = 0; i < counter; i++)
            {
                list.Add("0");
            }
            Console.WriteLine(string.Join(",",list));
        }
    }
}
