using System;
using System.Collections.Generic;
using System.Text;

namespace ProtocolObjectParserLib
{
    public class GenerateCodeModel
    {
        public static string GenerateCode(Dictionary<string, string> classListKeys)
        {
            //过滤
            Dictionary<string, string> keys = Filteration(classListKeys);
            //然后解析
            StringBuilder sb = IncludeHeadStr();

            string strClassCode = ClassBodyStr(keys);
            string classFrameStr = ClassFrameStr(strClassCode);
            string nameSpaceStr = NameSpaceFrameStr(classFrameStr);

            sb.Append(nameSpaceStr);
            sb.Append(Environment.NewLine);
            string code = sb.ToString();
            return code;
        }
        private static Dictionary<string, string> Filteration(Dictionary<string, string> classListKeys)
        {
            Dictionary<string, string> keys = new Dictionary<string, string>();

            foreach (var item in classListKeys)
            {
                //using Message.Client.Protocol.CGate;
                //using Message.Client.Protocol.CBarrack;
                //using Message.Gate.Protocol.GateC;
                //using Message.Barrack.Protocol.BarrackC;

                if (item.Value.Contains("Message.Client.Protocol.CGate") 
                    || item.Value.Contains("Message.Client.Protocol.CBarrack")
                    || item.Value.Contains("Message.Gate.Protocol.GateC")
                    || item.Value.Contains("Message.Barrack.Protocol.BarrackC"))
                {
                    if (!item.Value.Contains("GateCM"))
                    {
                        keys.Add(item.Key, item.Value);
                    }
                }
            }
            return keys;
        }

        /// <summary>
        /// 类内部代码
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        private static string ClassBodyStr(Dictionary<string, string> keys)
        {
            StringBuilder sbClassCode = new StringBuilder();
            StringBuilder sbBindStr = new StringBuilder();
            StringBuilder sbRouteInitStr = new StringBuilder();
            StringBuilder sbRouteNewStr = new StringBuilder();
            StringBuilder sbRouteGetStr = new StringBuilder();
            StringBuilder sbRouteDeserializeStr = new StringBuilder();
            //StringBuilder sbRouteTypeStr = new StringBuilder();
            StringBuilder sbRouteSendStr = new StringBuilder();
            foreach (var item in keys)
            {
                if (item.Value.Contains("Message") && !item.Value.Contains("+") && !item.Value.Contains("IdGenerator") && !item.Value.Contains("Reflection")&& item.Value.Contains("MSG_"))
                {

                    string classMemberStr1 = ClassMemberCodeStr(item.Key);
                    if (classMemberStr1 != "")
                    {
                        sbClassCode.Append(classMemberStr1);
                        sbClassCode.Append(Environment.NewLine);
                    }

                    if (item.Key.Contains("MSG_CG"))
                    {
                        string routeInitCaseStr = RouteInitCaseStr(item.Key);
                        sbRouteInitStr.Append(routeInitCaseStr);
                        sbRouteInitStr.Append(Environment.NewLine);

                        string routeNewCaseStr = RouteNewCaseStr(item.Key);
                        sbRouteNewStr.Append(routeNewCaseStr);
                        sbRouteNewStr.Append(Environment.NewLine);

                        string routeGetCaseStr = RouteGetCaseStr(item.Key);
                        sbRouteGetStr.Append(routeGetCaseStr);
                        sbRouteGetStr.Append(Environment.NewLine);

                        string routeDeserializeCaseStr = RouteDeserializeCaseStr(item.Key);
                        sbRouteDeserializeStr.Append(routeDeserializeCaseStr);
                        sbRouteDeserializeStr.Append(Environment.NewLine);

                        //string routeTypeCaseStr = RouteTypeCaseStr(item.Key);
                        //sbRouteTypeStr.Append(routeTypeCaseStr);
                        //sbRouteTypeStr.Append(Environment.NewLine);

                        string routeSendCaseStr = RouteSendCaseStr(item.Key);
                        sbRouteSendStr.Append(routeSendCaseStr);
                        sbRouteSendStr.Append(Environment.NewLine);
                    }

                        string bindString = BindStr(item.Key);
                        sbBindStr.Append(bindString);
                        sbBindStr.Append(Environment.NewLine);
                 
                }
            }

            sbClassCode.Append(DefineCode());

            string tempStr = sbRouteInitStr.ToString();
            tempStr = RouteFunc(RountType.Init, tempStr);
            sbClassCode.Append(tempStr);
            sbClassCode.Append(Environment.NewLine);

            tempStr = sbRouteNewStr.ToString();
            tempStr = RouteFunc(RountType.New, tempStr);
            sbClassCode.Append(tempStr);
            sbClassCode.Append(Environment.NewLine);

            tempStr = sbRouteGetStr.ToString();
            tempStr = RouteFunc(RountType.Get, tempStr);
            sbClassCode.Append(tempStr);
            sbClassCode.Append(Environment.NewLine);

            tempStr = sbRouteDeserializeStr.ToString();
            tempStr = RouteDeserializeFunc(tempStr);
            sbClassCode.Append(tempStr);
            sbClassCode.Append(Environment.NewLine);

            tempStr = sbBindStr.ToString();
            tempStr = BindResponseFunc(tempStr);
            sbClassCode.Append(tempStr);
            sbClassCode.Append(Environment.NewLine);

            tempStr = sbRouteSendStr.ToString();
            tempStr = RouteSendFunc(tempStr);
            sbClassCode.Append(tempStr);
            sbClassCode.Append(Environment.NewLine);

            tempStr = BindMsgIdFunc();
            sbClassCode.Append(tempStr);
            sbClassCode.Append(Environment.NewLine);

            string strClassCode = sbClassCode.ToString();
            return strClassCode;
        }

        /// <summary>
        /// using头文件代码
        /// </summary>
        /// <returns></returns>
        static StringBuilder IncludeHeadStr()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("using System.IO;");
            sb.Append(Environment.NewLine);
            sb.Append(" using System.Collections.Generic;");
            sb.Append(Environment.NewLine);

            sb.Append("using Message.Client.Protocol.CGate;");
            sb.Append(Environment.NewLine);
            sb.Append("using Message.Client.Protocol.CBarrack;");
            sb.Append(Environment.NewLine);
            sb.Append("using Message.Gate.Protocol.GateC;");
            sb.Append(Environment.NewLine);
            sb.Append("using Message.Barrack.Protocol.BarrackC;");
            sb.Append(Environment.NewLine);
            sb.Append("using ProtocolObjectParserLib;");
            sb.Append(Environment.NewLine);
            sb.Append("using Message.IdGenerator;");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            return sb;
        }
        /// <summary>
        /// namespace框架
        /// </summary>
        /// <param name="classFrame"></param>
        /// <returns></returns>
        static string NameSpaceFrameStr(string classFrame)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("namespace ProtocolObjectLib");
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append(classFrame);
            sb.Append(Environment.NewLine);
            sb.Append("}");
            string code = sb.ToString();
            return code;
        }
        /// <summary>
        /// classname框架
        /// </summary>
        /// <param name="classMembers">类成员代码</param>
        /// <returns></returns>
        static string ClassFrameStr(string classMembers)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("public class ProtoMsgManager");
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append(classMembers);
            sb.Append(Environment.NewLine);
            sb.Append("}");
            string code = sb.ToString();
            return code;
        }

        /// <summary>
        /// 类成员代码1
        /// </summary>
        /// <param name="key">关键字</param>
        /// <returns></returns>
        private static string ClassMemberCodeStr(string key)
        {

            StringBuilder sb = new StringBuilder();

            if (key.Contains("MSG_CG"))
            {
                sb.Append(DefineMsg(key));
                sb.Append(Environment.NewLine);
                sb.Append(InitMsgFunc(key));
                sb.Append(Environment.NewLine);
                sb.Append(GetMsgFunc(key));
                sb.Append(Environment.NewLine);
                sb.Append(NewMsgFunc(key));
                sb.Append(Environment.NewLine);

            }

            sb.Append(ResponseRecvFunc(key));
            sb.Append(Environment.NewLine);

            sb.Append(DeserializeMsgFunc(key));
            sb.Append(Environment.NewLine);

            string code = sb.ToString();
            return code;
        }

        /// <summary>
        /// 变量申明
        /// </summary>
        /// <returns></returns>

        //public void AddResponser_Msg(uint id, Responser_Msg responser)
        //{
        //    responsers.Add(id, responser);
        //}

        private static string DefineCode()
        {
            StringBuilder sb = new StringBuilder();
            //sb.Append("public delegate void Responser_Msg(MemoryStream stream);");
            //sb.Append(Environment.NewLine);
            //sb.Append("private Dictionary<uint, Responser_Msg> responsers = new Dictionary<uint, Responser_Msg>();");
            //sb.Append(Environment.NewLine);
            //sb.Append("public void AddResponser_Msg(uint id, Responser_Msg responser)");
            //sb.Append(Environment.NewLine);
            //sb.Append("{");
            //sb.Append(Environment.NewLine);
            ////sb.Append("responsers.Add(id, responser);");
            //sb.Append("Parser.AddResponser_Msg(id, responser);");
            //sb.Append(Environment.NewLine);
            //sb.Append("}");
            //sb.Append(Environment.NewLine);
            //sb.Append("public void Responser_Parser(uint id, MemoryStream stream)");
            //sb.Append(Environment.NewLine);
            //sb.Append("{");
            //sb.Append(Environment.NewLine);
            //sb.Append("Responser_Msg response;");
            //sb.Append(Environment.NewLine);
            //sb.Append("if (responsers.TryGetValue(id, out response))");
            //sb.Append(Environment.NewLine);
            //sb.Append("{");
            //sb.Append(Environment.NewLine);
            //sb.Append(" response(stream);");
            //sb.Append(Environment.NewLine);
            //sb.Append("}");
            //sb.Append(Environment.NewLine);
            //sb.Append("}");
            sb.Append(Environment.NewLine);
            string code = sb.ToString();
            return code;
        }

        /// <summary>
        /// define 代码
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string DefineMsg(string key)
        {
            StringBuilder sb = new StringBuilder();
            string initClass = string.Format("{0} msg_{0};", key);
            sb.Append(initClass);
            sb.Append(Environment.NewLine);
            string code = sb.ToString();
            return code;
        }

        /// <summary>
        /// init 函数框架
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string InitMsgFunc(string key)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("public object Init_{0}()", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            tempString = string.Format("msg_{0} = new {0}();", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            tempString = string.Format("return msg_{0};", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("}");
            string code = sb.ToString();
            return code;
        }

        /// <summary>
        /// get函数框架
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string GetMsgFunc(string key)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("public object Get_{0}()", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            tempString = string.Format("return msg_{0};", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("}");
            string code = sb.ToString();
            return code;
        }

        /// <summary>
        /// Deserialize函数框架
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string DeserializeMsgFunc(string key)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("public object Deserialize_{0}(MemoryStream stream)", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            tempString = string.Format("return  MessagePacker.ProtobufHelper.Deserialize<{0}>(stream);", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("}");
            string code = sb.ToString();
            return code;
        }

        /// <summary>
        /// new 函数框架
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string NewMsgFunc(string key)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("public object New_{0}()", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            tempString = string.Format("return msg_{0};", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("}");
            string code = sb.ToString();
            return code;
        }

        /// <summary>
        /// OnResponse 流解析函数框架
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string ResponseRecvFunc(string key)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("public void OnResponse_{0}(MemoryStream stream,out string msgName)", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            tempString = string.Format("{0} {0} = MessagePacker.ProtobufHelper.Deserialize<{0}>(stream);", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            tempString = string.Format("msgName = \"{0}\";", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            tempString = string.Format("Parser.Parse({0});", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("}");
            string code = sb.ToString();
            return code;
        }

        struct RountType
        {
            public const string Init = "Init";
            public const string Get = "Get";
            public const string New = "New";
            public const string Type = "Type";
            public const string Deserialize = "Deserialize";
        }

        /// <summary>
        /// Route函数框架
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string RouteFunc(string rountType, string caseString)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("public object Route{0}(string className)", rountType);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append("switch (className)");
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append(caseString);
            sb.Append(Environment.NewLine);
            sb.Append("default:");
            sb.Append(Environment.NewLine);
            sb.Append("return null;");
            sb.Append(Environment.NewLine);
            sb.Append("}");
            sb.Append(Environment.NewLine);
            sb.Append("}");
            string code = sb.ToString();
            return code;
        }

        /// <summary>
        /// RouteDeserialize函数框架
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private static string RouteDeserializeFunc(string caseString)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = @"public object RouteDeserialize(string className,MemoryStream stream)";
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append("switch (className)");
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append(caseString);
            sb.Append(Environment.NewLine);
            sb.Append("default:");
            sb.Append(Environment.NewLine);
            sb.Append("return null;");
            sb.Append(Environment.NewLine);
            sb.Append("}");
            sb.Append(Environment.NewLine);
            sb.Append("}");
            string code = sb.ToString();
            return code;
        }


        private static string RouteSendFunc(string caseString)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("public bool RouteSend(SendMethodInterface sendHandler,string className,object msg)");
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append("switch (className)");
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append(caseString);
            sb.Append(Environment.NewLine);
            sb.Append("default:");
            sb.Append(Environment.NewLine);
            sb.Append("return false;");
            sb.Append(Environment.NewLine);
            sb.Append("}");
            sb.Append(Environment.NewLine);
            sb.Append("}");
            string code = sb.ToString();
            return code;
        }

        private static string BindMsgIdFunc()
        {
            StringBuilder sb = new StringBuilder();
            string tempString = "public void BindMsgId()";
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append("Message.Gate.Protocol.GateC.GateCIdGenerator.GenerateId();");
            sb.Append(Environment.NewLine);
            sb.Append("Message.Client.Protocol.CGate.CGateIdGenerator.GenerateId();");
            sb.Append(Environment.NewLine);
            sb.Append("Message.Barrack.Protocol.BarrackC.BarrackCIdGenerator.GenerateId();");
            sb.Append(Environment.NewLine);
            sb.Append("Message.Client.Protocol.CBarrack.CBarrackIdGenerator.GenerateId();");
            sb.Append(Environment.NewLine);
            sb.Append("}");
            string code = sb.ToString();
            return code;
        }


        private static string BindResponseFunc(string bindString)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = "public void BindParser()";
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            sb.Append(bindString);
            sb.Append(Environment.NewLine);
            sb.Append("}");
            string code = sb.ToString();
            return code;
        }

        private static string BindStr(string key)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("Parser.AddResponser_Msg(Id<{0}>.Value, OnResponse_{0});", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            string code = sb.ToString();
            return code;
        }

        private static string RouteInitCaseStr(string key)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("case \"{0}\":", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            tempString = string.Format("return Init_{0}();", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            string code = sb.ToString();
            return code;
        }

        private static string RouteGetCaseStr(string key)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("case \"{0}\":", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            tempString = string.Format("return Get_{0}();", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            string code = sb.ToString();
            return code;
        }

        private static string RouteDeserializeCaseStr(string key)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("case \"{0}\":", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            tempString = string.Format("return Deserialize_{0}(stream);", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            string code = sb.ToString();
            return code;
        }

        private static string RouteNewCaseStr(string key)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("case \"{0}\":", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            tempString = string.Format("return New_{0}();", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            string code = sb.ToString();
            return code;
        }

        //private static string RouteTypeCaseStr(string key)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    string tempString = string.Format("case \"{0}\":", key);
        //    sb.Append(tempString);
        //    sb.Append(Environment.NewLine);
        //    tempString = string.Format("return typeof({0});", key);
        //    sb.Append(tempString);
        //    sb.Append(Environment.NewLine);
        //    string code = sb.ToString();
        //    return code;
        //}

        private static string RouteSendCaseStr(string key)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("case \"{0}\":", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            tempString = string.Format("return sendHandler.Send(({0})msg);", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            string code = sb.ToString();
            return code;
        }


    }
}
