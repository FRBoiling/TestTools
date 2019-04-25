using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolObjectParserLib
{
    public interface SendMethodInterface
    {
        //bool Send<T>(T msg) where T : global::ProtoBuf.IExtensible;
        bool Send<T>(T msg) where T : Google.Protobuf.IMessage;
    }
}
