using System;
using System.Collections.Generic;
using System.Text;

namespace Model.System
{
    public abstract class ADestroySystem<T> : IDestroySystem
    {
        public void Run(object o)
        {
            this.Destroy((T)o);
        }

        public Type Type()
        {
            return typeof(T);
        }

        public abstract void Destroy(T self);
    }
}
