using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureTestToolLib
{
    class Request_Login : AbstractRequest
    {
        public void Login()
        {
            if (owner.player.IsLogin)
            {
                Log.WarnLine("{0} id:{1} already online", owner.player.AccountName, owner.player.CurrentCharacterId);
                return;
            }
            else
            {
                owner.Request_MSG_CB_LOGIN_SERVERS();
            }
        }

        public override void Request()
        {
            Login();
        }
    }
}
