using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureTestToolLib
{
    class Command_Login : AbstractCommand
    {
        public Command_Login()
        {
            Key = "login";
        }
        public override void Excute(Parameter parameter)
        {
            ClientManager.inst.AddRequest(LogicType.Login, parameter.ParamList);
        }

        public override string GetHelp()
        {
            string help = string.Format("{0} Usage: {0},all of the added clients login", Key);
            return help;
        }
    }
}
