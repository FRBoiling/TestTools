using Logger;
using NetPacketLib;
using ProtocolObjectParserLib;
using ProtocolOperationLib;
using System;
using System.Collections.Generic;
using System.IO;
using UtilityLibrary;

namespace PressureTestToolLib
{
    public class MsgData
    {
        string msgName = string.Empty;
        public Dictionary<string, string> msgPropertys = new Dictionary<string, string>();
        long time;

        public string MsgName
        {
            get
            {
                return msgName;
            }

            set
            {
                msgName = value;
            }
        }

        public long Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }
    }

    public class ProtocolData
    {
        string msgName = string.Empty;
        object msg;
        //long time;
        int uid;
        DateTime time;
        public string MsgName
        {
            get
            {
                return msgName;
            }

            set
            {
                msgName = value;
            }
        }

        //public long Time
        //{
        //    get
        //    {
        //        return time;
        //    }

        //    set
        //    {
        //        time = value;
        //    }
        //}

        public object Msg
        {
            get
            {
                return msg;
            }

            set
            {
                msg = value;
            }
        }
        public int Uid
        {
            get
            {
                return uid;
            }
            set
            {
                uid = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }
    }

    public class ProtocolGroupManager : Singleton<ProtocolGroupManager>
    {
        List<ProtocolData> protocolList = new List<ProtocolData>();
        Queue<MsgData> msges = new Queue<MsgData>();

        AbstractProtoMsg msgApi = null;

        public List<ProtocolData> GetProtocolList()
        {
            return protocolList;
        }

        void ParseText(Queue<string[]> protocolQueue)
        {
            //FIXME:Boiling 解析传过来的协议数据日志
            if (protocolQueue == null)
            {
                return;
            }
            string strTime = "";
            string strUid = "";
            string msgName = "";
            string strProtocol = "";
            while (protocolQueue.Count > 0)
            {
                string[] protocolArr = protocolQueue.Dequeue();
                strTime = protocolArr[0];
                strUid = protocolArr[1];
                msgName = protocolArr[2];
                strProtocol = protocolArr[3];
                //MsgData msgData = new MsgData();
                protocolList.Add(Deserialize(msgName, strTime, strProtocol, strUid));
            }
        }

        ProtocolData Deserialize(string msgName, string strTime, string protocolString, string strUid)
        {
            ProtocolData protocolData = new ProtocolData();
            protocolData.MsgName = msgName;

            //long lTime = long.Parse(strTime);
            //protocolData.Time = lTime;
            DateTime dt = DateTime.Parse(strTime);
            protocolData.Time = dt;
            int uid = int.Parse(strUid);
            protocolData.Uid = uid;
            MemoryStream stream = new MemoryStream(Convert.FromBase64String(protocolString));
            protocolData.Msg = msgApi.RouteDeserialize(msgName, stream);

            return protocolData;
        }

        private bool ParseInit()
        {
            return AssemblyParser.AssemblyParse(PathExt.codePath);
        }

        public void Init()
        {
            ParseInit();
            msgApi = new ProtoMsg();
            msgApi.BindMsgId();
            msgApi.BindParser();
            ParseText(GetProtoclLog());
            Log.WriteLine("Parse done!");
        }

        public Queue<string[]> GetProtoclLog()
        {
            //string protocolLogFiles = "c:/Log/ProtoMsgLog/";
            ////FIXME: Boiling 这里做读取日志文件
            //ProtoMsgLogger dl = new ProtoMsgLogger();
            //FileInfo[] sortList = dl.GetLogFilesByOrder(protocolLogFiles);
            //Queue<string[]> protocolData = dl.ReadLogFile(sortList);
            //return protocolData;
            return null;
        }

        public void Send(ComnunicationClient net, ProtocolData msg)
        {
            msgApi.RouteSend(net, msg.MsgName, msg.Msg);
        }



    }
}
