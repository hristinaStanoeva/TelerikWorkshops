using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArr_Into_CharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string lettersAsString = "A,b,c,D,e,Z";

            var lettersArray = lettersAsString.Split(',').Select(char.Parse);

            foreach (var item in lettersArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
