using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheSeason
{
    class GuessTheSeason
    {
        static void Main(string[] args)
        {
            // Write a program that display the name of the season associated with a date and month. Use the following table to determine a season's start and end date. For example, Autumn lasts from September 22 to December 20, both inclusive.
            // Season Start Date
            // Spring  March 20
            // Summer June 21
            // Autumn September 22
            // Winter December 21

            string month = Console.ReadLine();
            int day = int.Parse(Console.ReadLine());

            switch (month)
            {
                case "January":
                case "February":
                    Console.WriteLine("Winter");
                    break;
                case "March":
                    if (day < 20)
                    {
                        Console.WriteLine("Winter");
                    }
                    else
                    {
                        Console.WriteLine("Spring");
                    }
                    break;
                case "December":
                    if (day >= 21)
                    {
                        Console.WriteLine("Winter");
                    }
                    else
                    {
                        Console.WriteLine("Autumn");
                    }
                    break;
                case "April":
                case "May":
                    Console.WriteLine("Spring");
                    break;
                case "June":
                    if (day < 21)
                    {
                        Console.WriteLine("Spring");
                    }
                    else
                    {
                        Console.WriteLine("Summer");
                    }
                    break;
                case "July":
                case "August":
                case "September":
                    if (day < 22)
                    {
                        Console.WriteLine("Summer");
                    }
                    else
                    {
                        Console.WriteLine("Autumn");
                    }
                    break;
                case "October":
                case "November":
                    Console.WriteLine("Autumn");
                    break;
            }
        }
    }
}
