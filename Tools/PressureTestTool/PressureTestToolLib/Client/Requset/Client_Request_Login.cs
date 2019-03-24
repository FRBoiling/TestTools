using Logger;
using Message.Server.Client.Protocol.CGate;
using Message.Server.Client.Protocol.CBarrack;
using Message.Server.Gate.Protocol.GateC;

namespace PressureTestToolLib
{
    public partial class Client
    {

        public void Request_MSG_CB_LOGIN_SERVERS()
        {
            MSG_CB_LOGIN_SERVERS MSG_CB_LOGIN_SERVERS = new MSG_CB_LOGIN_SERVERS();
            MSG_CB_LOGIN_SERVERS.accountName = player.AccountName;
            MSG_CB_LOGIN_SERVERS.channelName = "";
            Net.Send(MSG_CB_LOGIN_SERVERS);
        }

        public void Request_MSG_CB_USER_LOGIN(int mainId)
        {
            player.GameServerID = mainId;

            MSG_CB_USER_LOGIN MSG_CB_USER_LOGIN = new MSG_CB_USER_LOGIN();
            MSG_CB_USER_LOGIN.accountName = player.AccountName;
            MSG_CB_USER_LOGIN.password = player.PassWord;

            MSG_CB_USER_LOGIN.deviceId = "19e22d35f4a60df695d1a4d847992a85da077f35";
            MSG_CB_USER_LOGIN.version = CFG.Version;

            MSG_CB_USER_LOGIN.mainId = player.GameServerID;
            MSG_CB_USER_LOGIN.channelName = "";

            MSG_CB_USER_LOGIN.sdkId = "";
            MSG_CB_USER_LOGIN.token = "";

            Net.Send(MSG_CB_USER_LOGIN);
        }

        public void Request_MSG_CG_CHARACTER_LIST()
        {
            MSG_CG_CHARACTER_LIST MSG_CG_CHARACTER_LIST = new MSG_CG_CHARACTER_LIST();
            MSG_CG_CHARACTER_LIST.accountId = player.AccountName;
            MSG_CG_CHARACTER_LIST.channelName = "";
            MSG_CG_CHARACTER_LIST.token = player.Token;
            Net.Send(MSG_CG_CHARACTER_LIST);
        }

        public void Request_MSG_CG_TO_ZONE(int character_uid)
        {
            MSG_CG_TO_ZONE MSG_CG_TO_ZONE = new MSG_CG_TO_ZONE();
            MSG_CG_TO_ZONE.uid = character_uid;
            Net.Send(MSG_CG_TO_ZONE);
        }
      
        public void Request_CreateCharacter()
        {
            var msg = new MSG_CG_CREATE_CHARACTER();

            string Name = string.Format("Robot<{0}>{1}",ClientManager.inst.Id, ClientNum);
            int Sex = 1;
            int MainId = 1001;

            Log.Info("Create an new Robot {0}", Name);

            msg.Name = Name;
            msg.MainId = MainId;
            msg.Sex = Sex;
            msg.Head =1;
            msg.SystemFashionId =1;

            Net.Send(msg);
        }

        public void Request_MSG_CG_MAP_LOADING_DONE(int mapId, int channel)
        {
            MSG_CG_MAP_LOADING_DONE MSG_CG_MAP_LOADING_DONE = new MSG_CG_MAP_LOADING_DONE();
            MSG_CG_MAP_LOADING_DONE.mapId = mapId;
            MSG_CG_MAP_LOADING_DONE.channel = channel;
            Net.Send(MSG_CG_MAP_LOADING_DONE);
            player.IsLogin = true;
            Log.Info("::{0}::{1}:: enter map id {2} channel {3}", player.AccountName, player.CharInfo.Name, player.CharInfo.MainId, player.CharInfo.Channel);
        }


     
    }
}
