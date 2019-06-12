using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interest
{
    class Interest
    {
        static void Main(string[] args)
        {
            // You have deposited a sum into your bank account for 3 years.The bank has announced an interest of 5 % per year.Each time the interest is calculated and added to your deposit.You have to calculate the amount in your deposit for each year.

            double vlog = double.Parse(Console.ReadLine());
            double after1 = vlog + 0.05d * vlog;
            double after2 = after1 + 0.05d * after1;
            double after3 = after2 + 0.05d * after2;
            Console.WriteLine("{0:0.00}", after1);
            Console.WriteLine("{0:0.00}", after2);
            Console.WriteLine("{0:0.00}", after3);
        }
    }
}
