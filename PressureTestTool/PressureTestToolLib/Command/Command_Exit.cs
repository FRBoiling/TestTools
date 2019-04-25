using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureTestToolLib
{
    public class Command_Exit : AbstractCommand
    {
        public Command_Exit() {
            Key = "exit";
        }
        public override void Excute(Parameter parameter)
        {
            ClientManager.inst.ClearClient();
        }

        public override string GetHelp()
        {
            string help = string.Format("{0} Usage: {0},will exit all clients", Key);
            return help;
        }
    }
}
