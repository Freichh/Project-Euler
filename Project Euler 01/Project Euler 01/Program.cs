using System;

namespace Project_Euler_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // If we list all the natural numbers below 10 that are multiples of 3 or 5, 
            // we get 3, 5, 6 and 9.The sum of these multiples is 23.
            // Find the sum of all the multiples of 3 or 5 below 1000.

            /*
             * Ga alle getallen tot 1000 af en stop dan.
             * Zijn ze deelbaar door 3 of 5 sla ze dan op.
             * Anders negeer ze.
             * Laat de totaalsom zien wanneer klaar met doorlopen.
             */

            decimal totalNumber = 0;

            for (decimal myDecimal = 0; myDecimal < 1000; myDecimal++)
            {

                if (myDecimal % 3 == 0 || myDecimal % 5 == 0)
                {
                    Console.WriteLine("Ok: ", totalNumber += myDecimal);
                }
                else
                    Console.WriteLine("Nope...");
            }
            Console.WriteLine(totalNumber);
            Console.ReadLine();
       
        }
    }
}
