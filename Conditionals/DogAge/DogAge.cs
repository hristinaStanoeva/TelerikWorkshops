using System;

namespace Practice
{
    class DogAge
    {
        static void Main(string[] args)
        {
            //Most people believe that 1 human year(HY) equals 7 dog years(DY), however, dogs reach adulthood in approximately 2 human years.
            //So it's better to count the first two HY as 10 DY each and then count the remaining HY as 4 DY each.
            //Write a program that correctly converts human years(HY) to dog years(DY).You may need some form of conditional logic.

            int HY = int.Parse(Console.ReadLine());

            if (HY == 1)
            {
                Console.WriteLine("10");
            }
            else
            {
                if (HY == 2)
                {
                    Console.WriteLine("20");
                }
                else
                {
                    Console.WriteLine(20 + 4 * (HY - 2));
                }
            }
        }
    }
}