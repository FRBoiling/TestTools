namespace ModelLibrary
{
    public class HostInfo
    {
        private string key;

        private string ip;

        private int port;

        public string Key { get => key; }
        public string Ip { get => ip; }
        public int Port { get => port; }

        public HostInfo(string ip = "127.0.0.1", int port = 9001, string key = "")
        {
            this.key = key;
            this.ip = ip;
            this.port = port;
        }
    }
}
