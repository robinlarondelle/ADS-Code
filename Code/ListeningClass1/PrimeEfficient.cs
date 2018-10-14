using System;

/*
 *  This is an improved algorithm to search for primes
 *  We all know even numbers can't be primes
 *  We also know all divisors cant be even, because all
 *  even numbers are just a multiple of 2
 *
 *  We know you can check for the prime of of a number by
 *  Dividing the number by its root. 17*19 = 19*17, so we
 *  don't want to double check that combination!
 *
 *  This is quite an improvement in time-management compared to the
 *  Inefficient prime-searcher, and it has a very efficient memory-management
 *
 *  Complexity: O(n^~1,4)
 *  Memory:     O(1) (constant)
 */

namespace C3_Listening_Class_1.ListeningClass1
{
    class PrimeEfficient
    {
        private static void Main(string[] args)
        {
            //Search every prime under 1.000.000
            int prime = 3;
            while (prime < 1000000)
            {
                Console.WriteLine("Is number {0} a prime? {1}", prime, IsPrime(prime));

                //We can add 2 to the number, because all evens are not a prime
                prime += 2;
            }

            Console.ReadLine();
        }

        private static bool IsPrime(int p)
        {
            int input = p;

            //Set the default divisor to 2
            int divisor = 3;

            //If the divisor is less than or equal to the given number's root
            //AND the number divided by the divisor don't produce a
            //whole number, the divisor will be +1
            while (divisor <= Math.Sqrt(input) && p % divisor != 0)
            {
                //We can add 2 to the divisor, because all even divisors will not lead
                //to a prime
                divisor += 2;
            }

            //If the divisor is equal to the number, the number is a prime
            if (divisor > Math.Sqrt(input))
            {
                return true;
            }

            return false;

        }
    }
}
