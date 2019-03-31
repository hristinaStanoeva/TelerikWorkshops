using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateChange
{
    class CalculateChange
    {
        static void Main(string[] args)
        {
            // Write a program that determines the least amount of coins needed for a cashier to return change. For  example, if the price of something is 0.76 leva and the customer has paid 1 leva, the least amount of coins is 1 x 20 stotinki and 2 x 2 stotinki.
            // Use coins of one lev, 50, 20, 10, 5, 2 and 1 stotinki.

            double check = double.Parse(Console.ReadLine());
            double paid = double.Parse(Console.ReadLine());
            
            int lev = 0;
            int fifty = 0;
            int twenty = 0;
            int ten = 0;
            int five = 0;
            int two = 0;
            int one = 0;

            //Console.WriteLine("diff is {0}", paid - check);

            int stotinki = Convert.ToInt32((paid - check) * 100);

            lev = stotinki / 100;
            stotinki = stotinki % 100;
            fifty = stotinki / 50;
            stotinki -= (fifty * 50);
            twenty = stotinki / 20;
            stotinki -= (twenty * 20);
            ten = stotinki / 10;
            stotinki -= ten * 10;
            five = stotinki / 5;
            stotinki -= five * 5;
            two = stotinki / 2;
            one = stotinki - two * 2;


            if (lev != 0)
            {
                Console.WriteLine("{0} x 1 lev",lev);
            }
            if (fifty != 0)
            {
                Console.WriteLine("{0} x 50 stotinki", fifty);
            }
            if (twenty != 0)
            {
                Console.WriteLine("{0} x 20 stotinki", twenty);
            }
            if (ten != 0)
            {
                Console.WriteLine("{0} x 10 stotinki", ten);
            }
            if (five != 0)
            {
                Console.WriteLine("{0} x 5 stotinki", five);
            }
            if (two != 0)
            {
                Console.WriteLine("{0} x 2 stotinki", two);
            }
            if (one != 0)
            {
                Console.WriteLine("{0} x 1 stotinka", one);
            }
        }
    }
}
