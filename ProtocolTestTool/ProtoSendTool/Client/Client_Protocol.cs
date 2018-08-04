namespace ProtoSendTool
{
    public partial class Client
    {
        public void BindProtocol()
        {
            Message.Server.Gate.Protocol.GateC.Api.GenerateId();
            Message.Server.Client.Protocol.CGate.Api.GenerateId();

            BindResponse_Login();

            BindResponse();
        }

      

    
    }
}
