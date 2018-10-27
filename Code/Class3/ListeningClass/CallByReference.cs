using ADS.Class3.ListeningClass;
using System;
using System.Collections.Generic;
using System.Text;

/*
 * This is an example to show how call by reference is done
 */
namespace ADS.Class3.ListeningClass
{
    class CallByReference
    {
        public void Run()
        {
            //We declare variable n here, with value 2
            int n = 2;
            Console.WriteLine("The value of n before ChangeValue: {0}", n);

            //When we call this method, there is a COPY (a reference) of n placed on the callstack
            //This reference is used inside the method, NOT THE ORIGINAL VALUE.
            ChangeValue(n);
            Console.WriteLine("The value of n after ChangeValue: {0}", n);
        }

        private void ChangeValue(int n)
        {
            //When changing the value of n, we are changing the value of the reference of n
            n = 7;
        }
    }
}

