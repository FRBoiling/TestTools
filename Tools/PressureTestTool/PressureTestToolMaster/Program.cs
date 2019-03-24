using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PressureTestToolMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            SessionMng.inst.Bind(8880, 2);
            SessionMng.inst.Listen(8880);

            while (true)
            {
                SessionMng.inst.Process();
                Thread.Sleep(50);
            }
        }
    }
}
