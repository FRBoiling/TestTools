using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureTestToolLib
{
    public partial class Client
    {
        LogicManager logicMng = new LogicManager();
        Requester requester = new Requester();
        public DateTime lastLoopExecTime = DateTime.MinValue;
        public int loopExecInterval = 200; //单位：毫秒
        public void SetLoopExecIntervalSec(int millionsec)
        {
            lock (this)
            {
                loopExecInterval = millionsec;
            }
        }

        public void InitLogicMng() {
            logicMng.Init();
        }

        public void AddResqueueter(LogicType type, List<string> paramList)
        {
            AbstractRequest request = logicMng.GetRequester(type);
            if (request != null)
            {
                request.SetOwner(this);
                request.SetParams(paramList);
                requester.AddRequest(type,request);
            }
            else
            {
                Log.ErrorLine("add requst fail:requst type {0} params {1}", type,paramList.ToString());
            }
        }

        public void ClearRequestr()
        {
            requester.Clear();
        }

        public void DoRequest() {
            requester.DoRequest();
        }
    }


 
}
