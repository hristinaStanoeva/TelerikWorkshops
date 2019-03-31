using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Time
    {
        static void Main(string[] args)
        {
            // Write a program that reads days, hours, minutes and seconds from thestandard input.Display the total amount of seconds.

            int day = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine(second + minute * 60 + hour * 3600 + day * 24 * 3600);
        }
    }
}
