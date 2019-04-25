using CryptoUtility;
using System;
using System.IO;
using Google.Protobuf;
using Message.IdGenerator;

namespace NetPacketLib
{
    struct PacketHeader
    {
        //public const int Size = 10;
        public const int Size = 8;
    }

    public class Packet
    {
        public uint MsgId;
        //public int Uid;
        public MemoryStream Msg;
        public Packet(uint msg_id)//, int uid)
        {
            MsgId = msg_id;
            //Uid = uid;
        }
    }

    public class ProtocolPacket
    {
        private BlowFish blowFishInst = null;
        public bool gettingBlowFishKey = false;

        public BlowFish BlowFishInst
        {
            get
            {
                return blowFishInst;
            }

            set
            {
                blowFishInst = value;
            }
        }

        public bool CryptoPackage<T>(T msg, Func<MemoryStream, MemoryStream, bool> func) where T : Google.Protobuf.IMessage
        {
            MemoryStream body = new MemoryStream();
            MessagePacker.ProtobufHelper.Serialize(body, msg);
            UInt16 protobufLen = (ushort)body.Length;

            if (blowFishInst != null && protobufLen > 0)
            {
                body = blowFishInst.Encrypt_CBC(body);
            }

            UInt16 len = (ushort)body.Length;
            MemoryStream header = new MemoryStream(PacketHeader.Size);

            header.Write(BitConverter.GetBytes(len), 0, 2);
            header.Write(BitConverter.GetBytes(protobufLen), 0, 2);
            header.Write(BitConverter.GetBytes(Id<T>.Value), 0, 4);

            return func(header, body);
        }

        public bool Package<T>(T msg, Func<MemoryStream, bool> func) where T : Google.Protobuf.IMessage
        {
            MemoryStream body = new MemoryStream();
           MessagePacker.ProtobufHelper.Serialize(body, msg);

            UInt16 protobufLen = (ushort)body.Length;
            UInt16 len = (ushort)body.Length;
            //if (blowFishInst != null && protobufLen > 0)
            //{
            //    body = blowFishInst.Encrypt_CBC(body);
            //}
            MemoryStream packet = new MemoryStream(PacketHeader.Size);

            packet.Write(BitConverter.GetBytes(len), 0, 2);
            packet.Write(BitConverter.GetBytes(protobufLen), 0, 2);
            packet.Write(BitConverter.GetBytes(Id<T>.Value), 0, 4);
            packet.Write(body.GetBuffer(), 0, len);

            return func(packet);
        }

        //public bool PackageNormal<T>(T msg, Func<MemoryStream, bool> func)
        //{
        //    MemoryStream body = new MemoryStream();
        //   MessagePacker.ProtobufHelper.Serialize(body, msg);

        //    UInt16 len = (ushort)body.Length;
        //    //if (blowFishInst != null && protobufLen > 0)
        //    //{
        //    //    body = blowFishInst.Encrypt_CBC(body);
        //    //}
        //    MemoryStream packet = new MemoryStream(PacketHeader.Size);

        //    packet.Write(BitConverter.GetBytes(len), 0, 2);
        //    packet.Write(BitConverter.GetBytes(Engine.Foundation.Id<T>.Value), 0, 4);
        //    packet.Write(body.GetBuffer(), 0, len);

        //    return func(packet);
        //}


        public Packet Unpack(Byte[] buffer, int size,ref int offset)
        {
            UInt32 msg_id = BitConverter.ToUInt32(buffer, offset);
            offset += sizeof(UInt32);

            Packet packet = new Packet(msg_id);//, uid);
                                               //if (uid>0)
                                               //{
            byte[] content = new byte[size];

            Array.Copy(buffer, offset, content, 0, size);
            packet.Msg = new MemoryStream(content, 0, size, true, true);
            //}
            //else
            //{
            //packet.Msg = new MemoryStream(buffer, offset, size, true, true);
            //}
            return packet;
        }

    }
}
