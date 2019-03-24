using Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TcpLib
{
    public class Tcp
    {
        private Socket _workSocket = null;

        public Socket WorkSocket
        {
            get { return _workSocket; }
            set { _workSocket = value; }
        }

        public ushort _listenPort;

        public bool Listen(ushort port,int backlog=10)
        {
            try
            {
                _listenPort = port;
                Socket socket = TcpMgr.inst.GetListenSocket(port);
                if (socket == null)
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPEndPoint ep = new IPEndPoint(IPAddress.Any, port);
                    socket.Bind(ep);
                    socket.Listen(1);
                    socket.SendBufferSize = 16384;

                    TcpMgr.inst.AddListenSocket(port, socket);
                }
                socket.BeginAccept(new AsyncCallback(AcceptCallBack), socket);
            }
            catch (Exception e)
            {
                Console.WriteLine("connect error:{0}", e.ToString());
                return false;
            }
            return true;
        }
        private void AcceptCallBack(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            if (socket == null)
            {
                OnAccept(false);
                return;
            }
            TcpMgr.inst.Listen(_listenPort);
            try
            {
               _workSocket =  socket.EndAccept(ar);
                Recv(_workSocket);
                OnAccept(true);
            }
            catch (Exception e)
            {
                Console.Write(e);
                OnAccept(false);
            }
        }

        public delegate bool AsyncAcceptCallback(bool ret);
        private AsyncAcceptCallback onAccept = DefaultOnAccept;
        public AsyncAcceptCallback OnAccept
        {
            set { onAccept = value; }
            get { return onAccept; }
        }

        private static bool DefaultOnAccept(bool ret)
        {
            Console.WriteLine("default on accept function called, check it");
            return true;
        }


        public bool Connect(string ip, ushort port)
        {
            if (_workSocket != null)
            {
                return false;
            }
            else
            {
                IPAddress ipAddress = IPAddress.Parse(ip);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);
                try
                {
                    Socket socket = null;
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.BeginConnect(remoteEP, new AsyncCallback(ConnectCallback), socket);
                }
                catch (Exception e)
                {
                    Console.WriteLine("connect error:{0}", e.ToString());
                    return false;
                }
            }
            return true;
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            if (socket == null)
            {
                OnConnect(false);
                return;
            }
            try
            {
                socket.EndConnect(ar);
                Recv(socket);
                OnConnect(true);
            }
            catch (Exception e)
            {
                Console.Write(e);
                OnConnect(false);
            }
        }

        public delegate bool AsyncConnectCallback(bool ret);
        private AsyncConnectCallback onConnect = DefaultOnConnect;
        public AsyncConnectCallback OnConnect
        {
            set { onConnect = value; }
            get { return onConnect; }
        }
        private static bool DefaultOnConnect(bool ret)
        {
            Console.WriteLine("default on connect function called, check it");
            return true;
        }

        private void Recv(Socket socket)
        {
            try
            {
                StateObject state = new StateObject();
                state.workSocket = socket;
                _workSocket = socket;
                socket.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, new AsyncCallback(RecvCallback), state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void RecvCallback(IAsyncResult ar)
        {
            SocketError error;
            StateObject state = (StateObject)ar.AsyncState;
            Socket socket = state.workSocket;
            if (socket == null)
            {
                return;
            }

            try
            {
                int len = (int)socket.EndReceive(ar, out error);
                if (len <= 0)
                {
                    Disconnect();
                    return;
                }
                //Log.WriteLine("Recv {0} bytes", len);
                len = state.offset + len;
                MemoryStream transferred = new MemoryStream(state.buffer, 0, len, true, true);

                if (OnRecv != null)
                {
                    OnRecv(transferred);
                }

                state.offset = len - (int)transferred.Position;

                if (state.offset <0)
                {
                    Disconnect();
                    return;
                }
             
                int size = 16384;
                if (transferred.Position == 0)
                {
                    size = (int)(transferred.Length * 2);
                }

                if (size > 65535)
                {
                    Disconnect();
                    return;
                }

                byte[] buffer = new byte[size];
                Array.Copy(state.buffer, transferred.Position, buffer, 0, state.offset);
                state.buffer = buffer;
                socket.BeginReceive(state.buffer, state.offset, size - state.offset, SocketFlags.None, new AsyncCallback(RecvCallback), state);

                return;
            }
            catch (Exception e)
            {
                Disconnect();
            }
        }

        public delegate void AsyncRecvCallback(MemoryStream stream);
        private AsyncRecvCallback onRecv = DefaultOnRecv;
        public AsyncRecvCallback OnRecv
        {
            set { onRecv = value; }
            get { return onRecv; }
        }
        private static void DefaultOnRecv(MemoryStream stream)
        {
            stream.Seek(0, SeekOrigin.End);
        }

        IList<ArraySegment<byte>> _sendStreams = new List<ArraySegment<byte>>();
        IList<ArraySegment<byte>> _waitStreams = new List<ArraySegment<byte>>();

        public bool Send(MemoryStream stream)
        {
            if (stream.Length == 0) return true;
            stream.Seek(0, SeekOrigin.Begin);
            ArraySegment<byte> segment = new ArraySegment<byte>(stream.GetBuffer(), 0, (int)stream.Length);
            if (_sendStreams.Count == 0)
            {
                _sendStreams.Add(segment);

                try
                {
                    _workSocket.BeginSend(_sendStreams, SocketFlags.None, SendCallback, _workSocket);
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            else
            {
                _waitStreams.Add(segment);
            }
            return true;
        }

        public bool Send(MemoryStream head, MemoryStream body)
        {
            head.Seek(0, SeekOrigin.Begin);
            body.Seek(0, SeekOrigin.Begin);

            if (body.Length == 0)
            {
                return Send(head);
            }

            lock (this)
            {
                ArraySegment<byte> first = new ArraySegment<byte>(head.GetBuffer(), 0, (int)head.Length);
                ArraySegment<byte> second = new ArraySegment<byte>(body.GetBuffer(), 0, (int)body.Length);
                if (_sendStreams.Count == 0)
                {
                    _sendStreams.Add(first);
                    _sendStreams.Add(second);
                    try
                    {
                        _workSocket.BeginSend(_sendStreams, SocketFlags.None, SendCallback, _workSocket);
                    }
                    catch (Exception e)
                    {
                        Log.Error(e);
                        return false;
                    }
                }
                else
                {
                    _waitStreams.Add(first);
                    _waitStreams.Add(second);
                }
            }
            return true;
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket socket = (Socket)ar.AsyncState;
                int len = socket.EndSend(ar);

                _sendStreams.Clear();
                if (_waitStreams.Count > 0)
                {
                    IList<ArraySegment<byte>> temp = _sendStreams;
                    _sendStreams = _waitStreams;
                    _waitStreams = temp;
                    socket.BeginSend(_sendStreams, SocketFlags.None, SendCallback, socket);
                }

            }
            catch (Exception e)
            {
            }
        }

        public delegate bool AsyncDisconnectCallback();
        private AsyncDisconnectCallback onDistonnect = DefaultOnDisconncect;
        public AsyncDisconnectCallback OnDisconnect
        {
            set { onDistonnect = value; }
            get { return onDistonnect; }
        }
        private static bool DefaultOnDisconncect()
        {
            Console.WriteLine("default on disconnect function called, check it");
            return true;
        }


        public void Disconnect()
        {
            if (_workSocket == null)
            {
                return;
            }
            else
            {
                lock (this)
                {
                    _workSocket.Close();
                    _workSocket = null;
                    _waitStreams.Clear();
                    _sendStreams.Clear();
                    OnDisconnect();
                }
            }
        }



    }
}
