using Message.Server.Gate.Protocol.GateC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureTestToolLib
{
    public partial class Client
    {
        public int ClientNum = 0;

        public void SetAccountName(string v)
        {
            player.AccountName = v;
        }

        public string GetAccountName()
        {
            return player.AccountName;
        }


        public bool IsLogin()
        {
            return player.IsLogin;
        }

        List<int> loginedServers = new List<int>();
        List<MSG_GC_CHARACTER_INFO> characterList = new List<MSG_GC_CHARACTER_INFO>();

        private int ChoseOneLoginedServer()
        {
            int mainId = 0;
            if (loginedServers.Count > 0)
            {
                mainId = loginedServers[0];
            }
            else
            {
                mainId = 1001;
            }
            return mainId;
        }

        public int ChoseOneCharacter()
        {
            int uid = characterList[0].Uid;
            return uid;
        }
    }
}
