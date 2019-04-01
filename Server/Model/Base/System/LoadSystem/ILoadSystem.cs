using System;
using System.Collections.Generic;
using System.Text;

namespace Model.System
{
    public interface ILoadSystem
    {
        Type Type();
        void Run(object o);
    }
}
