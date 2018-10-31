using System;
using System.Collections.Generic;
using System.Text;

namespace ADS.Class5.ListeningClass
{
    public interface IMyStack<T>
    {
        int Count { get; }

        void Push(T t);
        T Peek();
        T Pop();
        bool IsEmpty();
    }
}
