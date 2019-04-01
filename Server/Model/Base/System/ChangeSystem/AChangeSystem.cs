using System;
using System.Collections.Generic;
using System.Text;

namespace Model.System
{
    public abstract class AChangeSystem<T> : IChangeSystem
    {
        public void Run(object o)
        {
            this.Change((T)o);
        }

        public Type Type()
        {
            return typeof(T);
        }

        public abstract void Change(T self);
    }
}
