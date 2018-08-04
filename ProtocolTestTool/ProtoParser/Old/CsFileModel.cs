using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoParser
{
    public static class CsFileModel
    {
        public static string includeHead = "using System;\nusing System.IO;\nusing Message.Server.Client.Protocol.CGate;\nusing Message.Server.Gate.Protocol.GateC;\nusing ProtoSendTool;\nusing UtilityLibrary;\nusing Engine.Foundation;\nusing LogLibrary;\nusing System.Reflection;\n";
        public static string strHead1 = "namespace ProtoSendTool\n{{\n public partial class Client \n{{\n{0}\n}}\n}}";

        public static string strRequestClass = " {0} msg_{0};";

        public static string strRequestInit = "public object Init_{0}()\n{1}";
        public static string strRequestInit1 = "{{\n msg_{0} = new {0}();\nreturn msg_{0};\n}}";

        public static string strRequestGet = "public object Get_{0}()\n{1}";
        public static string strRequestGet1 = "{{\nreturn msg_{0};\n}}";

        public static string strRequestNew = "public object New_{0}()\n{1}";
        public static string strRequestNew1 = "{{\nreturn new {0}();\n}}";

        public static string strRequestRouteInit = "public object RouteInit(string className)\n{{\n switch (className)\n{{\n{0}\ndefault:\nreturn null;\n}}\n}}";
        public static string strRequestRouteInit1 = "case \"{0}\":\nreturn Init_{0}();\n";

        public static string strRequestRouteGet = "public object RouteGet(string className)\n{{\n switch (className)\n{{\n{0}\ndefault:\nreturn null;\n}}\n}}";
        public static string strRequestRouteGet1 = "case \"{0}\":\nreturn Get_{0}();\n";

        public static string strRequestRouteNew = "public object RouteNew(string className)\n{{\n switch (className)\n{{\n{0}\ndefault:\nreturn null;\n}}\n}}";
        public static string strRequestRouteNew1 = "case \"{0}\":\nreturn New_{0}();\n";

        public static string strRequestRouteType = "public object RouteType(string className)\n{{\n switch (className)\n{{\n{0}\ndefault:\nreturn null;\n}}\n}}";
        public static string strRequestRouteType1 = "case \"{0}\":\nreturn typeof({0});\n";

        public static string strRequestRouteSend = "public bool RouteSend(string className,object msg)\n{{\n switch (className)\n{{\n{0}\ndefault:\nreturn false;\n}}\n}}";
        public static string strRequestRouteSend1 = "case \"{0}\":\nreturn Net.Send(({0})msg);\n";

        public static string strResponseInit = "public void BindResponse()\n{{\n {0}\n}}";
        public static string strResponseInit1 = "Net.AddResponser(Id<{0}>.Value, OnResponse_{0});\n";

        public static string strResponseRecv = "public void OnResponse_{0}(MemoryStream stream)\n{1}";
        public static string strResponseRecv1 = "{{\n {0} {0} = ProtoBuf.Serializer.Deserialize<{0}>(stream);\nParser.Parse({0});\n}}";
    }
}
