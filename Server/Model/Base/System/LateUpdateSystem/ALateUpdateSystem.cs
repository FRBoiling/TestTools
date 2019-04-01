using System;
using System.Collections.Generic;
using System.Text;

namespace Model.System
{
public abstract class ALateUpdateSystem<T> : ILateUpdateSystem
    {
        public void Run(object o)
        {
            this.LateUpdate((T)o);
        }

        public Type Type()
        {
            return typeof(T);
        }

        public abstract void LateUpdate(T self);
    }
}
