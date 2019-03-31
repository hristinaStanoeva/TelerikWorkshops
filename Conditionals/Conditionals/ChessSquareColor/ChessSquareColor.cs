using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessSquareColor
{
    class ChessSquareColor
    {
        static void Main(string[] args)
        {
            // Write a program that determines the color of a chessboard square based on its rank and file
            // files have values from a to h
            // ranks have values from 1 to 8

            string error_invalidFile = "Invalid file";
            string error_invalidRank = "Invalid rank";

            char file = char.Parse(Console.ReadLine());
            if (file < 'a' || file > 'h')
            {
                throw new Exception(error_invalidFile);
            }

            char rank = char.Parse(Console.ReadLine());
            if (file < '1' || file > '8')
            {
                throw new Exception(error_invalidRank);
            }

            if (file % 2 == 1)
            {
                if (rank % 2 == 1)
                {
                    Console.WriteLine("dark");
                }
                else
                {
                    Console.WriteLine("light");
                }
            }
            else if (file % 2 == 0)
            {
                if (rank % 2 == 0)
                {
                    Console.WriteLine("dark");
                }
                else
                {
                    Console.WriteLine("light");
                }
            }
        }
    }
}
