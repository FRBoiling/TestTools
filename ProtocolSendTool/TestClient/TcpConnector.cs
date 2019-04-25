using NetPacketLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcpLib;

namespace TestClient
{
    public class TcpConnector : AbstractTcpClient
    {

        public ProtocolPacket packetHandler = new ProtocolPacket();

        protected Queue<Packet> m_msgQueue = new Queue<Packet>();
        protected Queue<Packet> m_deal_msgQueue = new Queue<Packet>();


        public override void ProcessProtocol()
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
                //OnResponse_Parser(msg.Msg, msg.MsgId);
                OnResponse(msg.Msg, msg.MsgId);//, msg.Uid);
            }
        }

        public delegate void Responser(MemoryStream stream);
        private Dictionary<uint, Responser> responsers = new Dictionary<uint, Responser>();

        public void AddResponser(uint id, Responser responser)
        {
            responsers.Add(id, responser);
        }

        public void OnResponse(MemoryStream stream, uint msgId)//,int uid)
        {
            Responser responser = null;
            if (responsers.TryGetValue(msgId, out responser))
            {
                //Log.Warn("got package id 0x{0}", Convert.ToString(msgId,16));
                // Log.Warn("got package id 0x{0:x}", msgId);
                responser(stream);
            }
            else
            {
                //Log.Warn("got unsupported package id 0x{0:x}", msgId);
            }
        }
        //public void OnResponse_Parser(MemoryStream stream, uint msgId)
        //{
        //    Parser.Responser_Parser(msgId, stream, DateTime.Now, 0);
        //    stream.Position = 0;
        //}

        public override void Recv(MemoryStream stream)
        {
            int offset = 0;
            int pos = 0;
            byte[] buffer = stream.GetBuffer();

            while (stream.Length > sizeof(UInt16))
            {
                UInt16 size = BitConverter.ToUInt16(buffer, offset);
                offset += sizeof(UInt16);
                if (size > stream.Length - offset)
                {
                    break;
                }
                Packet packet = packetHandler.Unpack(buffer, size, ref offset);
                lock (m_msgQueue)
                {
                    m_msgQueue.Enqueue(packet);
                }
                offset = (size + offset);
                pos = offset;
            }
            stream.Seek(pos, SeekOrigin.Begin);
        }

        public bool Send<T>(T msg) where T : Google.Protobuf.IMessage<T>
        {
            //if (packetHandler.BlowFishInst == null)
            {
                return packetHandler.Package(msg, Tcp.Send);
            }
            //else
            //{
            //    return packetHandler.CryptoPackage(msg, Tcp.Send);
            //}
        }

        public override void ConnectedComplete(bool ret)
        {
            base.ConnectedComplete(ret);
            bConnected = ret;
            if (bConnected)
            {
                //Log.Info("Connected success!(loacl:{0})", Tcp.WorkSocket.LocalEndPoint.ToString());
                ConnectionCallback(bConnected);
            }
        }

        public delegate void Connected(bool bConnected);
        public Connected ConnectionCallback;

        public override void DisconnectComplete()
        {
            base.DisconnectComplete();
            DisConnectionCallback();
        }



        public delegate void DisConnected();
        public DisConnected DisConnectionCallback;


    }
}
