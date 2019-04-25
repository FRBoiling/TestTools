using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureTestToolLib
{
    class Command_AddClient : AbstractCommand
    {
        public Command_AddClient()
        {
            Key = "add";
        }
        public override void Excute(Parameter parameter)
        {
            int count = 0;
            if (parameter.ParamList.Count>0)
            {
                int.TryParse(parameter.ParamList[0], out count);
                ClientManager.inst.AddClient(count);
            }
            else
            {
                ClientManager.inst.AddClient(1);
            }
        }

        public override string GetHelp()
        {
            string help =string.Format( "{0} Usage: {0} number/{0},will adds clients to the specified number.(default number is 1)",Key);
            return help;
        }
    }
}
