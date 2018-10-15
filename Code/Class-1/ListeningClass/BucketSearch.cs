using System;
using System.Linq;

namespace ADS.ListeningClass
{
    class BucketSearch
    {
        private static void Main(string[] args)
        {
            int[] ints = { 1, 3, 4, 2, 2, 4, 3, 1, 3, 2, 4, 2, 3, 4, 1, 2, 3, 2, 4 };
            SortList(ints);
        }

        private static int[] SortList(int[] ints)
        {
            int lowest = ints.Min();
            int highest = ints.Max();

            int[] tally = new int[highest - lowest + 1];
            for (int i = 1; i <= tally.Length; i++)
            {
                for (int j = 0; j < ints.Length; j++)
                {
                    if (ints[j] == i)
                    {
                        tally[i-1] += 1;
                    }
                }
            }

            //TODO Create new sorted Array




            //TODO return new sorted array
            return tally;
        }
    }
}
