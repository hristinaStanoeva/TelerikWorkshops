using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            // You need to provide conversion of the temperature given in Celsius to their Fahrenheit representation.
            // Celsius(°C) times 9 / 5 (1.8) plus 32

            string input = Console.ReadLine();
            string[] separate = input.Split(null);

            for (int i = 0; i < separate.Length; i++)
            {
                double result = (double.Parse(separate[i]) * 1.8) + 32;
                Console.WriteLine(Math.Round(result, 0));
            }

        }
    }
}
