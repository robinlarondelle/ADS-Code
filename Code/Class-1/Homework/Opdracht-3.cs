using System;
using System.Diagnostics;

/*
 *  1. Verbeter het inefficiente algoritme
 *  2. Geef van beide algoritmen de geheugen- en rekencomplexiteit
 *  3. Welke algemene regel kun je hier uit afleiden?
 */
namespace ADS.Homework
{
    class Opdracht3
    {
        public void Run()
        {
            int n = 1000000;

            Console.WriteLine("The time it took to calculate with the inefficient algorithm: {0}, with n = {1}", MathInefficient(n), n);
            Console.WriteLine("The time it took to calculate with the improved algorithm: {0}, with n = {1}", MathImproved(n), n);

            n *= 2;
            Console.WriteLine("\nNow with double n: {0}\n", n);

            Console.WriteLine("The time it took to calculate with the inefficient algorithm: {0}, with n = {1}", MathInefficient(n), n);
            Console.WriteLine("The time it took to calculate with the improved algorithm: {0}, with n = {1}", MathImproved(n), n);

            n *= 2;
            Console.WriteLine("\nNow with double n: {0}\n", n);

            Console.WriteLine("The time it took to calculate with the inefficient algorithm: {0}, with n = {1}", MathInefficient(n), n);
            Console.WriteLine("The time it took to calculate with the improved algorithm: {0}, with n = {1}", MathImproved(n), n);

            n *= 2;
            Console.WriteLine("\nNow with double n: {0}\n", n);

            Console.WriteLine("The time it took to calculate with the inefficient algorithm: {0}, with n = {1}", MathInefficient(n), n);
            Console.WriteLine("The time it took to calculate with the improved algorithm: {0}, with n = {1}", MathImproved(n), n);

            
        }

        /*
         *  This is the example algorithm straight from the assignment.
         *  It calculates 50 times the sum Math.Pow(x, x). It is a defined number, so constant complexity:
         *  time-complexity O(1)
         *
         *  The second loop depends on n, so it has the following complexity:
         *  time-complexity: O(n)
         *
         *  Total complexity of this algorithm:
         *  time-complexity: O(n)
         *
         *  If n becomes really big, the amount of memory used, doesnt become any bigger
         *  memory-complexity: O(1)
         */
        private double MathInefficient(int n)
        {
            double sum = 0;
            double exponential = 0;

            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < 50; i++)
            {
                exponential += Math.Pow(65536, 256);
            }

            for (int i = 0; i < n; i++)
            {
                sum += exponential;
            }
            stopwatch.Stop();

            return stopwatch.ElapsedTicks;
//            return sum;
        }


        /*
         *  This is an improved version of the MathInefficient algorithm
         *  Because the first loop in the inefficient algorithm runs 50 times, no matter what
         *  we can define the value of 50 times Math.Pow(x,x) in a variable. This removes 1 for-loop
         *
         *  We can apply the same mechanism for the second loop, by multiplying the exponential times n
         *  This removes the second for-loop, and prevents the check i < n
         *
         *  We can improve this even more by removing the exponential variable, by doing the calculation
         *  of 50*Math... together with the n * exponential calculation
         *
         *  This algorithm has a constant complexity, because it will make the calculation of n * exponential only once
         *  time-complexity: O(1)
         *
         *  If n becomes really big, the amount of memory used, doesnt become any bigger
         *  memory-complexity: O(1) 
         */
        private double MathImproved(int n)
        {
            double sum = 0;

            Stopwatch stopwatch = Stopwatch.StartNew();
            sum = n * (50 * Math.Pow(65536, 256));
            stopwatch.Stop();

            return stopwatch.ElapsedTicks;
//            return sum;
        }
    }
}
