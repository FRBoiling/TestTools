using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureTestToolLib
{
    abstract public class AbstractCommand
    {
        protected string Key;
        public abstract string GetHelp();
        public string GetKey()
        {
            return Key;
        }
        public abstract void Excute(Parameter parameter);
    }
}
