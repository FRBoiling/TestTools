using ProtoBuffProtocolLibrary;
using System.Net;
using System.Threading;

namespace ProtoSendTool
{
    public partial class Client
    {
        public int Id;
        public string Name;

        public int Key;

        public Client(int id, string name ,int key)
        {
            Id = id;
            Name = name;
            Key = key;
        }

        public void Init(string ip, int port)
        {
            _host = new HostInfo(ip,  port,  ip);
            _net = new ComnunicationClient();
            Net.Init();
            Connect2Gate();
        }

        public void Update()
        {
            Thread.Sleep(1);
            if (Net != null)
            {
                Net.Update();
            }
        }

        public void Exit()
        {
            //ClearRequest();
            CloseConnect();
        }
    }
}
