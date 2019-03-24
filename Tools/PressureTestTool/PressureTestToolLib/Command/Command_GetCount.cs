using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureTestToolLib
{
    class Command_GetCount : AbstractCommand
    {
        public Command_GetCount() {
            Key = "getcount";
        }
        public override void Excute(Parameter parameter)
        {
             ClientManager.inst.GetCount();
        }

        public override string GetHelp()
        {
            string help = string.Format("{0} Usage: {0},will get the number of added clients", Key);
            return help;
        }
    }
}
