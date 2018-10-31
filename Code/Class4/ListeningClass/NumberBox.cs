using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using ADS.Class3.ListeningClass;

namespace ADS.Class4.ListeningClass
{
    class NumberBox
    {
        public void Run()
        {
            Person p = new Person();
            NumberBox<Person> personNumberBox = new NumberBox<Person>();

            personNumberBox.Add(p);
            personNumberBox.Compare(p);

        }
    }

    //You can also have something called "constraints on type parameters", where you are basically saying
    //"I can receive an object of type T, but only if it implements x interface"
    //This way you can do a lot more with the object of T, because you know it implements some methods
    public class NumberBox<T> where T : IComparable
    {
        //We need some memory to remember the object placed inside the box
        private T _t;

        //We need to be able to store an object in the box
        public void Add(T t)
        {
            _t = t;
        }

        //And we want to be able to retrieve an object from the box
        public T Get()
        {
            return _t;
        }

        //Because this class demands all objects to implement IComparable, we can use its methods
        public int Compare(T t)
        {
            return _t.CompareTo(t);
        }
    }
}
