using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Euler_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /// A palindromic number reads the same both ways. 
            /// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
            /// Find the largest palindrome made from the product of two 3 - digit numbers.

            /// c = a * b
            /// a = 100 t/m 999
            /// b = 100 t/m 999
            /// Begin van hoog naar laag
            /// verlaag a en b steeds totdat c == c reverse
            /// Sla op en vergelijk uitkomsten. Kies de hoogste.

            //int b = 999;
            int c;
            int cReversed;
            List<int> palindromes = new List<int>();

            for (int b = 999; b > 100; b--)
            {
                for (int i = 999; i > 100; i--)
                {
                    int a = i;
                    c = a * b;
                    cReversed = reverse(c);

                    if (c == cReversed)
                    {
                        palindromes.Add(cReversed);
                    }
                }
            }
            Console.WriteLine(palindromes.Max());


        }

        public static int reverse(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                rev = rev * 10 + x % 10;
                x = x / 10;
            }

            return rev;
        }

    }
}
