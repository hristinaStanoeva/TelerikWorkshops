using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Converter
    {
        static void Main(string[] args)
        {
            // You want to buy this really cool car from the UK, but you are worried about the fuel consumption.The values you see are MPG(miles per gallon). You have no idea what 20 MPG means so, being a programmer, decide to write a converter that helps you calculate the consumption.
            // Doing some research, you learn that 1 gallon = 4.54 litres and 1 mile = 1.6 km. After the calculation, round the result down to the neareast whole number.

            double mpg = double.Parse(Console.ReadLine());
            double kph = 100 / (mpg * (1.6 / 4.54));
            Console.WriteLine("{0} litres per 100 km", Math.Floor(kph));
        }
    }
}
