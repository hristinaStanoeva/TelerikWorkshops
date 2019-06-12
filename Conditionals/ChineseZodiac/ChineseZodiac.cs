using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChineseZodiac
{
    class ChineseZodiac
    {
        static void Main(string[] args)
        {
            // The Chinese zodiac assigns animals to years according to the following table:

            //    Year Animal      Year Animal
            //    2000    Dragon      2006    Dog
            //    2001    Snake       2007    Pig
            //    2002    Horse       2008    Rat
            //    2003    Sheep       2009    Ox
            //    2004    Monkey      2010    Tiger
            //    2005    Rooster     2011    Hare
            // Write a program that determines the zodiac sign for a particular year.Note that the cycle repeats itself, so 2012 will be the year of the Dragon again.
            // When year % 12:
            // Dragon - 8
            // Snake - 9
            // Horse - 10
            // Sheep - 11;
            // Monkey - 0;
            // Rooster - 1;
            // Dog - 2;
            // Pig - 3;
            // Rat - 4;
            // Ox - 5;
            // Tiger - 6;
            // Hare - 7;

            int year = int.Parse(Console.ReadLine());
            switch (year % 12)
            {
                case 0:
                    Console.WriteLine("Monkey");
                    break;
                case 1:
                    Console.WriteLine("Rooster");
                    break;
                case 2:
                    Console.WriteLine("Dog");
                    break;
                case 3:
                    Console.WriteLine("Pig");
                    break;
                case 4:
                    Console.WriteLine("Rat");
                    break;
                case 5:
                    Console.WriteLine("Ox");
                    break;
                case 6:
                    Console.WriteLine("Tiger");
                    break;
                case 7:
                    Console.WriteLine("Hare");
                    break;
                case 8:
                    Console.WriteLine("Dragon");
                    break;
                case 9:
                    Console.WriteLine("Snake");
                    break;
                case 10:
                    Console.WriteLine("Horse");
                    break;
                case 11:
                    Console.WriteLine("Sheep");
                    break;
            }
        }
    }
}
