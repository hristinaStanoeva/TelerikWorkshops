using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloYou
{
    class HelloYou
    {
        static void Main(string[] args)
        {
            // Write a program that will read a name as input from the console and salute the person.

            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
