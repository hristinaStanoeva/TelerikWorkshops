using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class RemoveDuplicates
    {
        static void Main(string[] args)
        {

            //var arr = Console.ReadLine().Split(',').Distinct().ToArray();
            //Console.WriteLine(string.Join(",",arr));

            var arr = Console.ReadLine().Split(',').ToArray();
            var numbers = new List<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (!numbers.Contains(arr[i]))
                {
                    numbers.Add(arr[i]);
                }
            }
            Console.WriteLine(string.Join(",",numbers));
        }
    }
}
