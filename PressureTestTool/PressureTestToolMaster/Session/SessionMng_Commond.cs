using System;
using System.Threading;

namespace PressureTestToolMaster
{
    public partial class SessionMng
    {
        //public void AddRequest(string commond)
        //{
        //    foreach (var session in _sessions)
        //    {
        //        try
        //        {
        //            Thread.Sleep(500);
        //            session.Value.AddResqueueter(commond);
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("{0}", e);
        //        }
        //    }
        //}

        //public void AddClient(int totalCount)
        //{
        //    int nLen = 1;
        //    if (_sessions.Count <=0)
        //    {
        //        nLen = 1;
        //    }
        //    else
        //    {
        //        nLen = _sessions.Count;
        //    }
        //    int realcount = totalCount / nLen;
        //    foreach (var session in _sessions)
        //    {
        //        try
        //        {
        //            session.Value.AddRobot(realcount);
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("{0}", e);
        //        }
        //    }
        //}
    }
}
