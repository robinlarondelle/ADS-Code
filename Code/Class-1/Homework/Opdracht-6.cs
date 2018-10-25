/*
 *  Maak een tovervierkant
 */

//TODO Finish the magic square
using System;

namespace ADS.Homework
{
    class Opdracht6
    {

        public void Run()
        {
            int n = 5;
            GetValues(n);
        }

        private int[,] GetValues(int n)
        {
            //Adjust the n value for the array (which begins at 0, not at 1);
            int a = n - 1;
            double nSquared = Math.Pow(n, 2);

            //first we are going to declare a multidimentional array
            //This array represents our square with n columns and n rows
            int[,] square = new int[n, n];
            int x = ((a + 1) / 2);
            int y = a;

            //The first number (1) of the magic sqaure will always be placed at the top-center
            //of the square. The coordinates of the top-center are always ((n+1)/2, n).
            square[x, y] = 1;

            //The array starts with 2 because 1 is always at a pre-defined position
            //The array loops n^2 times, because that is the amount of slots there are to fill
            for (int i = 2; i <= nSquared; i++)
            {
                //We're going to move one right, one up (so (1,1))
                x += 1;
                y += 1;

                //Check if we are still inside the sqaure's limits
                if (y > a)
                {
                    //Reset y position to the bottom of the square
                    y = 0;
                }

                if (x > a)
                {
                    //Reset x to the left of the square
                    x = 0;
                }

                //Check if slot is filled
                if (square[x, y].Equals(0))
                {
                    square[x, y] = i;
                }
                else
                {
                    if (!((x-1) > a))
                    {
                        x -= 1;
                    }
                    else
                    {
                        x = 0;
                    }

                    if (!((y - 2) > a))
                    {
                        y -= 2;
                    }
                    else
                    {
                        y = 0;
                    }
                    square[x, y] = i;
                }
            }

            return square;
        }
    }
}
