using System;
using System.Security.Cryptography.X509Certificates;

namespace Project_Euler_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ?

            // Begin vanaf x = 2522. 
            // Alleen even getallen
            // Check eerst of mod 20 == 0;
            // Loop modulus 1 t/m 20
            // Flag false als x % != 0 en stop, of ga verder als niet 0
            // Als loop klaar is en flag true, sla op en eindig

            int x = 20;
            int result;
            bool y = true;


            for (int i = 20; i > 1; i--)
            {
                result = x % i;

                if (result != 0)
                {
                    x = x + 20;
                    i = 21;
                }

            }
            Console.WriteLine("!!!!!! x =  " + x);



        }
    }
}
