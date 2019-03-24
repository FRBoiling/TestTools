using Protocol.Server.Register;

namespace TestClient
{
    public partial class Client
    {
        public void Request_MSG_Server_Register()
        {
            MSG_Server_Register msg = new MSG_Server_Register();
            msg.Tag = new Server_Tag();
            msg.Tag.GroupId = 111;
            msg.Tag.ServerType = 222;
            msg.Tag.SubId = 33;
            _net.Send(msg);
        }


    }
}