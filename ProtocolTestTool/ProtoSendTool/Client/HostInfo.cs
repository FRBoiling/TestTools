using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoSendTool
{
    public class HostInfo
    {

        public string CurrntKey { get; set; }
        public string CurrntIp { get; set; }
        public int Port { get; set; }
        public HostInfo(string key,int port,string ip)
        {
                CurrntKey = key;
                Port = port;
                CurrntIp = ip;
        }

    }
}
