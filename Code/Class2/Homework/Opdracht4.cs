using System;
using System.Collections;
using System.Collections.Generic;

namespace ADS.Class2.Homework
{
    class Opdracht4
    {
        public void Run()
        {
            int n = 3;
            MoveDisks(n, "A", "B", "C");
        }

        private void MoveDisks(int n, string first, string mid, string last)
        {
            if (n > 0)
            {
                MoveDisks(n - 1, first, last, mid);
                Console.WriteLine("{0} to {1}", first, last);
                MoveDisks(n - 1, mid, first, last);
            }
        }
    }
}
