using System;

/*
 *  This is an example of searching in an unsorted array
 *  This is called a LINEAR SEARCH
 *  This is an demonstration to show where the size of the problem (n) is
 *  And to show where the costmodel (the place where all the work is done) is
 *
 *  If i double the size of the problem (n), how many times extra do i have to
 *  perform work?
 *
 *  n = 6
 *  times = 6
 *
 *  n = 12
 *  times = 12
 *
 *  Complexity: O(n) (this is called a linear complexity)
 */

namespace C3_Listening_Class_1
{
    class SearchUnsortedList
    {
        private static void Main(string[] args)
        {
            // Create int array
            // SIZE OF THE PROBLEM = THE SIZE OF THE ARRAY
            // n = 6
            int[] a = {3, 5, 4, 7, 6, 9};

            Console.WriteLine("Match! 7 is at index {0}", IndexOf(a, 7));
            Console.ReadLine();
        }

        private static int IndexOf(int[] a, int key)
        {
            //Loop through the size of the array
            for (int i = 0; i < a.Length; i++)
            {
                // Return index of matching key
                // COSTMODEL (WORK DONE) IS THE IF-STATEMENT
                // Comparing the value index at i with the key
                // You have to perform this work for every n in the array
                // So the work is the same as the size of the problem
                if (a[i] == key)
                {
                    return i;
                }

                Console.WriteLine("Number {0} is in loop.", a[i]);
            }

            //Return -1 if key is not found
            return -1;
        }
    }
}
