using System;
using System.Collections.Generic;

namespace PressureTestToolLib
{
    class Requester
    {
        private Dictionary<LogicType, AbstractRequest> requesters = new Dictionary<LogicType, AbstractRequest>();
        private Dictionary<LogicType, AbstractRequest> deal_requesters = new Dictionary<LogicType, AbstractRequest>();
        private List<LogicType> removeList = new List<LogicType>();

        public void AddRequest(LogicType type, AbstractRequest request)
        {
            lock (requesters)
            {
                if (!requesters.ContainsKey(type))
                {
                    requesters.Add(type, request);
                }
            }
        }

        public void DoRequest()
        {
            lock (requesters)
            {
                foreach (var it in requesters)
                {
                    deal_requesters.Add(it.Key,it.Value);
                }
                requesters.Clear();
            }
            foreach (var it in deal_requesters)
            {
                it.Value.Request();
                if (it.Value.IsLoop)
                {
                }
                else
                {
                    removeList.Add(it.Key);
                }
            }
            foreach (var r in removeList)
            {
                deal_requesters.Remove(r);
            }
            removeList.Clear();
        }

        internal void Clear()
        {
            lock (requesters)
            {
                requesters.Clear();
            }
            deal_requesters.Clear();
            removeList.Clear();
        }
    }
}
