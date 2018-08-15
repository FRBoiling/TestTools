using protocol.client;

namespace ProtoSendLib
{
    public partial class Client
    {

        public void Request_MSG_CG_HEARTBEAT()
        {
            //MSG_CG_HEARTBEAT msg = new MSG_CG_HEARTBEAT();
            //Net.Send(msg);
        }
        public void Login_Request_MSG_CG_GET_BLOWFISHKEY()
        {
            //MSG_CG_GET_BLOWFISHKEY msg = new MSG_CG_GET_BLOWFISHKEY();
            //Net.Send(msg);
        }
        public void Login_Request_MSG_CG_USER_LOGIN()
        {
            MSG_CG_USER_LOGIN MSG_CG_USER_LOGIN = new MSG_CG_USER_LOGIN();
            MSG_CG_USER_LOGIN.username = PLAYER.username;
            MSG_CG_USER_LOGIN.token = "token";

            string registerId = "";
            MSG_CG_USER_LOGIN.version = CFG.Version;
            MSG_CG_USER_LOGIN.deviceId = "19e22d35f4a60df695d1a4d847992a85da077f35";
            MSG_CG_USER_LOGIN.registerId = registerId;
            MSG_CG_USER_LOGIN.areaId = PLAYER.ServerGroupID;
            MSG_CG_USER_LOGIN.channelName = "default_channel";
            MSG_CG_USER_LOGIN.password = "";
            Net.Send(MSG_CG_USER_LOGIN);
        }

        public void ReconnectLogin_Request_MSG_CG_RECONNECT_LOGIN()
        {
            MSG_CG_RECONNECT_LOGIN MSG_CG_RECONNECT_LOGIN = new MSG_CG_RECONNECT_LOGIN();
            MSG_CG_RECONNECT_LOGIN.username = PLAYER.username;
            MSG_CG_RECONNECT_LOGIN.token = "token";

            //MSG_CG_RECONNECT_LOGIN.oldBlowFish = "token";
            //MSG_CG_RECONNECT_LOGIN.uid = "token";

            Net.Send(MSG_CG_RECONNECT_LOGIN);
        }

        public void Login_Request_MSG_CG_TO_ZONE(int character_uid)
        {
            //MSG_CG_TO_ZONE MSG_CG_TO_ZONE = new MSG_CG_TO_ZONE();
            //MSG_CG_TO_ZONE.uid = character_uid;
            //Net.Send(MSG_CG_TO_ZONE);
        }

        public void Login_Request_MSG_CG_CREATE_ROLE(int areaId)
        {
            MSG_CG_CREATE_ROLE MSG_CG_CREATE_ROLE = new MSG_CG_CREATE_ROLE();
            MSG_CG_CREATE_ROLE.name ="robot_" +PLAYER.username;
            MSG_CG_CREATE_ROLE.areaId = areaId;
            Net.Send(MSG_CG_CREATE_ROLE);
        }

        public void Login_Request_MSG_CG_MAP_LOADING_DONE(int mapId, int channel)
        {
            //MSG_CG_MAP_LOADING_DONE MSG_CG_MAP_LOADING_DONE = new MSG_CG_MAP_LOADING_DONE();
            //MSG_CG_MAP_LOADING_DONE.mapId = mapId;
            //MSG_CG_MAP_LOADING_DONE.channel = channel;
            //Net.Send(MSG_CG_MAP_LOADING_DONE);
            //PLAYER.IsLogin = true;
        }

    }
}