using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays

            string numbersAsString = "1,2,6,5,8,9,1,2";
            string lettersAsString = "A,b,c,D,e,Z";

            var numbers = Array.ConvertAll(numbersAsString.Split(','), int.Parse);   //convert string into numbers
            var letters = numbersAsString.Split(',').ToArray();    // ????

            string arrAsWord = letters.ToString();
            var lettersAsChars = arrAsWord.ToCharArray();

            Console.WriteLine(string.Join(",", lettersAsChars));


            Console.WriteLine(string.Join(",", numbers));    // разделяне със запетая

            Console.WriteLine($"{numbers[1]}");   // интерполация

            Array.Sort(numbers);  //сортира масива във възходящ ред

            Array.Reverse(numbers);  // обръща масива наобратно от последния елемент до първия

            var numbersDistinct = numbers.Distinct(); // връща само уникалните елементи

            var result = numbers.Contains(7); // търси само числа, връща булев резултат

            //  var findChar = Array.Find(letters, x => x == 'A'); // използване на предикат(predicate), търси в елементите на масива, за числа и символи(???????)
            var findEven = Array.Find(numbers, x => x % 2 == 0);

            Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine(string.Join(",", numbersDistinct));
            //  Console.WriteLine(findChar);

            // Lists

            var listNumbers = new List<int>() { 1, 3, 4, 5, 6, 7, 8 };
            var hundreds = new List<int>() { 100, 300, 400, 100 };

            listNumbers.Add(8);  // добавя накрая елемент
            listNumbers.Insert(0, 8); // добавя в началото елемент
            listNumbers.Insert(5, 8); // вмъква елемент на определено място
            listNumbers.Sort();  //сортира във възходящ ред
            listNumbers.AddRange(hundreds); // добавя друг списък накрая

            Console.WriteLine(string.Join(",", listNumbers));

            // Methods for use in the exam
            // Sort
            // Reverse
            // Find
            // FindAll
            // using System.Collections.Generic - review this documentation

        }
    }
}
