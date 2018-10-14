using System;

/*
 *  In this example we run a couple of different complexity algorithms
 *  Every algorithm does the same: it counts the amount of times it loops *
 */

namespace C3_Listening_Class_1.ListeningClass1
{
    class ComplexityExamples
    {
        private static void Main(string[] args)
        {
            int n = 100;

            Console.WriteLine("Amount of times the loop in LinearComplexity loops: {0}", LinearComplexity(n));
            Console.WriteLine("Amount of times the loop in SquaredComplexity loops: {0}", SquaredComplexity(n));
            Console.WriteLine("Amount of times the loop in PowerOfThreeComplexity loops: {0}", PowerOfThreeComplexity(n));

            Console.ReadLine();
        }

        /*
         *  This is a linear algorithm (Complexity O(n))
         *  You know it is linear because it has 1 for-loop
         *  If you were to double n, the amount of times the loop would have to loop
         *  would be double.
         */
        private static long LinearComplexity(int n)
        {
            long sum = 0;

            for (int i = 0; i < n; i++)
            {
                //This is where the work is done. This is where the memory-usage increases
                sum++;
            }

            return sum;
        }

        /*
         *  This is a squared complexity algorithm. You know it is squared
         *  Because it has two for-loops, nested in each other.
         *  The outer for-loop depends on n, if n doubles, the amount of times the
         *  outer loop runs doubles. The inner loops depends on the outer loop.
         *  If i doubles (the value of the outer loop), the amount of times it loops doubles
         *  So both loops have complexity O(n), but because the inner loop depends on the outer loop
         *  The complexity of the total algorithm is O(n*n) -> O(n^2)
         */
        private static long SquaredComplexity(int n)
        {
            long sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    //This is where the work is done. This is where the memory-usage increases
                    sum++;
                }
            }

            return sum;
        }

        /*
         *  This algorithm shows that when making n really big, all the finite and small
         *  numbers don't matter any more.
         */
        private static long PowerOfThreeComplexity(int n)
        {
            long sum = 0;

            /*
             *  This for-loop has a complexity of O(3*n+2). When you make n really big,
             *  The 2 will be nothing compared to the n, so we can leave 2 out of the complexity.
             *  This leaves us with O(3*n). because 3 is a constant, it doesn't influence the complexity
             *  if n = 1000, the algorithm will loop 3000 times, if n is doubled (n = 2000) it loops 6000 times.
             *  We can leave 3 out of the complexity, because it has no influence.
             *
             *  Complexity O(n)
             */
            for (int i = 0; i < 3*n+2; i++)
            {
                /*
                 *  Here we see a n^2 complexity. Because it is a nested loop, our total complexity is O(n^3)
                 *
                 *  Complexity O(n^3)
                 */
                for (int j = 0; j < n*n; j++)
                {
                    sum++;
                }
            }

            return sum;
        }
    }
}
