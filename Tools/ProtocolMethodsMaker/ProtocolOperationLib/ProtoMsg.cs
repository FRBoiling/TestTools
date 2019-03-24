using System.IO;
using ProtocolObjectLib;
using ProtocolObjectParserLib;

namespace ProtocolOperationLib
{
    public class ProtoMsg : AbstractProtoMsg
    {
        ProtoMsgManager api;

        public ProtoMsg()
        {
            api = new ProtoMsgManager();
     
        }

        public override object RouteGet(string key)
        {
            return api.RouteGet(key);
        }

        public override object RouteInit(string key)
        {
            return api.RouteInit(key);
        }

        public override void BindParser()
        {
            api.BindParser();
        }

        public override object RouteDeserialize(string key, MemoryStream stream)
        {
            return api.RouteDeserialize(key,stream);
        }

        public override void BindMsgId()
        {
            api.BindMsgId();
        }

        public override void RouteSend(SendMethodInterface handler, string key, object msg)
        {
            api.RouteSend(handler, key,msg);
        }
    }
}
