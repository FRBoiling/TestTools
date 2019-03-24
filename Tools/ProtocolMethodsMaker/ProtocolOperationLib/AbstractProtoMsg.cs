using ProtocolObjectParserLib;
using System;
using System.IO;
using System.Reflection;
using UtilityLibrary;

namespace ProtocolOperationLib
{
    public abstract class AbstractProtoMsg
    {
        public abstract object RouteGet(string key);
        public abstract object RouteInit(string key);

        public abstract void RouteSend(SendMethodInterface handler ,string key, object msg);
      
        public abstract object RouteDeserialize(string key, MemoryStream stream);
        
        public abstract void BindParser();

        public abstract void BindMsgId();

        public void SetValue(object msg, string msgName, string key, object value)
        {
            Type t = msg.GetType();
            PropertyInfo info = t.GetProperty(key);
            switch (info.PropertyType.Name)
            {
                case PropertyType.Int32:
                    int n = Convert.ToInt32(value);
                    info.SetValue(msg, n, null);
                    return;
                case PropertyType.String:
                    string str = value.ToString();
                    info.SetValue(msg, str, null);
                    return;
                case PropertyType.UInt64:
                    UInt64 uInt = Convert.ToUInt64(value);
                    info.SetValue(msg, uInt, null);
                    break;
                case PropertyType.Float:
                    float fN = Convert.ToSingle(value);
                    info.SetValue(msg, fN, null);
                    break;
                case PropertyType.Bool:
                    bool bN = Convert.ToBoolean(value);
                    info.SetValue(msg, bN, null);
                    break;
                case PropertyType.List:
                    string tempString = value.ToString();
                    string[] sp = StringUtil.GetSplitString(tempString, '|');

                    var lst = info.GetValue(msg, null);
                    var addMethod = lst.GetType().GetMethod("Add");

                    var TType = lst.GetType().GetTypeInfo().GenericTypeArguments[0];
                    switch (TType.Name)
                    {
                        case PropertyType.Int32:
                            foreach (string item in sp)
                            {
                                addMethod.Invoke(lst, new object[] { Convert.ToInt32(item) });
                            }
                            return;
                        case PropertyType.String:
                            foreach (string item in sp)
                            {
                                addMethod.Invoke(lst, new object[] { item });
                            }
                            return;
                        case PropertyType.UInt64:
                            foreach (string item in sp)
                            {
                                addMethod.Invoke(lst, new object[] { Convert.ToUInt64(item) });
                            }
                            break;
                        case PropertyType.Float:
                            foreach (string item in sp)
                            {
                                addMethod.Invoke(lst, new object[] { Convert.ToSingle(item) });
                            }
                            break;
                        case PropertyType.Bool:
                            foreach (string item in sp)
                            {
                                addMethod.Invoke(lst, new object[] { Convert.ToBoolean(item) });
                            }
                            break;
                        default:
                            Console.WriteLine("相关类型数据解析功能正在建设中！");
                            break;
                    }

                    break;
                default:
                    break;

            }
        }

    }
}
