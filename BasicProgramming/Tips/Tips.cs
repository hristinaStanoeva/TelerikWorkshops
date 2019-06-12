using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tips
{
    class Tips
    {
        static void Main(string[] args)
        {
            // You are at a restaurant and the waiter brings you the bill. You will have to calculate how much the tip must be.The tips are different in different countries, but here we will use 10 %.

            double bill = double.Parse(Console.ReadLine());
            double tip = bill * 0.1d;
            double all = bill + tip;
            Console.WriteLine("{0:0}", all);
        }
    }
}
