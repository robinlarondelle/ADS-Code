using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Class3.ListeningClass
{
    class ObjectExamples
    {
        //this is an value-object with value 0, and is not on the Heap
        private int a;

        //this is an value-object with value 3, and is not on the Heap
        private int b = 3;

        //This is an reference-object with value null, and is on the Heap
        private Int32 c;

        //This is an reference-object with value 3, and is on the Heap
        //Integer d = new Integer(3) (This works in Java only)

        //This is an value-object with value 0, and is not on the Heap
        private int[] list;

        //This is an reference-object, and is on the Heap
        int[] list2 = new int[5];

        //This is an reference-object with value null, and is on the Heap
        private Person[] plist;

        //This is an reference-object with 100 null values, and is on the Heap
        Person[] plist2 = new Person[100];

    }
}
