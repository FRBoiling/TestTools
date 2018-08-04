﻿using LibUtil;
using System.Linq;

namespace LibDataObject
{
    public class HostInfo
    {
        public string CurrntKey { get; set; }
        public string CurrntIp { get; set; }
        public ushort Port { get; set; }
        public HostInfo()
        {
            if (Constant.inst.notDefault)
            {
                GetHostInfo();
            }
            else
            {
                CurrntIp = Constant.ServerDefaultIp;
                CurrntKey = Constant.ServerDefaultKey;
                Port = Constant.DefaultPort;
            }
        }

        public HostInfo GetHostInfo()
        {
            int cout = Constant.inst.GateList.Count();
            if (cout>0)
            {
                int index = NewRAND.Next(1, cout);
                CurrntKey = Constant.inst.GateList[index].CurrntKey;
                CurrntIp = Constant.inst.GateList[index].CurrntIp;
                Port = Constant.inst.GateList[index].Port;
            }
            return this;
        }

        public HostInfo GetMasterHostInfo()
        {
            CurrntKey = Constant.inst.masterInfo.CurrntKey;
            CurrntIp = Constant.inst.masterInfo.CurrntIp;
            Port = Constant.inst.masterInfo.Port;
            return this;
        }

    }
}
