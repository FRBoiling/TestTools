using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;


namespace IOCPLib
{
    public class AsyncSocketClient
    {
        private Boolean _bConnected = false;

        private IPAddress _serverAddress;

        private int _serverPort;

        private IPEndPoint _remoteEndPoint;

        private AsyncUserToken _userToken;

        protected bool _sendAsync;

        private int _receiveBufferSize = 1024 * 4;

        public AsyncSocketClient()
        {
            _sendAsync = false;
        }

        public AsyncSocketClient(IPAddress serverIp, int serverPort)
        {
            this._serverPort = serverPort;
            this._serverAddress = serverIp;
            this._remoteEndPoint = new IPEndPoint(serverIp, serverPort);
            _sendAsync = false;
        }

        public void Init()
        {
            _userToken = new AsyncUserToken(_receiveBufferSize);
            _userToken.ReceiveEventArgs.Completed += new EventHandler<SocketAsyncEventArgs>(OnIOCompleted);
            _userToken.SendEventArgs.Completed += new EventHandler<SocketAsyncEventArgs>(OnIOCompleted);
        }

        public void Update()
        {
            OnProcessProtoacl();
        }

        private void OnIOCompleted(object sender, SocketAsyncEventArgs asyncEventArgs)
        {
            AsyncUserToken userToken = asyncEventArgs.UserToken as AsyncUserToken;
            userToken.ActiveDateTime = DateTime.Now;
            try
            {
                lock (userToken)
                {
                    switch (asyncEventArgs.LastOperation)
                    {
                        //case SocketAsyncOperation.Accept:
                        //    break;
                        //case SocketAsyncOperation.Connect:
                        //    break;
                        //case SocketAsyncOperation.Disconnect:
                        //    break;
                        //case SocketAsyncOperation.None:
                        //    break;
                        case SocketAsyncOperation.Receive:
                            ProcessReceive(asyncEventArgs);
                            break;
                        //case SocketAsyncOperation.ReceiveFrom:
                        //    break;
                        //case SocketAsyncOperation.ReceiveMessageFrom:
                        //    break;
                        case SocketAsyncOperation.Send:
                            ProcessSend(asyncEventArgs);
                            break;
                        //case SocketAsyncOperation.SendPackets:
                        //    break;
                        //case SocketAsyncOperation.SendTo:
                        //    break;
                        default:
                            throw new ArgumentException("the last operation completed on the socket was not a receive or send type");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("IO_Completed {0} error,message:{1}", userToken.ConnectSocket, e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        public void Connect(IPAddress serverIp, int serverPort)
        {
            this._serverPort = serverPort;
            this._serverAddress = serverIp;
            this._remoteEndPoint = new IPEndPoint(_serverAddress, _serverPort);
            Connect(this._remoteEndPoint);
        }

        public void Connect(string ip, ushort serverPort)
        {
            this._serverPort = serverPort;
            this._serverAddress = IPAddress.Parse(ip);
            this._remoteEndPoint = new IPEndPoint(_serverAddress, _serverPort);
            Connect(this._remoteEndPoint);
        }


        public void Connect(IPEndPoint serverEndPoint)
        {
            _userToken.ConnectSocket = new Socket(_remoteEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
         
            SocketAsyncEventArgs connectArgs = new SocketAsyncEventArgs();
            connectArgs.UserToken = _userToken;
            connectArgs.RemoteEndPoint = serverEndPoint;
            connectArgs.Completed += new EventHandler<SocketAsyncEventArgs>(OnConnectecdCompleted);

            bool willRaiseEvent = _userToken.ConnectSocket.ConnectAsync(connectArgs);
            if (!willRaiseEvent)
            {
                ProcessConnected(connectArgs);
            }
        }

        private void OnConnectecdCompleted(object sender, SocketAsyncEventArgs connectEventArgs)
        {
            _bConnected = (connectEventArgs.SocketError == SocketError.Success);
            if (_bConnected)
            {
                _userToken.ConnectSocket = connectEventArgs.ConnectSocket;
                ProcessConnected(connectEventArgs);
            }
        }

        private void ProcessConnected(SocketAsyncEventArgs connectArgs)
        {
            if (connectArgs.SocketError == SocketError.Success)
            {
                Console.WriteLine("connected->Local Address:{0},Remote Address:{1}", connectArgs.ConnectSocket.LocalEndPoint, connectArgs.ConnectSocket.RemoteEndPoint);
                if (connectArgs.ConnectSocket.Connected)
                {
                    bRun = true;
                    _userToken.ConnectDateTime = DateTime.Now;
                    _userToken.ConnectSocket = connectArgs.ConnectSocket;
                    try
                    {
                        bool willRaiseEvent = _userToken.ConnectSocket.ReceiveAsync(_userToken.ReceiveEventArgs);
                        if (!willRaiseEvent)
                        {
                            lock (_userToken)
                            {
                                ProcessReceive(_userToken.ReceiveEventArgs);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("connect {0} error,message:{1}",_userToken.ConnectSocket,e.Message);
                        Console.WriteLine(e.StackTrace);
                    }
                }
            }
        }

        private void ProcessReceive(SocketAsyncEventArgs recvEventArgs)
        {
            AsyncUserToken userToken = recvEventArgs.UserToken as AsyncUserToken;
            if (userToken.ConnectSocket == null)
            {
                Console.WriteLine("ProcessReceive userToken.ConnectSocket is null");
                return;
            }
            else
            {
                if (recvEventArgs.SocketError == SocketError.Success)
                {
                    if (userToken.ReceiveEventArgs.BytesTransferred > 0)
                    {
                        if (userToken.ConnectSocket.Available == 0)
                        {
                            userToken.ActiveDateTime = DateTime.Now;
                            int offset = userToken.ReceiveEventArgs.Offset;
                            int count = userToken.ReceiveEventArgs.BytesTransferred;

                            if (count > 0)
                            {
                                if (!ProcessReceive(userToken.ReceiveEventArgs.Buffer, offset, count))
                                {
                                    CloseSocket();
                                }
                                else
                                {
                                    bool willRaiseEvent = userToken.ConnectSocket.ReceiveAsync(userToken.ReceiveEventArgs);
                                    if (!willRaiseEvent)
                                    {
                                        ProcessReceive(userToken.ReceiveEventArgs);
                                    }
                                }
                            }
                            else
                            {
                                bool willRaiseEvent = userToken.ConnectSocket.ReceiveAsync(userToken.ReceiveEventArgs);
                                if (!willRaiseEvent)
                                {
                                    ProcessReceive(userToken.ReceiveEventArgs);
                                }
                            }
                        }
                    }
                }
                else
                {
                    CloseSocket();
                }
            }
        }

        private bool ProcessReceive(byte[] buffer, int offset, int count)
        {
            DynamicBufferManager receiveBuffer = _userToken.ReceiveBuffer;

            receiveBuffer.WriteBuffer(buffer, offset, count);

            if (receiveBuffer.DataCount >= sizeof(UInt16) + sizeof(UInt32))
            {
                bool result = ProcessPacket(receiveBuffer.Buffer, offset, count);
                if (result)
                {
                    receiveBuffer.Clear(count);
                }
                return result;
            }
            return true;
        }

        protected Queue<KeyValuePair<UInt32, MemoryStream>> m_msgQueue = new Queue<KeyValuePair<uint, MemoryStream>>();
        protected Queue<KeyValuePair<UInt32, MemoryStream>> m_deal_msgQueue = new Queue<KeyValuePair<uint, MemoryStream>>();

        private bool ProcessPacket(byte[] buffer, int offset, int count)
        {
           //while (count - offset >= sizeof(UInt16))
           {
                UInt16 size = BitConverter.ToUInt16(buffer, offset);
                if (size + sizeof(UInt16) + sizeof(Int32) > count - offset)
                {
                   //break;
                }
                UInt32 msg_id = BitConverter.ToUInt32(buffer, offset + sizeof(UInt16));
                MemoryStream msg = new MemoryStream(buffer, offset + sizeof(UInt16) + sizeof(Int32), size, true, true);
                lock (m_msgQueue)
                {
                    m_msgQueue.Enqueue(new KeyValuePair<uint, MemoryStream>(msg_id, msg));
                }
                offset += (size + sizeof(UInt16) + sizeof(Int32));
           }
            return true;
        }

        public void OnProcessProtoacl()
        {
            lock (m_msgQueue)
            {
                while (m_msgQueue.Count > 0)
                {
                    var msg = m_msgQueue.Dequeue();
                    m_deal_msgQueue.Enqueue(msg);
                }
            }
            while (m_deal_msgQueue.Count > 0)
            {
                var msg = m_deal_msgQueue.Dequeue();
                OnResponse(msg.Key, msg.Value);
            }
        }

        private void OnResponse(uint id, MemoryStream stream)
        {
            try
            {
                Response(id, stream);
            }
            catch (Exception e)
            {
                Console.WriteLine("OnResponse Error:({0}) {1}",id,e.ToString());
            }
        }
        
        public void Response(uint id,MemoryStream stream)
        {
            Responser responser = null;
            if (_responsers.TryGetValue(id, out responser))
            {
                responser(stream);
            }
            else
            {
                Console.WriteLine("got unsupported packet {0}", id);
            }
        }


        public delegate bool Responser(MemoryStream stream);

        private Dictionary<uint, Responser> _responsers = new Dictionary<uint, Responser>();



        public void AddResponser(uint id,Responser responser)
        {
            _responsers.Add(id,responser);
        }

        //public virtual bool Send<T>(T msg) where T : global::ProtoBuf.IExtensible
        //{
        //    MemoryStream body = new MemoryStream();
        //  MessagePacker.ProtobufHelper.Serialize(body, msg);

        //    MemoryStream head = new MemoryStream(sizeof(ushort) + sizeof(uint));
        //    ushort len = (ushort)body.Length;
        //    head.Write(BitConverter.GetBytes(len),0,2);
        //    head.Write(BitConverter.GetBytes(Id<T>.Value),0,4);
        //    return Send(head, body);
        //}

        public bool Send(MemoryStream head,MemoryStream body)
        {
            head.Seek(0, SeekOrigin.Begin);
            body.Seek(0, SeekOrigin.Begin);
            if (body.Length == 0)
            {
                return Send(head);
            }
            else
            {
                AsyncSendBufferManager asyncSendBufferManager = _userToken.SendBuffer;
                asyncSendBufferManager.StartPacket();
                asyncSendBufferManager.DynamicBufferManager.WriteBuffer(head.GetBuffer(), 0, (int)head.Length);
                asyncSendBufferManager.DynamicBufferManager.WriteBuffer(body.GetBuffer(), 0, (int)body.Length);
                asyncSendBufferManager.EndPacket();
                bool result = true;
                if (!_sendAsync)
                {
                    int packetOffset = 0;
                    int packetCount = 0;
                    if (asyncSendBufferManager.GetFristPacket(ref packetOffset, ref packetCount))
                    {
                        _sendAsync = true;
                        result = SendAsyncEvent(_userToken.ConnectSocket, _userToken.SendEventArgs, asyncSendBufferManager.DynamicBufferManager.Buffer, packetOffset, packetCount);
                        return result;
                    }
                }
            }
            return true;
        }

        public bool Send(MemoryStream stream)
        {
            if (stream.Length == 0)
            {
                return true;
            }
            else
            {
                AsyncSendBufferManager asyncSendBufferManager = _userToken.SendBuffer;
                asyncSendBufferManager.StartPacket();
                asyncSendBufferManager.DynamicBufferManager.WriteBuffer(stream.GetBuffer(), 0, (int)stream.Length);
                asyncSendBufferManager.EndPacket();
                bool result = true;
                if (!_sendAsync)
                {
                    int packetOffset = 0;
                    int packetCount = 0;
                    if (asyncSendBufferManager.GetFristPacket(ref packetOffset, ref packetCount))
                    {
                        _sendAsync = true;
                        result = SendAsyncEvent(_userToken.ConnectSocket, _userToken.SendEventArgs, asyncSendBufferManager.DynamicBufferManager.Buffer, packetOffset, packetCount);
                        return result;
                    }
                }
            }
            return true;
        }

        public bool SendAsyncEvent(Socket connectSocket, SocketAsyncEventArgs sendEventArgs, byte[] buffer, int offset, int count)
        {
            if (connectSocket == null)
            {
                return false;
            }
            sendEventArgs.SetBuffer(buffer, offset, count);
            bool willRaiseEvent = connectSocket.SendAsync(sendEventArgs);
            if (!willRaiseEvent)
            {
                return ProcessSend(sendEventArgs);
            }
            else
            {
                return true;
            }
        }

        private bool ProcessSend(SocketAsyncEventArgs sendEventArgs)
        {
            AsyncUserToken userToken = sendEventArgs.UserToken as AsyncUserToken;
            if (sendEventArgs.SocketError == SocketError.Success)
            {
                if (_userToken.ConnectSocket == null)
                {
                    Console.WriteLine("ProcessSend userToken. socket is null");
                    return false;
                }
                else
                {
                    _userToken.ActiveDateTime = DateTime.Now;
                    return SendCompleted();
                }
            }
            else
            {
                CloseSocket();
                return false;
            }
        }

        private bool SendCompleted()
        {
            _sendAsync = false;
            AsyncSendBufferManager asyncSendBufferManager = _userToken.SendBuffer;
            asyncSendBufferManager.ClearFirstPacket();
            int offset = 0;
            int count = 0;
            if (asyncSendBufferManager.GetFristPacket(ref offset, ref count))
            {
                return SendAsyncEvent(_userToken.ConnectSocket, _userToken.SendEventArgs, asyncSendBufferManager.DynamicBufferManager.Buffer, offset, count);
            }
            else
            {
                return SendCallback();
            }
        }

        public virtual bool SendCallback()
        {
            return true;
        }

        private void CloseSocket()
        {
            if (_userToken.ConnectSocket == null)
            {
                return;
            }

            string socketInfo = string.Format("Locsl Address:{0} Remote Address:{1}", _userToken.ConnectSocket.LocalEndPoint, _remoteEndPoint);
            Console.WriteLine("Disconnected from server. {0}", socketInfo);
            try
            {
                _userToken.ConnectSocket.Shutdown(SocketShutdown.Both);
            }
            catch (Exception e)
            {
                Console.WriteLine("CloseSocket {0} error,message:{1}", socketInfo, e.Message);
            }
            finally
            {
                _userToken.ConnectSocket.Close();
                _userToken.ConnectSocket = null;
            }
        }

        public bool bRun = true;

        public void DisConnect()
        {
            bRun = false;
            CloseSocket();
        }
    }
}
