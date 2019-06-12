using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDeckOfCards
{
    class PrintDeckOfCards
    {
        static void Main(string[] args)
        {
            // Write a program that reads a card sign(as a string) from the console and generates and prints all possible cards from a standard deck of 52 cards up to the card with the given sign(without the jokers).The cards should be printed using the classical notation(like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
            // The card faces should start from 2 to A(10 is 10).
            // Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
            // The order of cards is '2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'.

            // FIRST SOLUTION:
            // string card = Console.ReadLine();
            // char[] order = new char[] { '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E' };

            //switch (card)
            //{
            //    case "10":
            //        card = "A";
            //        break;
            //    case "J":
            //        card = "B";
            //        break;
            //    case "Q":
            //        card = "C";
            //        break;
            //    case "K":
            //        card = "D";
            //        break;
            //    case "A":
            //        card = "E";
            //        break;
            //}

            //for (int i = 0; i < order.Length; i++)
            //{
            //    if (char.Parse(card) >= order[i])
            //    {
            //        switch (order[i])
            //        {
            //            case 'A':
            //                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 10);
            //                break;
            //            case 'B':
            //                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'J');
            //                break;
            //            case 'C':
            //                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'Q');
            //                break;
            //            case 'D':
            //                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'K');
            //                break;
            //            case 'E':
            //                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'A');
            //                break;
            //            default:
            //                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", order[i]);
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            // END SOLUTION

            // SECOND SOLUTION

            string card = Console.ReadLine();
            int a;

            if (int.TryParse(card, out a) == true && a <= 10)
            {
                for (int i = 2; i <= a; i++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
            }

            switch (char.Parse(card))
            {
                case 'J':
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'J');
                    break;
                case 'K':
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'K');
                    break;
                case 'Q':
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'Q');
                    break;
                case 'A':
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", 'A');
                    break;
            }
        }
    }
}
