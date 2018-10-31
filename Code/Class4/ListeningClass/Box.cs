using System;
using System.Collections.Generic;
using System.Text;
using ADS.Class3.ListeningClass;

namespace ADS.Class4.ListeningClass
{
    class Box
    {
        public void Run()
        {
            //We can make use of our own Box class by creating a new box like this:
            Box<Person> personBox = new Box<Person>();
            Person p = new Person();

            personBox.Add(p);
        }
    }
    //This is a class to place objects (of type T) in a box.
    //The generic T (T stands for Type) can literally be anything, but usually it is T
    public class Box<T>
    {   
        //We need some memory to remember the object placed inside the box
        private T t;

        //We need to be able to store an object in the box
        public void Add(T t)
        {
            this.t = t;
        }

        //And we want to be able to retrieve an object from the box
        public T Get()
        {
            return t;
        }
    }
}
