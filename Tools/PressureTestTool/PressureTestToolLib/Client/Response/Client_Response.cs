using Engine.Foundation;
using Logger;
using Message.Server.Barrack.Protocol.BarrackC;
using Message.Server.Client.Protocol.CGate;
using Message.Server.Gate.Protocol.GateC;
using System.IO;

namespace PressureTestToolLib
{
    public partial class Client
    {
        private void BindResponse_Login()
        {
            Net.AddResponser(Id<MSG_BC_LOGIN_SERVERS>.Value, OnResponse_MSG_BC_LOGIN_SERVERS);
            Net.AddResponser(Id<MSG_BC_USER_LOGIN>.Value, OnResponse_MSG_BC_USER_LOGIN);
            Net.AddResponser(Id<MSG_GC_CHARACTER_LIST>.Value, OnResponse_MSG_GC_CHARACTER_LIST);
            Net.AddResponser(Id<MSG_GC_ENTER_WORLD>.Value, OnResponse_MSG_GC_ENTER_WORLD);
            Net.AddResponser(Id<MSG_GC_ENTER_ZONE>.Value, OnResponse_MSG_GC_ENTER_ZONE);
            Net.AddResponser(Id<MSG_GC_CREATE_CHARACTER>.Value, OnResponse_MSG_GC_CREATE_CHARACTER);

            //Net.AddResponser(Id<MSG_GC_TIME_SYNC>.Value, OnResponse_MSG_GC_TIME_SYNC);
            //Net.AddResponser(Id<MSG_GC_BLOWFISHKEY>.Value, OnResponse_MSG_GC_BLOWFISHKEY);
            //Net.AddResponser(Id<MSG_GC_HEARTBEAT>.Value, OnResponse_MSG_GC_HEARTBEAT);
        }

        public void BindResponse()
        {
            Net.AddResponser(Id<MSG_GC_HEARTBEAT>.Value, OnResponse_HeartBeat);
            Net.AddResponser(Id<MSG_GC_TIME_SYNC>.Value, OnResponse_TimeSync);

            //login
            BindResponse_Login();

            ////加密
            //Net.AddResponser(Id<MSG_GC_BLOWFISHKEY>.Value, OnResponse_BlowFishkey);
          
            ////scene
            //Net.AddResponser(Id<MSG_GC_BROADCAST_LIST>.Value, OnResponse_BroadCastList);
            //Net.AddResponser(Id<MSG_GC_CHARACTER_ENTER_LIST>.Value, OnResponse_CharacterEnterList);
        }

        private void OnResponse_TimeSync(MemoryStream stream)
        {
            MSG_GC_TIME_SYNC msg = ProtoBuf.Serializer.Deserialize<MSG_GC_TIME_SYNC>(stream);
            //Log.WarnLine("{0} time sync {0}", Name, msg.timeStamp);
        }

        private void OnResponse_HeartBeat(MemoryStream stream)
        {
            //Log.WarnLine("{0} recv hear beat", Name);                                                                              
            //Request_Heartbeat();
        }
    }
}
