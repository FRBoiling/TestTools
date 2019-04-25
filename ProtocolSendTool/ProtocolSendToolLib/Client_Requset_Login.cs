
using Logger;
using Message.Client.Protocol.CBarrack;
using Message.Client.Protocol.CGate;

namespace ProtocolSendToolLib
{
    public partial class Client
    {
        public void Request_MSG_CB_LOGIN_SERVERS()
        {
            MSG_CB_LOGIN_SERVERS MSG_CB_LOGIN_SERVERS = new MSG_CB_LOGIN_SERVERS();
            MSG_CB_LOGIN_SERVERS.AccountName = player.AccountName;
            MSG_CB_LOGIN_SERVERS.ChannelName = "ROBOT";
            Net.Send(MSG_CB_LOGIN_SERVERS);
        }

        public int ChoseOneLoginedServer() {
            int mainId = 0;
            if (loginedServers.Count>0)
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

        public void Request_MSG_CB_USER_LOGIN(int mainId)
        {
            player.GameServerID = mainId;

            MSG_CB_USER_LOGIN MSG_CB_USER_LOGIN = new MSG_CB_USER_LOGIN();
            MSG_CB_USER_LOGIN.AccountName = player.AccountName;
            MSG_CB_USER_LOGIN.Password = player.PassWord;

            MSG_CB_USER_LOGIN.DeviceId = "19e22d35f4a60df695d1a4d847992a85da077f35";
            MSG_CB_USER_LOGIN.Version = CFG.Version;

            MSG_CB_USER_LOGIN.MainId = player.GameServerID;
            MSG_CB_USER_LOGIN.ChannelName = "";

            MSG_CB_USER_LOGIN.SdkId = "";
            MSG_CB_USER_LOGIN.Token = "";

            Net.Send(MSG_CB_USER_LOGIN);
        }

        public void Request_MSG_CG_CHARACTER_LIST()
        {
            MSG_CG_CHARACTER_LIST MSG_CG_CHARACTER_LIST = new MSG_CG_CHARACTER_LIST();
            MSG_CG_CHARACTER_LIST.AccountId = player.AccountName;
            MSG_CG_CHARACTER_LIST.ChannelName = "";
            MSG_CG_CHARACTER_LIST.Token = player.Token;
            Net.Send(MSG_CG_CHARACTER_LIST);
        }

        public void Request_MSG_CG_TO_ZONE(int character_uid)
        {
            MSG_CG_TO_ZONE MSG_CG_TO_ZONE = new MSG_CG_TO_ZONE();
            MSG_CG_TO_ZONE.Uid = character_uid;
            Net.Send(MSG_CG_TO_ZONE);
        }

        public void CreaterCharactor()
        {
            Log.WriteLine("please create an charactor");
        }

        public void Request_MSG_CG_HEARTBEAT()
        {
            MSG_CG_HEARTBEAT msg = new MSG_CG_HEARTBEAT();
            Net.Send(msg);
        }
        public void Request_MSG_CG_GET_BLOWFISHKEY()
        {
            MSG_CG_GET_BLOWFISHKEY msg = new MSG_CG_GET_BLOWFISHKEY();
            Net.Send(msg);
        }


        public void Login_Request_MSG_CG_MAP_LOADING_DONE(int mapId, int channel)
        {
            MSG_CG_MAP_LOADING_DONE MSG_CG_MAP_LOADING_DONE = new MSG_CG_MAP_LOADING_DONE();
            MSG_CG_MAP_LOADING_DONE.MapId = mapId;
            MSG_CG_MAP_LOADING_DONE.Channel = channel;
            Net.Send(MSG_CG_MAP_LOADING_DONE);
            player.IsLogin = true;
        }

    }
}