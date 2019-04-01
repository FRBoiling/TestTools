using System;
using System.Collections.Generic;
using System.Text;

namespace Model.System
{
    public abstract class AStartSystem<T> : IStartSystem
    {
        public void Run(object o)
        {
            this.Start((T)o);
        }

        public Type Type()
        {
            return typeof(T);
        }

        public abstract void Start(T self);
    }
}
