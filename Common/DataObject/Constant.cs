using LibUtil;
using System;
using System.Collections.Generic;
using XmlDataParser;

namespace LibDataObject
{
    public class Constant : Singleton<Constant>
    {
        public bool notDefault = false;
        public const string ServerDefaultKey = "loaclhost";
        public const string ServerDefaultIp = "127.0.0.1";
        //public const string ServerDefaultIp="192.168.10.251";
        public const int DefaultPort = 8403;

        //public  string ServerCurrentKey;
        //public  string ServerCurrentIp;
        //public  int Port;

        //public void LoadXml()
        //{
        //    try
        //    {
        //        Data data = DataListManager.inst.GetData("GateList", 1);
        //        ServerCurrentKey = data.GetString("GateIp");
        //        ServerCurrentIp = data.GetString("GateIp");
        //        Port = data.GetInt("GatePort");
        //        notDefault = true;
        //        Console.WriteLine("Init NetConfig success!");
        //    }
        //    catch (System.Exception)
        //    {

        //        throw;
        //    }
        //}
        Dictionary<int, HostInfo> gateList = new Dictionary<int, HostInfo>();

        public Dictionary<int, HostInfo> GateList
        {
            get
            {
                return gateList;
            }
        }
       public HostInfo masterInfo;

        public void LoadXml()
        {
            LoadGateXml();
            LoadVersionXml();
        }


        public void LoadGateXml()
        {
            try
            {
                DataList dataList = DataListManager.inst.GetDataList("GateList");
                foreach (var data in dataList)
                {
                    HostInfo info = new HostInfo();
                    info.CurrntKey = data.Value.GetString("GateIp");
                    info.CurrntIp = data.Value.GetString("GateIp");
                    info.Port = (ushort)data.Value.GetInt("GatePort");
                    GateList.Add(data.Key, info);
                }

                Data dataMaster = DataListManager.inst.GetData("Master", 1);
                masterInfo = new HostInfo();
                masterInfo.CurrntIp = dataMaster.GetString("Ip");
                masterInfo.Port = (ushort)dataMaster.GetInt("Port");

                Console.WriteLine("Init GateConfig success!");
            }
            catch (System.Exception)
            {

                throw;
            }
        }

       public  int version = 0;
       public  string versionName = "";

        public void LoadVersionXml()
        {
            try
            {
                //DataList dataList = DataListManager.inst.GetDataList("VersionConfig",2);
                Data data = DataListManager.inst.GetData("VersionConfig",2);
                //foreach (var data in dataList)
                //{
                    version = data.ID;
                     versionName = data.Name;
                //}

                Console.WriteLine("Init VersionXml success!");
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public Constant()
        {
        }

    }
}
