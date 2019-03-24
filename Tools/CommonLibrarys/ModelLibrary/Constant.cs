using DataProperty;
using Logger;
using System;
using System.Collections.Generic;
using UtilityLibrary;

namespace ModelLibrary
{
    public class Constant : Singleton<Constant>
    {
        public bool notDefault = false;
        public const string ServerDefaultKey = "loaclhost";
        public const string ServerDefaultIp = "127.0.0.1";
        //public const string ServerDefaultIp="192.168.10.251";
        public const int DefaultPort = 8403;

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
            LoadBarrackXml();
            LoadVersionXml();
        }


        public void LoadBarrackXml()
        {
            try
            {
                DataList dataList = DataListManager.inst.GetDataList("BarrackList");
                foreach (var data in dataList)
                {
                    HostInfo info = new HostInfo();
                    info.CurrntKey = data.Value.GetString("ip");
                    info.CurrntIp = data.Value.GetString("ip");
                    info.Port = (ushort)data.Value.GetInt("port");
                    GateList.Add(data.Key, info);
                }

                Data dataMaster = DataListManager.inst.GetData("Master", 1);
                masterInfo = new HostInfo();
                masterInfo.CurrntIp = dataMaster.GetString("Ip");
                masterInfo.Port = (ushort)dataMaster.GetInt("Port");

                Log.WriteLine("Load BarrackList success!");
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

                Log.WriteLine("Load VersionXml success!");
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
