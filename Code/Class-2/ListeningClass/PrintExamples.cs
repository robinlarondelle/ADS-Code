using System;

namespace ADS.ListeningClass
{
    class PrintExamples
    {
        private static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine("The output of Print1 is:");
            Print1(n);

            Console.WriteLine("");

            Console.WriteLine("The output of Print2 is:");
            Print2(n);
        }


        //This method calls itself inside the method body
        //This is called Recursion.
        //This method produces output 3, 2, 1
        private static void Print1(int n)
        {
            //First we print out the value of n. The first time
            //n is printed, it will be the same value as passed into the parameter
            Console.WriteLine("n = {0}", n);

            //This is the recursion-stop criteria. While n < 1, the method itself will be called
            //But with n - 1. Every time the method is called, it prints the value of n to the console
            //This explains why the output will me 3, 2, 1
            if (n > 1)
            {
                Print1(n - 1);
            }
        }

        //This method produces output 1, 2, 3
        private static void Print2(int n)
        {
            //The difference between Print1 is that there is no output to the console before the stop-criteria
            //So every time the stop-criteria is checked, it calls itself, whilst decreasing n every time it does so
            if (n > 1)
            {
                Print2(n - 1);
            }

            //Finally, when the stpo-criteria is met, the method can continue to the print line.
            //The method is finished. It returns to the if-statement in which it was called, and prints the next line
            //And so on. Until the first method-call is finished, and prints its value of n
            Console.WriteLine("n = {0}", n);
        }
    }
}
