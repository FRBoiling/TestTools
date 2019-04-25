using System.IO;
using System.Threading;

namespace TcpLib
{
    public abstract class AbstractTcpServer
    {
        private Tcp _tcp = new Tcp();
        public bool bAccepted = true;
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

        private ushort _port;

        public AbstractTcpServer(ushort port)
        {
            _port = port;
        }

        public AbstractTcpServer()
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
            Tcp.OnAccept= OnAccept;
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
            if (bAccepted)
            {
                DisconnectComplete();
                Listen(_port);
            }
            else
            {
                DisconnectComplete();
            }
            return true;
        }

        public virtual void DisconnectComplete()
        {
            bAccepted = false;
            //Log.WriteLine("disconnected ");
        }

        private bool OnAccept(bool ret)
        {
            if (ret == true)
            {
                AcceptComplete(ret);
            }
            else
            {
                Thread.Sleep(2000);
            }
            return ret;
        }

        public void Listen(ushort port)
        {
            _port = port;
            if (Tcp == null)
            {
                Tcp = new Tcp();
                InitTcp();
            }
            if (!Tcp.Listen(port))
            {
               
            }
            else
            {
                Thread.Sleep(1000);
            }
        }

        public virtual void AcceptComplete(bool ret)
        {
            bAccepted = ret;
            //Console.WriteLine("socket AcceptComplete to {0} (loacl : {1})", Tcp.WorkSocket.RemoteEndPoint.ToString(), Tcp.WorkSocket.LocalEndPoint.ToString());
        }

        public void DisConnect(bool bExit)
        {
            bAccepted = !bExit;
            Tcp.Disconnect();
        }
    }
}
