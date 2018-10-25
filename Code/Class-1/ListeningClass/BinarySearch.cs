using System;

/*
 *  This is an example of searching in an sorted array
 *  This is called a BINARY SEARCH
 *  This algorithm halves the problem with each step it
 *  needs to take, because it searches at the half of the half
 *  of the half etc.
 *
 *  The size of the problem is the size of the array
 *  So Size of the problem = n
 *
 *  If i double the size of the problem, what happens to
 *  The amount of work needed?
 *
 *  This is a complicated algorithm complexity.
 *  Every time we double our n, we only have to perform
 *  1 extra time more of work. This is a logarithmic time
 *
 *  so:
 *  Complexity = O(log(n))  
 */

namespace ADS.ListeningClass
{
    class BinarySearch
    {
        public void Run()
        {
            // Create new int array
            // This is the size of the problem (n)
            // n = 9
            int[] a = {1, 2, 3, 4, 5, 6, 7, 8, 9};

            Console.WriteLine("Index of 7 is {0}", IndexOf(a, 7));
        }

        private int IndexOf(int[] a, int key)
        {
            // Define a lower bound and upper bound index
            int low = 0;
            int high = a.Length - 1;

            while (low<=high)
            {
                //Create the center of the array
                int center = low + (high - low) / 2;

                //If the value of the key is smaller than the value
                //at center, we lower the upper bound to the value of
                //center - 1
                //This is one of the places where work happens
                if (key < a[center])
                {
                    high = center - 1;
                }

                //Otherwise (if the value of the key is higher than the
                //value at center), we raise the lower bound to the value
                //of center + 1
                else
                {
                    //This is one of the places where work happens
                    if (key > a[center])
                    {
                        low = center + 1;
                    }
                    //key = a[center], we have a match!
                    else
                    {
                        return center;
                    }
                }
            }

            //The value of the key was not found within the array
            return -1;
        }
    }
}
