using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureTestToolLib
{
    public abstract class AbstractRequest
    {
        public abstract void Request();

        //循环执行的指令
        public bool IsLoop = false;

        //指令拥有者
        protected Client owner = null;
        internal void SetOwner(Client client)
        {
            owner = client;
        }

        List<string> paramList = new List<string>();
        internal void SetParams(List<string> paramList)
        {
            this.paramList.Clear();
            this.paramList.AddRange(paramList);
        }
    }
}
