using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation2
{
    class Game
    {
        static void Main(string[] args)
        {
            // Three friends came up with a game for having fun in the break between the classes.One of them says a three-digit number and the others use it to form a mathematical expressions by using operators for sum and multiplication between the digits of that number. The winner is the first one who founds the biggest number that is a result of the above mentioned rules.
            // Write a program 'game', which prints out that biggest number.

            int N = int.Parse(Console.ReadLine());
            int firstDigit = N / 100;
            int secondDigit = (N / 10) % 10;
            int thirdDigit = N % 10;
            int maxResult = firstDigit * secondDigit * thirdDigit;

            if (maxResult < ((firstDigit * secondDigit) + thirdDigit))
            {
                maxResult = (firstDigit * secondDigit) + thirdDigit;
            }

            if (maxResult < (firstDigit + (secondDigit * thirdDigit)))
            {
                maxResult = firstDigit + (secondDigit * thirdDigit);
            }

            if (maxResult < firstDigit + secondDigit + thirdDigit)
            {
                maxResult = firstDigit + secondDigit + thirdDigit;
            }

            Console.WriteLine(maxResult);

        
        }
    }
}
