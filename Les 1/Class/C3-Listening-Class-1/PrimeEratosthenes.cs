using System;

/*
 *  This example shows the algorithm of Eratosthenes
 *
 *  If a number x is dividable by 3, we know it is dividable by
 *  6, 9, 12 etc. Knowing this, we don't have to loop with a multiple.
 *
 *  We check every number under the root of the limit for its multiples
 *  We write these multiples down, and write the base number down as a prime
 *  This way, we dont have to check the multiples, and only check the prime numbers
 *
 *  This algoritm is very efficient in time, but very consuming in memory
 *  If you were to make this problem n times bigger, the memory-usages gets n times bigger
 *
 *  Complexity: O(n)
 *  Memory:     O(n)
 */

namespace C3_Listening_Class_1
{
    class PrimeEratosthenes
    {
        private static void Main(string[] args)
        {
            int MAX = 1000000000;

            //This is the array in which the booleans (prime or not) are stored
            bool[] divisorFound = new bool[MAX];

            //We begin with num = 2, because 0 and 1 dont have multiples and are not primes
            for (int num = 2; num < Math.Sqrt(MAX); num++)
            {
                //Check if the boolean at position num in the array is false
                //If it is false, it means it is ap prime number.
                // Every multiple of a prime number, is automatically not a prime
                if (!divisorFound[num])
                {
                    //Mark every multiple of a prime true, as it will never be a prime
                    //The array wont handle a multiple, so that makes this algorithm very efficient
                    for (int multiple = num + num; multiple < MAX; multiple += num)
                    {
                        divisorFound[multiple] = true;
                    }
                }
            }

            //The array is complete and filled with data. Now we check every value in the array
            //If a value is true, it is not a prime, if it is false (which means it has no multiple
            //other than 1 and itself) it is a prime!
            for (int num = 2; num < MAX; num++)
            {
                if (!divisorFound[num])
                {
                    Console.WriteLine("Number {0} is a prime!", num);
                }
            }

            Console.ReadLine();
        }
    }
}
