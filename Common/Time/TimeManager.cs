using LibUtil;
using System;

namespace LibTime
{
    public class TimeManager : Singleton<TimeManager>
    {
        public DateTime Now = DateTime.Now;
        public void RefreshTime()
        {
            Now = DateTime.Now;
        }

        public void Init()
        {
            Now = DateTime.Now;
            Console.WriteLine("Init Time success!");
        }
    }
}
