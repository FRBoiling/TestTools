using Protocol.Server.Register;
using System;
using System.IO;

namespace PressureTestToolMaster
{
    public partial class Session
    {
        public void BindResponse()
        {
            Net.AddResponser(Protocol.MsgId.Id<MSG_Server_Register>.Value, OnResponse_Register);
        }

        private void OnResponse_Register(MemoryStream stream)
        {
            MSG_Server_Register msg = MSG_Server_Register.Parser.ParseFrom(stream);
            
            Console.WriteLine("register {0}",msg.ToString());
            _mng.AddSession(this);

            MSG_Server_Register_Return returnMsg = new MSG_Server_Register_Return();
            returnMsg.Result = 0;
            returnMsg.Tag = msg.Tag;
            Net.Send(returnMsg);
        }

    }
}
