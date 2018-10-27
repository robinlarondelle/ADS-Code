using System;

namespace ADS.Class2.Homework
{
    class Opdracht1
    {
        public void Run()
        {
            int n = 5;
            Console.WriteLine("[Recursive] The number in the fibonacci sequence at position {0} is {1}", n, FiboRecursive(n));
            Console.WriteLine("[Iterative] The number in the fibonacci sequence at position {0} is {1}", n, FiboIterative(n));
        }


        //This is the Recursive way of calculating Fibonacci. For this method we use global variables.
        //This is just like a Tree, but instead of returning a line, you return a number, which is the
        //parameter. See included picture
        //
        //time-complexity   -> O(2^n)
        //memory-complexity -> O(n)
        private int FiboRecursive(int n)
        {
            if (n <= 1) return n;
            return FiboRecursive(n - 1) + FiboRecursive(n - 2);
        }

        //This is the same method as the recursive, but this time it is iterative
        //
        //time-complexity   -> O(n)
        //memory-complexity -> O(1)
        private int FiboIterative(int n)
        {
            int a = 1;
            int b = 1;
            int sum = 0;

            for (int i = 3; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }

            return sum;
        }
    }
}
