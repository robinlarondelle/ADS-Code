using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ADS.Class3.ListeningClass
{
    class TypesExercise
    {
        public void Run()
        {
            Console.WriteLine("\n\n--- Value object exercise---");
            ValueObjectExercise();

            Console.WriteLine("\n\n--- Reference object exercise---");
            ReferenceObjectExercise();
        }

        private void ValueObjectExercise()
        {
            //we make a value-object (int) with value 3
            int a = 3;
            Console.WriteLine("The value of a = {0}", a);

            //We make a value-object (int) with value a
            //We create a new value, and not a reference to a value, because a is nog a reference-object
            int b = a;
            Console.WriteLine("The value of b = {0}", b);

            //When we change the value of a, we do not change the value of b, because a is not a reference object
            //And thus b has no reference to a
            a = 7;
            Console.WriteLine("The value of a = {0}", a);
            Console.WriteLine("The value of b = {0}", b);
        }

        private void ReferenceObjectExercise()
        {
            //Create a new object "a" of type Test, which references a Test() object on the Heap
            Test a = new Test() {x = 5};
            Console.WriteLine("Value of x in Test a: {0}", a.x);

            //Create a new reference to that same object on the heap, but with a different name
            Test b = a;
            Console.WriteLine("Value of x in Test b: {0}", b.x);

            //Changing the value of x through reference of a, will change the value of x if we use reference b
            a.x = 7;
            Console.WriteLine("Value of x in Test a: {0}", a.x);
            Console.WriteLine("Value of x in Test b: {0}", b.x);

        }

        private class Test
        {
            public int x { get; set; }
        }
    }
}
