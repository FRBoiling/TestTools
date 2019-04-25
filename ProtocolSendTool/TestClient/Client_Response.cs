using System.IO;
using System.Collections.Generic;
using Protocol.Server.Register;
using Protocol.MsgId;
using System;

namespace TestClient
{
    public partial class Client
    {
    
        public void BindResponse()
        {
            Net.AddResponser(Id<MSG_Server_Register_Return>.Value, OnResponse_MSG_Server_Register_Return);
          

            //Net.AddResponser(Id<MSG_GC_TIME_SYNC>.Value, OnResponse_MSG_GC_TIME_SYNC);
            //Net.AddResponser(Id<MSG_GC_BLOWFISHKEY>.Value, OnResponse_MSG_GC_BLOWFISHKEY);
            //Net.AddResponser(Id<MSG_GC_HEARTBEAT>.Value, OnResponse_MSG_GC_HEARTBEAT);
        }

        public void OnResponse_MSG_Server_Register_Return(MemoryStream stream)
        {
            MSG_Server_Register_Return msg = MSG_Server_Register_Return.Parser.ParseFrom(stream);
            Console.WriteLine("register {0}", msg.ToString());

            //int mainId = ChoseOneLoginedServer();
            //Request_MSG_CB_USER_LOGIN(mainId);
        }



    }
}