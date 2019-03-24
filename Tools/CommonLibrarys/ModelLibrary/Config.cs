using DataProperty;
using Logger;
using System;
using System.Collections.Generic;
using UtilityLibrary;

namespace ModelLibrary
{
    public class Config : Singleton<Config>
    {
        private HostInfo masterInfo;
        public HostInfo MasterInfo { get => masterInfo; }


        private Dictionary<int, HostInfo> serverList = new Dictionary<int, HostInfo>();
        public Dictionary<int, HostInfo> ServerList { get => serverList; }


        VersionInfo version = new VersionInfo();
        public VersionInfo Version { get => version; }


        public void LoadConfig()
        {
            LoadVersionXml();
            LoadServerXml();
            Log.Info("load config success !");
        }

        public void LoadServerXml()
        {
            try
            {
                DataList dataList = DataListManager.inst.GetDataList("BarrackList");
                foreach (var data in dataList)
                {
                    string ip = data.Value.GetString("ip");
                    int port = (ushort)data.Value.GetInt("port");
                    string key = ip;
                    HostInfo info = new HostInfo(ip, port, key);

                    ServerList.Add(data.Key, info);
                }

                Data dataMaster = DataListManager.inst.GetData("Master", 1);
                string masterIp = dataMaster.GetString("ip");
                int masterPort = (ushort)dataMaster.GetInt("port");
                masterInfo = new HostInfo(masterIp, masterPort, masterIp);
            }
            catch (System.Exception e)
            {
                Log.Error(e.Message);
            }
        }


        public void LoadVersionXml()
        {
            try
            {
                //DataList dataList = DataListManager.inst.GetDataList("VersionConfig",2);
                Data data = DataListManager.inst.GetData("VersionConfig", 2);
                //foreach (var data in dataList)
                //{
                version.SetId(data.ID); 
                version.SetName(data.Name);
                //}
            }
            catch (System.Exception e)
            {
                Log.Error(e.Message);
            }
        }

    }
}
