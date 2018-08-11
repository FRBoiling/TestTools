using LibLog;
using LibProtocolCodec;
using protocol.client;
using System.Net;

namespace ProtoSendLib
{
    public partial class Client
    {
        //public int Id;
        //public string Name;

        //public int Key;

        //public Client(int id, string name ,int key)
        //{
        //    Id = id;
        //    Name = name;
        //    Key = key;
        //}

        public Client()
        {
            PLAYER.IsLogin = false;
        }

        public void Init(string ip, int port)
        {
            Log.WriteLine("init connect info ip {0} port {1}", ip, port);
            _host = new HostInfo(ip, port, ip);
            _net = new ComnunicationClient();
            Net.Init();
            Connect2Gate();
        }

        public void Update()
        {
            if (Net != null)
            {
                Net.Update();
            }
        }


        public void Exit()
        {
            //ClearRequest();
            PLAYER.IsLogin = false;
            CloseConnect();
        }


        HostInfo _host;

        ComnunicationClient _net;

        public ComnunicationClient Net
        {
            get { return _net; }
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
            //Log.WriteLine("{0} connected!", Name);
            if (connect)
            {
                Log.WriteLine("connected");
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
            Log.WriteLine("disconnected");
            Exit();
            return;
        }

        private void CloseConnect()
        {
            Net.DisConnect(true);
        }

        public bool IsConnected()
        {
            return Net.bConnected;
        }

        public void BindProtocol()
        {
            ClientIdGenerater.GenerateId();

            BindResponse_Login();

            BindResponse();
        }
    }
}
