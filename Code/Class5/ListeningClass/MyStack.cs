using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Class5.ListeningClass
{
    public class MyStack
    {
        public void Run()
        {
            StackImplementation<int> si = new StackImplementation<int>();
            si.Push(1);
            si.Push(2);
            si.Push(3);
            si.Push(4);
            Console.WriteLine("Size of the stack: {0}", si.Count);
            Console.WriteLine("Removing the top item from the stack: {0}", si.Pop());
            Console.WriteLine("Size of the stack: {0}", si.Count);
            Console.WriteLine("Value of the top item from the stack: {0}", si.Peek());
        }

        class StackImplementation<T> : IMyStack<T>
        {
            private LinkedList<T> linkedList = new LinkedList<T>();

            public int Count => linkedList.Count;

            public void Push(T t) => linkedList.AddFirst(t);

            public T Peek() => linkedList.First.Value;

            public T Pop()
            {
                T t = linkedList.First.Value;
                linkedList.RemoveFirst();
                return t;
            }

            public bool IsEmpty() => linkedList.Count == 0;
        }
    }
}
