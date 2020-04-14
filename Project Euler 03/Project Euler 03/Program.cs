using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Project_Euler_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // The prime factors of 13195 are 5, 7, 13 and 29.
            // What is the largest prime factor of the number 600851475143 ?
            /*
            Neem bijvoorbeeld het getal 120. Dit getal deel je steeds door het kleinst mogelijke priemgetal, totdat je 1 overhoudt.
            120 : 2 = 60
            60 : 2 = 30
            30 : 2 = 15
            15 : 3 = 5(15 kun je niet delen door 2, dus gebruik je vanaf hier het eerstvolgende priemgetal, namelijk 3)
            5 : 5 = 1(5 kun je niet delen door 3, dus gebruik je vanaf hier het eerstvolgende priemgetal, namelijk 5)
            Als je het getal 1 overhoudt, dan ben je klaar.
            Alle priemgetallen die je gebruikt hebt voor de delingen zijn de priemfactoren.
            In dit geval dus 2 · 2 · 2 · 3 · 5 = 120
            */

            long quizNumber = 600851475143;
            List<int> primeFactors = new List<int>();
            List<int> primeNumbers = GeneratePrimesNaive(1000);

            for (int i = 0; quizNumber > 1;)
            {
                if (quizNumber % primeNumbers[i] == 0)
                {
                    Debug.WriteLine("quiznumber " + quizNumber);
                    Debug.WriteLine("primeNumbers " + primeNumbers[i]);
                    quizNumber = quizNumber / primeNumbers[i];
                    primeFactors.Add(primeNumbers[i]);
                }
                else
                {
                    i++;
                }
            }

            foreach (var factor in primeFactors)
            {
                Debug.WriteLine(factor);
            }


        }

        // Prime generator from: https://stackoverflow.com/questions/1042902/most-elegant-way-to-generate-prime-numbers/1072205#1072205
        public static List<int> GeneratePrimesNaive(int n)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int nextPrime = 3;
            while (primes.Count < n)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; (int)primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }
            return primes;

        }
    }
}
