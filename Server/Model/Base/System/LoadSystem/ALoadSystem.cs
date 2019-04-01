using System;
using System.Collections.Generic;
using System.Text;

namespace Model.System
{
    public abstract class ALoadSystem<T> : ILoadSystem
    {
        public void Run(object o)
        {
            this.Load((T)o);
        }

        public Type Type()
        {
            return typeof(T);
        }

        public abstract void Load(T self);
    }
}
