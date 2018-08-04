using LogLibrary;
using ProtoBuffProtocolLibrary;
using System.Net;

namespace ProtoSendTool
{
    public partial class Client
    {
        HostInfo _host;

        ComnunicationClient _net;

        public ComnunicationClient Net
        {
            get {   return _net;  }
        }

        private void Connect2Gate()
        {
            BindProtocol();
            IPAddress serverIp = IPAddress.Parse(_host.CurrntIp);
            ushort serverPort = (ushort)_host.Port;
            Net.ConnectionCallback = ConnectComplete;
            Net.DisConnectionCallback = DisConnectComplete;
            Net.Connect(_host.CurrntIp, serverPort);
        }

        private void ConnectComplete(bool connect)
        {
            Log.WriteLine("{0} connected!", Name);
            if (connect)
            {
                //if (ProtocolPacket.blowFishInst == null)
                //{
                //    Request_BlowFishKey();
                //}
                //Request_Login();
            }
            return;
        }

        private void DisConnectComplete()
        {
            //Log.WriteLine("{0} disconnected!", Name);
            Exit();

            return;
        }

        private void CloseConnect()
        {
            Net.DisConnect(true);
        }
    }
}
