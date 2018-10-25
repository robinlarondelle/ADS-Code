using System;
using System.Diagnostics;

/*
 *  Noteer van alle 4 de methodes de reken- en geheugencomplexiteit
 */

namespace ADS.Homework
{
    class Opdracht1
    {
        public void Run()
        {
            int n = 100;
            Console.WriteLine("Method A takes {0} ticks, with n = {1}", A(n), n);
            Console.WriteLine("Method B takes {0} ticks, with n = {1}", B(n), n);
            Console.WriteLine("Method C takes {0} ticks, with n = {1}", C(n), n);
            Console.WriteLine("Method D takes {0} ticks, with n = {1}", D(n), n);

            Console.WriteLine("\nNow with N Doubled\n");
            n *= 2;
            Console.WriteLine("Method A takes {0} ticks, with n = {1}", A(n), n);
            Console.WriteLine("Method B takes {0} ticks, with n = {1}", B(n), n);
            Console.WriteLine("Method C takes {0} ticks, with n = {1}", C(n), n);
            Console.WriteLine("Method D takes {0} ticks, with n = {1}", D(n), n);
        }

        /*
         *  We can see a simple for-loop, which depends on the size of n only
         *  This is a linear complexity
         *  time-complexity -> O(n)
         *
         *  If n gets bigger, the memory consumption stays the same.
         *  memory-complexity -> O(1) (constant)
         */
        private long A(int n)
        {
            long sum = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < n; i++)
            {
                sum++;
            }
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }

        /*
         *  There is a nested for-loop with time-complexity O(n)
         *  And the "parent"-loop has a time-complexity of O(n) as well
         *  We may multiply the nested complexity with its parent complexity
         *  time-complexity -> O(n^2)
         *
         *  If we make n really big, the amount of memory needed stays the same
         *  memory-complexity -> O(1)
         */
        private long B(int n)
        {
            long sum = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum++;
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }

        /*
         *  There is a nested loop with time-complexity O(n^2)
         *  And a parent-loop with time-complexity O(n)
         *  time-complexity -> O(n^3)
         *
         *  If n is really big, the memory needed stays the same
         *  memory-complexity -> O(1)
         */
        private long C(int n)
        {
            long sum = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n*n; j++)
                {
                    sum++;
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }

        /*
         *  This is a nested for-loop which is dependent on the parent-loop
         *  When a inner-loop is dependent of the outer-loop the complexity is always n * n
         *
         *  time-complexity = O(n^2)
         *
         *  The memory usage stays the same when n increases
         *  memory-complexity = O(1)
         */
        private long D(int n)
        {
            long sum = 0;
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sum++;
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }
    }
}
