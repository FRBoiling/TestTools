using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureTestToolLib
{
    class Command_ChoseOneClient : AbstractCommand
    {
        public Command_ChoseOneClient()
        {
            Key = "choseclient";
        }

        public override void Excute(Parameter parameter)
        {
            int uid = 0;
            if (parameter.ParamList.Count>0)
            {
                int.TryParse(parameter.ParamList[1], out uid);
            }
            
            ClientManager.inst.ChoseClient(uid);
        }

        public override string GetHelp()
        {
            string help = string.Format("{0} Usage: {0} id,will chose one client by the id", Key);
            return help; 
        }
 
    }
}
