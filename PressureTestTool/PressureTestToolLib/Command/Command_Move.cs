using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureTestToolLib
{
    class Command_Move : AbstractCommand
    {
        public Command_Move()
        {
            Key = "move";
        }

        public override void Excute(Parameter parameter)
        {
            ClientManager.inst.AddRequest(LogicType.Move, parameter.ParamList);
        }

        public override string GetHelp()
        {
            string help = string.Format("{0} Usage: {0},all of the added clients do move logic", Key);
            return help;
        }
    }
}
