/*
 *  Wat is de rekencomplexiteit van beide methodes?
 */

using System;
using System.Diagnostics;

namespace ADS.Homework
{
    class Opdracht2
    {
        private static void Main(string[] args)
        {
            int n = 10;
            int m = 10;
            int p = 10;

            Console.WriteLine("The NestedForLoops loops {0} amount of times with n = {1}, m = {2}, p = {3}",
                NestedForLoops(n, m, p), n, m, p);
            Console.WriteLine("The NormalForLoops loops {0} amount of times with n = {1}, m = {2}, p = {3}",
                NormalForLoops(n, m, p), n, m, p);
            Console.ReadLine();

        }

        /*
         *  Because we have nested for-loops, we may multiply each loop's complexity,
         *  to get the total complexity of the algorithm. For this algorithm that will be:
         *
         *  time-complexity: O(n*m*p)
         */
        private static long NestedForLoops(int n, int m, int p)
        {
            long sum = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int k = 0; k < p; k++)
                    {
                        sum++;
                    }
                }
            }
            stopwatch.Stop();
            return sum;
        }

        /*
         *  This algorithm has 3 loops which aren't nested. Therefore we cant multiply each complexity.
         *  We have to add each loop's complexity to get the total complexity:
         *
         *  time-complexity: O(n+m+p)
         */
        private static long NormalForLoops(int n, int m, int p)
        {
            long sum = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < n; i++)
            {
                sum++;
            }

            for (int i = 0; i < m; i++)
            {
                sum++;
            }

            for (int i = 0; i < p; i++)
            {
                sum++;
            }
            stopwatch.Stop();
            return sum;
        }
    }
}
