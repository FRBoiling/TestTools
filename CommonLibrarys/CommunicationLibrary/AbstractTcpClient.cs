using Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace TcpLib
{
    public abstract class AbstractTcpClient
    {
        private Tcp _tcp = new Tcp();
        public bool bConnected = true;
        public Tcp Tcp
        {
            get
            {
                return _tcp;
            }

            set
            {
                _tcp = value;
            }
        }
        private string _ip;
        private ushort _port;

        public AbstractTcpClient(string ip, ushort port)
        {
            _ip = ip;
            _port = port;
        }
        public AbstractTcpClient()
        {

        }

        public void Update()
        {
            OnProcessProtocol();
        }

        public void Init()
        {
            InitTcp();
        }

        private void InitTcp()
        {
            Tcp.OnConnect = OnConnet;
            Tcp.OnDisconnect = OnDiconnect;
            Tcp.OnRecv = OnRecv;
        }

        public abstract void Recv(MemoryStream stream);

        private  void OnRecv(MemoryStream stream)
        {
            Recv(stream);
        }

        public abstract void ProcessProtocol();

        public void OnProcessProtocol()
        {
            ProcessProtocol();
        }

        private bool OnDiconnect()
        {
            if (bConnected)
            {
                DisconnectComplete();
                Log.Warn("try to reconnect to server again!");
                Connect();
            }
            else
            {
                DisconnectComplete();
            }
            return true;
        }

        public virtual void DisconnectComplete()
        {
            bConnected = false;
            //Log.WriteLine("disconnected ");
        }

        private bool OnConnet(bool ret)
        {
            if (ret == true)
            {
                ConnectedComplete(ret);
            }
            else
            {
                Log.Warn("try to connect to server!");
                Thread.Sleep(2000);
                Connect();
            }
            return ret;
        }

        private void Connect()
        {
            Connect(_ip, _port);
        }

        public void Connect(string ip, ushort port)
        {
            _ip = ip;
            _port = port;
            if (Tcp == null)
            {
                Tcp = new Tcp();
                InitTcp();
            }
            if (!Tcp.Connect(ip, port))
            {
               
            }
            else
            {
                Thread.Sleep(1000);
            }
        }

        public virtual void ConnectedComplete(bool ret)
        {
            bConnected = ret;
            //Console.WriteLine("socket connected to {0} (loacl : {1})", Tcp.WorkSocket.RemoteEndPoint.ToString(), Tcp.WorkSocket.LocalEndPoint.ToString());
        }

        public void DisConnect(bool bExit)
        {
            bConnected = !bExit;
            Tcp.Disconnect();
        }
    }
}
