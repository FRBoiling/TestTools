using System;
using System.Collections.Generic;
using System.Text;

namespace Model.System
{

    public abstract class AAwakeSystem<T> : IAwakeSystem, IAwake
    {
        public Type Type()
        {
            return typeof(T);
        }

        public void Run(object o)
        {
            this.Awake((T)o);
        }

        public abstract void Awake(T self);
    }

    public abstract class AAwakeSystem<T, A> : IAwakeSystem, IAwake<A>
    {
        public Type Type()
        {
            return typeof(T);
        }

        public void Run(object o, A a)
        {
            this.Awake((T)o, a);
        }

        public abstract void Awake(T self, A a);
    }

    public abstract class AAwakeSystem<T, A, B> : IAwakeSystem, IAwake<A, B>
    {
        public Type Type()
        {
            return typeof(T);
        }

        public void Run(object o, A a, B b)
        {
            this.Awake((T)o, a, b);
        }

        public abstract void Awake(T self, A a, B b);
    }

    public abstract class AAwakeSystem<T, A, B, C> : IAwakeSystem, IAwake<A, B, C>
    {
        public Type Type()
        {
            return typeof(T);
        }

        public void Run(object o, A a, B b, C c)
        {
            this.Awake((T)o, a, b, c);
        }

        public abstract void Awake(T self, A a, B b, C c);
    }
}
