
namespace PressureTestToolMaster
{
    public partial class Session
    {
        private SessionMng _mng;
        public string Key = "";

        public ushort _listenPort = 9001;

        public Session(SessionMng mng, ushort port)
        {
            _mng = mng;
            _listenPort = port;
            Init();
        }

        public void Init()
        {
            _net = new TcpAccepter();
            Net.Init();
            Net.AccpetCallback = AccpetCallback;
            BindProtocol();
        }

        public void AccpetCallback(bool ret)
        {
            _mng.AddAccpetSession(this);
        }

        public void Update()
        {
            if (Net != null)
            {
                if (Net.bAccepted)
                {
                    Net.Update();
                }
            }
        }

        public void Exit()
        {
            ClearRequest();
            CloseConnect();
        }
    }
}
