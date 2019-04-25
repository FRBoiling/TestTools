using System.Net.Sockets;
using System.Text;

namespace TcpLib
{
    public class StateObject
    {
        public Socket workSocket = null;
        public const int BufferSize = 1024*6;
        public int offset;

        public byte[] buffer = new byte[BufferSize];
        public StringBuilder sb = new StringBuilder();
    }
}
