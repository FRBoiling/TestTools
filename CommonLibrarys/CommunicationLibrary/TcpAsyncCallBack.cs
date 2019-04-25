using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpLibrary
{
    public class TcpAsyncCallBack
    {
        public delegate bool AsyncConnectCallback(bool ret);
        public delegate bool AsyncAcceptCallback(bool ret);
        public delegate void AsyncReadCallback(MemoryStream stream);
        public delegate bool AsyncDisconnectCallback();
    }
}
