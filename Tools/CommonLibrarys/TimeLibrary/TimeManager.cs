using Logger;
using System;
using UtilityLibrary;

namespace TimeLibrary
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
            Log.WriteLine("Init Time success!");
        }
    }
}
