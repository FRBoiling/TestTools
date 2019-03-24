using ModelLibrary;
using System;
using System.Net;
using TestClient;

namespace TestClient
{
    public partial class Client
    {
        public Client()
        {
        }

        public void Init(string ip, int port)
        {
            //Log.WriteLine("init connect info ip {0} port {1}",ip,port);
            _host = new HostInfo(ip,port);
            _net = new TcpConnector();
            Net.Init();
            //Connect2Gate();
        }


        public void SetConnect(string ip, int port,int token) {
            Console.WriteLine("set connect info ip {0} port {1} key {2}",ip,port, token);
            _host.CurrntIp = ip;
            _host.Port = port;
            _host.CurrntKey = token.ToString();
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
            CloseConnect();
        }


        HostInfo _host;

        TcpConnector _net;

        public TcpConnector Net
        {
            get { return _net; }
        }

        public void Connect2Server()
        {
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
                Console.WriteLine("connected (ip {0} port {1})",_host.CurrntIp,_host.Port);
                //if (ProtocolPacket.blowFishInst == null)
                //{
                //    Request_BlowFishKey();
                //}
                Request_MSG_Server_Register();
            }
            return;
        }

        private void DisConnectComplete()
        {
            //Log.WriteLine("{0} disconnected!", Name);
            Console.WriteLine("disconnected (ip {0} port {1})",_host.CurrntIp,_host.Port);
            Exit();
            return;
        }

        private void CloseConnect()
        {
            if (Net != null)
            {
                Net.DisConnect(true);
            }
            //else
            //{
            //    Log.ErrorLine("Net is null,init connect!");
            //}
        }

        public bool IsConnected()
        {
            return Net.bConnected;
        }

    }
}
