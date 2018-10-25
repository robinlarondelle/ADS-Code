using System;

/*
 *  This is an inefficient way to calculate if a number is a prime
 *  It checks if a number is dividable with a number
 *  If it's not, it will +1 the divisor, until it is dividable
 *
 *  A number is a prime if it is dividable between itself and 1
 *
 *  This code searches every prime under 1000000.
 *  We have a while loop in a while loop.
 *  This means for every n we search, the nested while loop has to
 *  loop n times, or n^2 times
 *
 *  This is a very time consuming algorithm, but its memory-usage is very
 *  constant.
 *
 *  Complexity: O(n^~1,9)
 *  Time:       O(1) (constant)
 */
 
namespace ADS.ListeningClass
{
    class PrimeInefficient
    {
        public void Run()
        {
            //Search every prime under 1.000.000
            int prime = 2;
            while (prime < 1000000)
            {
                Console.WriteLine("Is number {0} a prime? {1}", prime , IsPrime(prime));
                prime++;
            }

            
        }

        private bool IsPrime(int p)
        {
            int input = p;

            //Set the default divisor to 2
            int divisor = 2;

            //If the divisor is less than the given number
            //AND the number divided by the divisor don't produce a
            //whole number, the divisor will be +1
            while (divisor < p && p % divisor != 0)
            {
                divisor++;
            }

            //If the divisor is equal to the number, the number is a prime
            if (divisor == p)
            {
                return true;
            }

            return false;
            
        }
    }
}
