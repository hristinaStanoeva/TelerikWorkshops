using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBill
{
    class PhoneBill
    {
        static void Main(string[] args)
        {
            //A phone bill plan includes 1 hour of free calls and 20 text messages for 12.00 levas.Each additional minute costs 0.10 levas and each additional message costs 0.06 levas.Also, the additional minutes / texts are subject to 20 % sales tax.Write a program that calculates the additional charge for text, the additional charge for minutes, and the sales tax charge for both.Also, display the total amount paid.

            int text = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int addtext = 0;
            int addmin = 0;

            if (text > 20)
            {
                addtext = text - 20;
            }

            if (min > 60)
            {
                addmin = min - 60;
            }

            Console.WriteLine("{0} additional messages for {1:0.00} levas", addtext, addtext * 0.06);
            Console.WriteLine("{0} additional minutes for {1:0.00} levas", addmin, addmin * 0.1);
            Console.WriteLine("{0:0.00} additional taxes", (((addtext * 0.06) + (addmin * 0.1)) * 0.2));
            Console.WriteLine("{0:0.00} total bill",(12+ (addtext * 0.06)+ (addmin * 0.1)+ (((addtext * 0.06) + (addmin * 0.1)) * 0.2)));
        }
    }
}
