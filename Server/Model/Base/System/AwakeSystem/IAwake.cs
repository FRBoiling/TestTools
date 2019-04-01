using System;
using System.Collections.Generic;
using System.Text;

namespace Model.System
{
    public interface IAwake
    {
        void Run(object o);
    }

    public interface IAwake<T>
    {
        void Run(object o, T t);
    }

    public interface IAwake<A, B>
    {
        void Run(object o, A a, B b);
    }

    public interface IAwake<A, B, C>
    {
        void Run(object o, A a, B b, C c);
    }
}
