using System;

namespace TimeLibrary
{
    public static class Timestamp
    {
        public static readonly DateTime UnixStartTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));

        public static UInt64 GetUnixTimeStamp(DateTime time)
        {
            UInt64 timestamp = (UInt64)(time - UnixStartTime).TotalMilliseconds;
            return timestamp;
        }

        public static int GetUnixTimeStampSeconds(DateTime time)
        {
            return (int)(time - UnixStartTime).TotalSeconds;
        }

        public static DateTime TimeStampToDateTime(UInt64 unixTimestamp)
        {
            DateTime dt = UnixStartTime.AddMilliseconds(unixTimestamp);
            return dt;
        }

        public static DateTime TimeStampToDateTime(int unixTimestamp)
        {
            DateTime dt = UnixStartTime.AddSeconds(unixTimestamp);
            return dt;
        }
    }
}
