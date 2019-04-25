using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolObjectParserLib
{
    public class ConstData
    {
        public const string ClientMsgDll = @"Message.ClientProtocol.dll";
        public const string ServerMsgDll = @"Message.ServerProtocol.dll";
        public const string ProtocolObjectDll = @"AssemblyProtocolObjectLib.dll";
        public const string GenrateCodePathName = @"\ProtocolObjectLib\";
        public const string GenrateCodeFileName = @"Protocol_Code.cs";

        public const string BaseTypeName = @"ProtocolObjectLib.ProtoMsgManager";
    }
}
