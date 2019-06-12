using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspichanNumbers
{
    class KaspichanNumbers
    {
        static void Main(string[] args)
        {
            // In Kaspichan we have a special way to write numbers. We use the following 256 digits:

            // 0   A       26  aA      52  bA  ... 234 iA
            // 1   B       27  aB      53  bB      235 iB
            // …	…		…	…		…	…		…	…
            // 25  Z       51  aZ      77  bZ      255 iV
            //We write the numbers as sequences of digits. The last digit of the number(the most right one) has a value as shown in the above table.The next digit on the left has a value 256 times bigger than the shown in the above table, the next digit on the left has 256 * 256 times bigger value than the shown in the table and so on.Your task is to write a program to convert a decimal number into its corresponding representation in Kaspichan.

            // a-z = [97-122]
            // A-Z = [65-90]

            ulong N = ulong.Parse(Console.ReadLine());
            string[] KaspichanTable = new string[256];

            for (int i = 0; i < KaspichanTable.Length; i++)
            {
                switch (i / 26)
                {
                    case 0:
                        KaspichanTable[i] = Convert.ToChar(65 + i).ToString();
                        break;
                    case 1:
                        KaspichanTable[i] = "a" + Convert.ToChar(65 + (i % 26)).ToString();
                        break;
                    case 2:
                        KaspichanTable[i] = "b" + Convert.ToChar(65 + (i % 26)).ToString();
                        break;
                    case 3:
                        KaspichanTable[i] = "c" + Convert.ToChar(65 + (i % 26)).ToString();
                        break;
                    case 4:
                        KaspichanTable[i] = "d" + Convert.ToChar(65 + (i % 26)).ToString();
                        break;
                    case 5:
                        KaspichanTable[i] = "e" + Convert.ToChar(65 + (i % 26)).ToString();
                        break;
                    case 6:
                        KaspichanTable[i] = "f" + Convert.ToChar(65 + (i % 26)).ToString();
                        break;
                    case 7:
                        KaspichanTable[i] = "g" + Convert.ToChar(65 + (i % 26)).ToString();
                        break;
                    case 8:
                        KaspichanTable[i] = "h" + Convert.ToChar(65 + (i % 26)).ToString();
                        break;
                    case 9:
                        KaspichanTable[i] = "i" + Convert.ToChar(65 + (i % 26)).ToString();
                        break;
                    default:
                        break;
                }
            }

            List<string> newNumber = new List<string>();

            if (N < 256)
            {
                Console.Write(KaspichanTable[N]);
            }
            else
            {
                while ((N / 256) != 0)
                {
                    newNumber.Add(KaspichanTable[N % 256]);
                    N = N / 256;

                    if (N<256)
                    {
                        newNumber.Add(KaspichanTable[N]);
                        break;
                    }
                }
            }

            newNumber.Reverse();

            foreach (var item in newNumber)
            {
                Console.Write(item);
            }

            Console.Write("\n");
        }
    }
}
