using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace IOCPLib
{
    public class AsyncUserToken
    {
        private SocketAsyncEventArgs _receiveEventArgs;

        public SocketAsyncEventArgs ReceiveEventArgs
        {
            get { return _receiveEventArgs; }
            set { _receiveEventArgs = value; }
        }
        private SocketAsyncEventArgs _sendEventArgs;

        public SocketAsyncEventArgs SendEventArgs
        {
            get { return _sendEventArgs; }
            set { _sendEventArgs = value; }
        }

        private AsyncSendBufferManager _sendBuffer;

        public AsyncSendBufferManager SendBuffer
        {
            get { return _sendBuffer; }
            set { _sendBuffer = value; }
        }

        protected byte[] _asyncReceiveBuffer;

        private DynamicBufferManager _receiveBuffer;

        public DynamicBufferManager ReceiveBuffer
        {
            get { return _receiveBuffer; }
            set { _receiveBuffer = value; }
        }

        private Socket _connectSocket;

        public Socket ConnectSocket
        {
            get { return _connectSocket; }
            set { _connectSocket = value; }
        }

        private DateTime _connectDateTime;

        public DateTime ConnectDateTime
        {
            get { return _connectDateTime; }
            set { _connectDateTime = value; }
        }

        private DateTime _activeDateTime;

        public DateTime ActiveDateTime
        {
            get { return _activeDateTime; }
            set { _activeDateTime = value; }
        }

        public AsyncUserToken(int asyncReceiveBufferSize)
        {
            _connectSocket = null;
            _receiveEventArgs = new SocketAsyncEventArgs();
            _receiveEventArgs.UserToken = this;
            _asyncReceiveBuffer = new byte[asyncReceiveBufferSize];
            _receiveEventArgs.SetBuffer(_asyncReceiveBuffer, 0, _asyncReceiveBuffer.Length);
            _receiveBuffer = new DynamicBufferManager(10);

            _sendEventArgs = new SocketAsyncEventArgs();
            _sendEventArgs.UserToken = this;
            _sendBuffer = new AsyncSendBufferManager(10);
        }
    }
}
