using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottleDeposit
{
    class BottleDeposit
    {
        static void Main(string[] args)
        {
            // When you buy something to drink you make a deposit for the bottle. Each bottle have a different deposit.Half liter bottles have $0.1 deposit and the one liter bottles have $0.25 deposit.Calculate the sum which you will make when returning the bottles.You must print two digits after the decimal point.

            int half = int.Parse(Console.ReadLine());
            int full = int.Parse(Console.ReadLine());
            double result = half * 0.1d + full * 0.25d;
            Console.WriteLine("{0:0.00}", result);
        }
    }
}
