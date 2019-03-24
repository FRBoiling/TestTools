using System.Collections.Generic;

namespace PressureTestToolMaster
{
    public partial class Session
    {
        public delegate void Requester(string commond);
        private Queue<Requester> requesters = new Queue<Requester>();
        private Dictionary<int,Requester> loopRequesters = new Dictionary<int,Requester>();

        public void ClearRequest()
        {
            requesters.Clear();
            loopRequesters.Clear();
        }

        //public void AddResqueueter(string commond)
        //{
        //    Request_Commond(commond);
        //}

        //public void AddRobot(int count)
        //{
        //    Request_Login(count);
        //}
    }
}
