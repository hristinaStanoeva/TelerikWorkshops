using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics
{
    class Arithmetics
    {
        static void Main(string[] args)
        {
            // Read two numbers from the console and calculate:
            //    The sum of a and b
            //    The difference when a is subtracted from b
            //    The product of a and b
            //    The remainder when a is divided by b
            //    The result of a powered to b

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a % b);
            Console.WriteLine(Math.Pow(a, b));
        }
    }
}
