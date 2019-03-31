using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDiscount
{
    class CalculateDiscount
    {
        static void Main(string[] args)
        {
            // You need to calculate the discounted price for each item in your shopping cart.The discount is 65 %, a real deal for you.
            // On the first line, you will receive N - the number of the items in your shopping cart.

            // On the next N lines you will each item's price


            int N = int.Parse(Console.ReadLine());
            decimal[] price = new decimal[N];

            for (int i = 0; i < N; i++)
            {
                price[i] = decimal.Parse(Console.ReadLine());
            }

            foreach (decimal item in price)
            {
                Console.WriteLine("{0:0.00}", Math.Round((item * 0.35m), 2, MidpointRounding.AwayFromZero));
            }
        }
    }
}
