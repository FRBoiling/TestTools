using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoParserLib
{
    public class GenerateCodeModel
    {

        public static bool CheckLoginMsg(string strName)
        {
            switch (strName)
            {
                case "G2CIdGenerater":
                    return false;
                case "C2GIdGenerater":
                    return false;
                //request
                //case "MSG_CG_HEARTBEAT":
                //    return false;
                //case "MSG_CG_MAP_LOADING_DONE":
                //    return false;
                //case "MSG_CG_GET_BLOWFISHKEY":
                //    return false;
                //case "MSG_CG_USER_LOGIN":
                //    return false;
                //case "MSG_CG_TO_ZONE":
                //    return false;


                //response
                case "MSG_GC_HEARTBEAT":
                    return false;
                case "MSG_GC_TIME_SYNC":
                    return false;
                case "MSG_GC_BLOWFISHKEY":
                    return false;
                case "MSG_GC_USER_LOGIN":
                    return false;
                case "MSG_GC_ENTER_WORLD":
                    return false;
                case "MSG_GC_ENTER_ZONE":
                    return false;
                case "MSG_GC_MAP_LOADING_DONE":
                    return false;
                default:
                    break;
            }
            return true;
        }

        public static string GenerateCode(Dictionary<string, string> keys)
        {
            StringBuilder sb = IncludeHeadStr();

            string strClassCode = ClassBodyStr(keys);
            string classFrameStr = ClassFrameStr(strClassCode);
            string nameSpaceStr = NameSpaceFrameStr(classFrameStr);

            sb.Append(nameSpaceStr);
            sb.Append(Environment.NewLine);
            string code = sb.ToString();
            return code;
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
            StringBuilder sbRouteTypeStr = new StringBuilder();
            StringBuilder sbRouteSendStr = new StringBuilder();

            foreach (var item in keys)
            {
                if (item.Value.Contains("protocol") && !item.Value.Contains("+"))
                {
                    if (CheckLoginMsg(item.Key))
                    {
                        string classMemberStr1 = ClassMemberCodeStr(item.Key);
                        sbClassCode.Append(classMemberStr1);
                        sbClassCode.Append(Environment.NewLine);

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

                            string routeTypeCaseStr = RouteTypeCaseStr(item.Key);
                            sbRouteTypeStr.Append(routeTypeCaseStr);
                            sbRouteTypeStr.Append(Environment.NewLine);

                            string routeSendCaseStr = RouteSendCaseStr(item.Key);
                            sbRouteSendStr.Append(routeSendCaseStr);
                            sbRouteSendStr.Append(Environment.NewLine);


                        }
                        else
                        {
                            string bindString = BindStr(item.Key);
                            sbBindStr.Append(bindString);
                            sbBindStr.Append(Environment.NewLine);
                        }
                    }
                }
            }


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

            tempStr = sbRouteTypeStr.ToString();
            tempStr = RouteFunc(RountType.Type, tempStr);
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
            sb.Append("using protocol.client.c2g;");
            sb.Append(Environment.NewLine);
            sb.Append("using protocol.client.g2c;");
            sb.Append(Environment.NewLine);
            sb.Append("using Protocol.MsgId;");
            sb.Append(Environment.NewLine);
            sb.Append("using LibLog;");
            sb.Append(Environment.NewLine);
            sb.Append("using ProtoParserLib;");
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
            sb.Append("namespace ProtoSendLib");
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
            sb.Append("public partial class Client");
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
            else
            {
                sb.Append(ResponseRecvFunc(key));
                sb.Append(Environment.NewLine);
            }
        
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
            string tempString = string.Format("public void OnResponse_{0}(MemoryStream stream)", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            sb.Append("{");
            sb.Append(Environment.NewLine);
            tempString = string.Format("{0} {0} = ProtoBuf.Serializer.Deserialize<{0}>(stream);", key);
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

        private static string RouteSendFunc(string caseString)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("public bool RouteSend(string className,object msg)");
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
        private static string BindResponseFunc(string bindString)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = "public void BindResponse()";
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
            string tempString = string.Format("Net.AddResponser(Id<{0}>.Value, OnResponse_{0});", key);
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

        private static string RouteTypeCaseStr(string key)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("case \"{0}\":", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            tempString = string.Format("return typeof({0});", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            string code = sb.ToString();
            return code;
        }

        private static string RouteSendCaseStr(string key)
        {
            StringBuilder sb = new StringBuilder();
            string tempString = string.Format("case \"{0}\":", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            tempString = string.Format("return Net.Send(({0})msg);", key);
            sb.Append(tempString);
            sb.Append(Environment.NewLine);
            string code = sb.ToString();
            return code;
        }



    }
}
