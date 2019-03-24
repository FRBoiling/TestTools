using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using TcpLibrary;
using UtilityLibrary;

namespace TcpLib
{
    public class TcpMgr : Singleton<TcpMgr>
    {
        Dictionary<ushort, Socket> _listeners = new Dictionary<ushort, Socket>();

        public delegate void ListenHeartBeatCallBack(ushort port);
        Dictionary<ushort, ListenHeartBeatCallBack> _heartBeatListenCallBacks = new Dictionary<ushort, ListenHeartBeatCallBack>();

        private int _listenBackLog = 10;

        public void AddListenSocket(ushort port, Socket socket)
        {
            _listeners.Add(port, socket);
        }

        public Socket GetListenSocket(ushort port)
        {
            Socket socket = null;
            _listeners.TryGetValue(port, out socket);
            return socket;
        }

        public Socket Bind(ushort port,int backLog=10)
        {
            _listenBackLog = backLog;
            return GetListen(port);
        }

        public void Listen(ushort port,ListenHeartBeatCallBack callBack)
        {
            ListenHeartBeatCallBack hearBackCallBack;
            if (_heartBeatListenCallBacks.TryGetValue(port,out hearBackCallBack))
            {
                for (int i = 0; i < _listenBackLog; i++)
                {
                    hearBackCallBack(port);
                }
            }
            else
            {
                _heartBeatListenCallBacks.Add(port, callBack);
                for (int i = 0; i < _listenBackLog; i++)
                {
                    callBack(port);
                }
            }
        }

        public void Listen(ushort port)
        {
            ListenHeartBeatCallBack listenCallBack;
            if (_heartBeatListenCallBacks.TryGetValue(port,out listenCallBack))
            {
                listenCallBack(port);
            }
            else
            {
                _heartBeatListenCallBacks.Add(port, DefaultListen);
                DefaultListen(port);
            }
        }

        private void DefaultListen(ushort port)
        {
            new Tcp().Listen(port, _listenBackLog);
        }

        private Socket GetListen(ushort port)
        {
            Socket listenSocket = GetListenSocket(port);
            if (listenSocket == null)
            {
                listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, port);
                listenSocket.Bind(ep);
                listenSocket.Listen(_listenBackLog);
                AddListenSocket(port, listenSocket);
                return listenSocket;
            }
            else
            {
                return listenSocket;
            }
        }

        public delegate void CallBackDisconnect();
        ConcurrentQueue<TcpAsyncCallBack.AsyncDisconnectCallback> _disconnectCallBacks = new ConcurrentQueue<TcpAsyncCallBack.AsyncDisconnectCallback>();
        
        public void  AddDisconnectExec(TcpAsyncCallBack.AsyncDisconnectCallback callback)
        {
            _disconnectCallBacks.Enqueue(callback);
        } 

        public void Process()
        {
            TcpAsyncCallBack.AsyncDisconnectCallback callback;
            while (_disconnectCallBacks.Count>0)
            {
                if (_disconnectCallBacks.TryDequeue(out callback))
                {
                    if (callback!=null)
                    {
                        try
                        {
                            callback();
                        }
                        catch (Exception e)
                        {
                        }
                    }
                }
            }
        }
    }
}
