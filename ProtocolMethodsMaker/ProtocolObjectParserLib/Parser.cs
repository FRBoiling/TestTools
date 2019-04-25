using Logger;
using ProtocolCatchMsgLogLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace ProtocolObjectParserLib
{
    public struct PropertyType
    {
        public const string Int32 = "Int32";
        public const string UInt64 = "UInt64";
        public const string String = "String";
        public const string List = "List`1";
        public const string Float = "Single";
        public const string Bool = "Boolean";
    }
    public static class Parser
    {
        public delegate void Responser_Msg(MemoryStream stream,out string msgName);
        private static Dictionary<uint, Responser_Msg> responsers = new Dictionary<uint, Responser_Msg>();

        public static void AddResponser_Msg(uint id, Responser_Msg responser)
        {
            try
            {
                responsers.Add(id, responser);
            }
            catch (Exception ex)
            {
                Log.Error("msg {0} add error: {1} ", id, ex);
            }
        }

        public static void Responser_Parser(  uint id, MemoryStream stream, DateTime now, int uid=0)
        {
            Responser_Msg response;
            if (responsers.TryGetValue(id, out response))
            {
                string msgName = string.Empty;
                response(stream,out msgName);
                if (string.IsNullOrEmpty(msgName))
                {
                    Log.Error("msg {0} can not get name", id);
                }
                else
                {
                    StreamCatchLog.SaveMsgInfo(now,uid,msgName,stream);
                }
            }
            else
            {
                Log.Error("msg {0} can not get parser response method", id);
            }
        }


        public struct SpaceString
        {
            public const string Space = "    ";
        }

        public static void Parse(object msg)
        {
            if (msg == null)
            {
                Log.ErrorLine("Parse got an error: msg = null");
                return;
            }
            Type type = msg.GetType();
            //PropertyInfo[] propertyinfo = type.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            PropertyInfo[] propertyinfo = type.GetProperties(BindingFlags.Instance |BindingFlags.Public);

            string linePrefix = string.Format("{0}{1}", SpaceString.Space, "*>");
            string parseHead = string.Format("{0}<<<<<<<<<<< Recv {1} <<<<<<<<<{2}", Environment.NewLine, type.Name, Environment.NewLine);
            string parseMiddle = "";
            string parseEnd = ">>>>>>>>>>>>>>>>>>>>>>>>>>";

            foreach (var item in propertyinfo)
            {
                string propertyType = item.PropertyType.Name;
                string propertyName = item.Name;
                object value = item.GetValue(msg, null);

                switch (propertyType)
                {
                    case PropertyType.Int32:
                    case PropertyType.UInt64:
                    case PropertyType.Float:
                    case PropertyType.Bool:
                    case PropertyType.String:
                        {
                            parseMiddle = ParseNormalTypeObject(linePrefix, parseMiddle, propertyType, propertyName, value);
                        }
                        break;
                    case PropertyType.List:
                        {
                            parseMiddle = ParseListObject(linePrefix, parseMiddle, propertyType, propertyName, value);
                        }
                        break;
                    default:
                        {
                            parseMiddle = ParseCustomObject(linePrefix, parseMiddle, propertyType, propertyName, value);
                        }
                        break;
                }
            }
            MsgCatchLog.Write("{0}{1}{2}>>>>>>>>>>>>>>>>>>>>>>>>>>", parseHead, parseMiddle, parseEnd);
        }

        public static string ParseToString(object msg,string prefix,string name ="")
        {
            if (msg ==null)
            {
                //Log.ErrorLine("ParseToString got an error: msg = null");
                return string.Empty;
            }
       
            Type type = msg.GetType();
            string linePrefix = string.Format("{0}{1}", SpaceString.Space, prefix);
            string parseHead = "";
            if (name!="")
            {
                parseHead = string.Format("{0}{1} {2}{3}", linePrefix, type.Name, name, Environment.NewLine);
                linePrefix = string.Format("{0}{1}", SpaceString.Space, linePrefix);
            }
            string parseMiddle = "";
            //string parseEnd = string.Format("{0}{1}", linePrefix,Environment.NewLine);
            string parseEnd ="";
            switch (type.Name)
            {
                case PropertyType.Int32:
                case PropertyType.UInt64:
                case PropertyType.Float:
                case PropertyType.Bool:
                case PropertyType.String:
                    {
                        parseHead = "";
                        parseMiddle = ParseNormalTypeObject(linePrefix, parseMiddle, type.Name, name, msg);
                        return string.Format("{0}{1}{2}", parseHead, parseMiddle, parseEnd);
                    }
                case PropertyType.List:
                    {
                        parseEnd = Environment.NewLine;
                        parseMiddle = ParseListObject(linePrefix, parseMiddle, type.Name, name, msg);
                        return string.Format("{0}{1}{2}", parseHead, parseMiddle, parseEnd);
                    }
                default:
                    break;
            }

            PropertyInfo[] propertyinfo = type.GetProperties( BindingFlags.Public);

            foreach (var item in propertyinfo)
            {
                string propertyType = item.PropertyType.Name;
                string propertyName = item.Name;
                object value = item.GetValue(msg, null);

                switch (propertyType)
                {
                    case PropertyType.Int32:
                    case PropertyType.UInt64:
                    case PropertyType.Float:
                    case PropertyType.Bool:
                    case PropertyType.String:
                        {
                            parseMiddle = ParseNormalTypeObject(linePrefix, parseMiddle, propertyType, propertyName, value);
                        }
                        break;
                    case PropertyType.List:
                        {
                            parseMiddle = ParseListObject(linePrefix, parseMiddle, propertyType, propertyName, value);
                        }
                        break;
                    default:
                        //{
                        //    parseMiddle = ParseCustomObject(linePrefix, parseMiddle, propertyType, propertyName, value);
                        //}
                        break;
                }
            }
            return string.Format("{0}{1}{2}", parseHead, parseMiddle, parseEnd);
        }

        private static string ParseCustomObject(string linePrefix, string parseMiddle, string propertyType, string propertyName, object value)
        {
            string parseMiddleSon = "";
            if (value==null)
            {
                parseMiddleSon = string.Format("{0}{1} {2} = {3}{4}", linePrefix, propertyType, propertyName, "null", Environment.NewLine);
            }
            else
            {
                parseMiddleSon = string.Format("{0}{1} {2} = {3}{4}", linePrefix, propertyType, propertyName, value, Environment.NewLine);
            }
            parseMiddle = string.Format("{0}{1}", parseMiddle, parseMiddleSon);
            parseMiddleSon = ParseToString(value, linePrefix);
            parseMiddle = string.Format("{0}{1}", parseMiddle, parseMiddleSon);
            return parseMiddle;
        }

        private static string ParseNormalTypeObject(string linePrefix, string parseMiddle, string propertyType, string propertyName, object value)
        {
            string parseMiddleSon = "";
            if (value == null)
            {
                parseMiddleSon = string.Format("{0}{1} {2} = {3}{4}", linePrefix, propertyType, propertyName, "null", Environment.NewLine);
            }
            else
            {
                parseMiddleSon = string.Format("{0}{1} {2} = {3}{4}", linePrefix, propertyType, propertyName, value, Environment.NewLine);
            }
           
            parseMiddle = string.Format("{0}{1}", parseMiddle, parseMiddleSon);
            return parseMiddle;
        }

        private static string ParseListObject(string linePrefix, string parseMiddle, string propertyType, string propertyName, object value)
        {
            if (value == null)
            {
                Log.ErrorLine("ParseListObject got an error: value = null");
            }
            Type tt= value.GetType();
            IEnumerable it = value as IEnumerable;
            int index = 0;
            string parseMiddleSon = string.Empty;
            foreach (var obj in it)
            {
                string itName = GetListPropertyName(propertyName, index);
                string sonShow = ParseToString(obj, linePrefix, itName);
                parseMiddleSon = string.Format("{0}{1}", parseMiddleSon, sonShow);
                index++;
            }
            string strListHeader = string.Format("{0}{1} {2} = {3}(count:{4}){5}", linePrefix, propertyType, propertyName, value, index, Environment.NewLine);
            parseMiddle = string.Format("{0}{1}",  parseMiddle, strListHeader);
            parseMiddle = string.Format("{0}{1}", parseMiddle, parseMiddleSon);
            return parseMiddle;
        }

        private static string GetListPropertyName(string propertyName, int index)
        {
            return string.Format("{0}[{1}]", propertyName, index);
        }


        public static Assembly LoadCSharpAssembly(string pathName)
        {
            byte[] bFile = null;
            using (FileStream fs = new FileStream(pathName, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    bFile = br.ReadBytes((int)fs.Length);
                    if (pathName.EndsWith(".dll"))
                    {
                        string pathName2 = pathName.Substring(0, pathName.LastIndexOf(".")) + ".pdb";
                        if (File.Exists(pathName2))
                        {
                            byte[] bFile2 = null;
                            using (FileStream fs2 = new FileStream(pathName2, FileMode.Open, FileAccess.Read))
                            {
                                using (BinaryReader br2 = new BinaryReader(fs2))
                                {
                                    bFile2 = br2.ReadBytes((int)fs2.Length);

                                    Assembly assembly = Assembly.Load(bFile, bFile2);
                                    return assembly;
                                }
                            }
                        }
                        else
                        {
                            Assembly assembly = Assembly.Load(bFile);
                            return assembly;
                        }

                    }
                    else
                    {
                        Assembly assembly = Assembly.Load(bFile);
                        return assembly;
                    }
                }
            }
        }


        /// <summary>
        /// 返回加载出来的实例
        /// </summary>
        /// <param name="assembly"></param>
        /// <param name="tempInstances"></param>
        /// <param name="retStrs"></param>
        public static object ActionAssembly(Assembly assembly,string Name)
        {
            //获取加载的所有对象模型
            Type[] instances = assembly.GetExportedTypes();
            //foreach (var itemType in instances)
            {
                //if (!itemType.IsClass || itemType.IsAbstract)
                //{
                //    continue;
                //}
                try
                {
                    //获取单个模型的所有继承关系和接口关系
                    //Type[] interfaces = itemType.GetInterfaces();
                    //if (interfaces == null || interfaces.Length == 0)
                    //{
                    //    Log.Warn("动态加载 " + itemType.FullName + " 没有实现IBaseScript接口");
                    //    continue;
                    //}

                    //生成实例
                    return assembly.CreateInstance(Name);
                    //if (obj is IInitBaseScript)
                    //{
                    //    (obj as IInitBaseScript).InitScript();
                    //}

                    //if (obj is IBaseScript)
                    //{
                    //    foreach (var iteminterface in interfaces)
                    //    {
                    //        if (iteminterface.Name == baseScriptName)
                    //        {
                    //            continue;
                    //        }
                    //        //Log.Write("动态加载实例：" + itemType.FullName + " : " + iteminterface.FullName);
                    //        //加入对象集合
                    //        if (!tempInstances.ContainsKey(iteminterface.Name))
                    //        {
                    //            tempInstances[iteminterface.Name] = new Dictionary<string, IBaseScript>();
                    //        }
                    //        //基于对象的命名空间区分不同的文件；
                    //        tempInstances[iteminterface.Name][itemType.FullName] = (IBaseScript)obj;
                    //    }
                    //}
                    //else
                    //{
                    //    Log.Warn("动态加载 " + itemType.FullName + " 没有实现IBaseScript接口");
                    //}
                }
                catch (Exception ex)
                {
                    Log.Error("动态加载Error：" + ex.Message);
                    return null;
                    //retStrs.Add("动态加载Error：" + ex.Message);
                }
            }
        }

    }
}
