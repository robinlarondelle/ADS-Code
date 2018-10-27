﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Class3.ListeningClass
{
    //A Class is a reference-type, thus it exists on the Heap
    class Person
    {
        //object birthDate references to a DateTime object
        private DateTime birthDate;

        public Person()
        {
            //Instantiate a new DateTime object, because of the "new" keyword, it exists on the Heap
            birthDate = new DateTime();
        }
    }
}
