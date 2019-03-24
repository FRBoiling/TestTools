using System;
using System.IO;

namespace PressureTestToolMaster
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
        //public bool CryptoPackage<T>(T msg, Func<MemoryStream, MemoryStream, bool> func)
        //{
        //    MemoryStream body = new MemoryStream();
        //    ProtoBuf.Serializer.Serialize(body, msg);
        //    UInt16 protobufLen = (ushort)body.Length;

        //    if (blowFishInst != null && protobufLen > 0)
        //    {
        //        body = blowFishInst.Encrypt_CBC(body);
        //    }

        //    UInt16 len = (ushort)body.Length;
        //    MemoryStream header = new MemoryStream(PacketHeader.Size);

        //    header.Write(BitConverter.GetBytes(len), 0, 2);
        //    header.Write(BitConverter.GetBytes(protobufLen), 0, 2);
        //    header.Write(BitConverter.GetBytes(Engine.Foundation.Id<T>.Value), 0, 4);

        //    return func(header, body);
        //}

        //public bool Package<T>(T msg, Func<MemoryStream, bool> func)
        //{
        //    MemoryStream body = new MemoryStream();
        //    ProtoBuf.Serializer.Serialize(body, msg);

        //    UInt16 protobufLen = (ushort)body.Length;
        //    UInt16 len = (ushort)body.Length;
        //    //if (blowFishInst != null && protobufLen > 0)
        //    //{
        //    //    body = blowFishInst.Encrypt_CBC(body);
        //    //}
        //    MemoryStream packet = new MemoryStream(PacketHeader.Size);

        //    packet.Write(BitConverter.GetBytes(len), 0, 2);
        //    packet.Write(BitConverter.GetBytes(protobufLen), 0, 2);
        //    packet.Write(BitConverter.GetBytes(Engine.Foundation.Id<T>.Value), 0, 4);
        //    packet.Write(body.GetBuffer(), 0, len);

        //    return func(packet);
        //}
        public bool Package1<T>(T msg, Func<MemoryStream, bool> func, uint msgid) where T : Google.Protobuf.IMessage<T>
        {
            MemoryStream body = new MemoryStream();
            Google.Protobuf.CodedOutputStream outbody = new Google.Protobuf.CodedOutputStream(body);
            outbody.WriteGroup(msg);
            outbody.Flush();
            UInt16 protobufLen = (ushort)body.Length;
            UInt16 len = (ushort)body.Length;
            //if (blowFishInst != null && protobufLen > 0)
            //{
            //    body = blowFishInst.Encrypt_CBC(body);
            //}
            MemoryStream packet = new MemoryStream(PacketHeader.Size);

            packet.Write(BitConverter.GetBytes(len), 0, 2);
            //packet.Write(BitConverter.GetBytes(protobufLen), 0, 2);
            packet.Write(BitConverter.GetBytes(msgid), 0, 4);
            packet.Write(body.GetBuffer(), 0, len);

            return func(packet);
        }

        //public bool PackageNormal<T>(T msg, Func<MemoryStream, bool> func)
        //{
        //    MemoryStream body = new MemoryStream();
        //    ProtoBuf.Serializer.Serialize(body, msg);

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
            offset += sizeof(UInt16);
            UInt32 msg_id = BitConverter.ToUInt32(buffer, offset);
            offset += sizeof(UInt32);

            Packet packet = new Packet(msg_id);//, uid);
                                               //if (uid>0)
                                               //{
                                               //    byte[] content = new byte[size];

            //    Array.Copy(buffer, offset + PacketHeader.Size, content, 0, size);
            //    packet.Msg = new MemoryStream(content, 0, size, true, true);
            //}
            //else
            //{
            packet.Msg = new MemoryStream(buffer, offset, size, true, true);
            //}
            return packet;
        }

    }
}
