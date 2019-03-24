
namespace PressureTestToolMaster
{
    public partial class Session
    {
        TcpAccepter _net;
        public TcpAccepter Net
        {
            get { return _net; }
        }

        private void CloseConnect()
        {
            Net.DisConnect(true);
        }
    }
}
