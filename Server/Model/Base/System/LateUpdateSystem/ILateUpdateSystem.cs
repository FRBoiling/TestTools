using System;
using System.Collections.Generic;
using System.Text;

namespace Model.System
{
    public interface ILateUpdateSystem
    {
        Type Type();
        void Run(object o);
    }

}
