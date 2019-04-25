using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtocolCatchMsgLogLib;
using Google.Protobuf;
using Logger;

namespace MessagePacker
{
    public class ProtobufHelper
    {
        public static T Deserialize<T>(MemoryStream stream) where T : Google.Protobuf.IMessage
        {
            T msg = Activator.CreateInstance<T>();
            msg.MergeFrom(stream.GetBuffer(),(int)stream.Position,(int)stream.Length);
#if DEBUG
            Log.Debug("{0}>>{1}",msg.Descriptor.Name,msg.ToString());
#endif
            return msg;
        }

        public static void Serialize<T>(MemoryStream stream, T msg) where T : Google.Protobuf.IMessage
        {
            msg.WriteTo(stream);
        }
    }
}
