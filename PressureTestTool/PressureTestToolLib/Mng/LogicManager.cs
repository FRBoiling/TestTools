using PressureTestToolLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLibrary;

namespace PressureTestToolLib
{
    public enum LogicType
    {
        Login = 1,
        Move = 2,
    }
    public class LogicManager
    {
        private Dictionary<LogicType, AbstractRequest> requesters = new Dictionary<LogicType, AbstractRequest>();

        public void Init()
        {
            AddRequest(LogicType.Login, new Request_Login());
            AddRequest(LogicType.Move, new Request_Move());
        }

        private void AddRequest(LogicType type, AbstractRequest request)
        {
            if (!requesters.ContainsKey(type))
            {
                requesters.Add(type, request);
            }
        }

        private AbstractRequest RemoveRequest(LogicType type)
        {
            AbstractRequest request = null;
            if (requesters.TryGetValue(type, out request))
            {
                requesters.Remove(type);
            }
            else
            {
                return null;
            }
            return request;
        }

        public AbstractRequest GetRequester(LogicType type)
        {
            AbstractRequest request = null;
            requesters.TryGetValue(type, out request);
            return request;
        }

    }
}
