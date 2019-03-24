using System;
using System.Diagnostics;
using System.Threading;

namespace TimeLibrary
{
    public class FpsAndCpuInfo
    {
        public double fps = 0;
        public double sleepTime = 0;
        public long memorySize = 0;
    }

    public class FrameManager
    {
        double FPS = 40;
        const double ONESECOND = 1000.0;
        /// <summary>
        /// 每帧耗时 （单位 millisecond）
        /// </summary>
        private double _timePerFrame;
        private double TimePerFrame
        {
            get { return _timePerFrame; }
        }

        static DateTime _now;
        public static DateTime Now
        {
            get
            {
                return _now;
            }
        }

        /// <summary>
        /// 标示时间起点（1秒）
        /// </summary>
        static DateTime _flagStartTime;
        public static DateTime FlagStartTime
        {
            get
            {
                return _flagStartTime;
            }
        }

        /// <summary>
        /// 上次frameBegin时间
        /// </summary>
        DateTime _lastUpdateTime;
        /// <summary>
        /// 下次frameBegin时间
        /// </summary>
        DateTime _nextUpdateTime;

        /// <summary>
        /// 当前帧开始时间
        /// </summary>
        DateTime _curFrameBeginTime;
        /// <summary>
        /// 当前帧结束时间
        /// </summary>
        DateTime _curFrameEndTime;

        /// <summary>
        /// 帧数
        /// </summary>
        private int _frames = 0;
        /// <summary>
        /// 睡眠数
        /// </summary>
        private double _sleepTimes = 0;

        /// <summary>
        /// 统计时间
        /// </summary>
        private int _statTime = 0;
        /// <summary>
        /// 统计帧数
        /// </summary>
        private double _statFrames = 0;
        /// <summary>
        /// 统计睡眠时间
        /// </summary>
        private double _statSleepTime = 0;

        /// <summary>
        /// fps 平均值
        /// </summary>
        private double _averageFramesPerSecond = 0;
        /// <summary>
        /// 每秒睡眠时间 平均值
        /// </summary>
        private double _averageSleepTimePerSecond = 0;

        /// <summary>
        /// 统计最近10秒内的 平均FPS和CPU睡眠时间
        /// </summary>
        FpsAndCpuInfo _msg = null;
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            _now = DateTime.Now;
            _flagStartTime = Now;
            _lastUpdateTime = Now;
            _nextUpdateTime = Now;
            _curFrameBeginTime = Now;
            _curFrameEndTime = Now;
            _frames = 0;
            _sleepTimes = 0;
            _statTime = 0;
            _statFrames = 0;
            _statSleepTime = 0;
            _averageFramesPerSecond = 0;
            _averageSleepTimePerSecond = 0;
            _msg = null;
            _timePerFrame = ONESECOND / FPS;
        }
        /// <summary>
        /// 设置帧起点
        /// </summary>
        public void SetFrameBegin()
        {
            DateTime curTime = DateTime.Now;
            //while (curTime < _nextUpdateTime)
            //{
            //    curTime = DateTime.Now;
            //    Thread.Sleep(1);
            //}
            TimeSpan n = _nextUpdateTime - curTime;
            if (n.TotalMilliseconds > 0)
            {
                Thread.Sleep(n);
                curTime = curTime + n;
            }

            _frames++;
            _curFrameBeginTime = curTime;
            _sleepTimes += (curTime - _lastUpdateTime).TotalMilliseconds;

        }
        /// <summary>
        /// 设置帧结束点
        /// </summary>
        public void SetFrameEnd()
        {
            DateTime curTime = DateTime.Now;

            _curFrameEndTime = curTime;
            _lastUpdateTime = _curFrameEndTime;
            _nextUpdateTime = _lastUpdateTime.AddMilliseconds(Math.Max((TimePerFrame - (curTime - _curFrameBeginTime).TotalMilliseconds), 0));

            if ((curTime - _flagStartTime).TotalSeconds > 1)
            {
                //以1秒为周期进行记录
                _msg = RecordFPSAndCpuInfo(_frames, (int)_sleepTimes);
                _flagStartTime = curTime;
                _sleepTimes = 0;
                _frames = 0;
            }
        }
        /// <summary>
        // 统计最近10秒内的 平均FPS和CPU睡眠时间，反映当前进程状态
        /// </summary>
        /// <param name="frameCount">1秒内的帧数</param>
        /// <param name="sleepTime">1秒内睡眠时间</param>
        private FpsAndCpuInfo RecordFPSAndCpuInfo(int frameCount, int sleepTime)
        {
            //10秒一个周期 记录平均值
            if (_statTime < 10)
            {
                _statFrames += frameCount;
                _statSleepTime += sleepTime;
                _statTime++;
            }
            else
            {
                _averageFramesPerSecond = (int)_statFrames / _statTime;
                _averageSleepTimePerSecond = (int)_statSleepTime / _statTime;
                FpsAndCpuInfo msg = new FpsAndCpuInfo();
                msg.fps = _averageFramesPerSecond;
                msg.sleepTime = _averageSleepTimePerSecond;
                Process proc = Process.GetCurrentProcess();
                msg.memorySize = (long)(proc.PrivateMemorySize64 / (1024 * 1024));
                _statTime = 0;
                _statFrames = 0;
                _statSleepTime = 0;
                return msg;
            }
            return _msg;
        }
        /// <summary>
        /// 获取 平均值
        /// </summary>
        /// <returns></returns>
        public FpsAndCpuInfo GetFPSAndCpuInfo()
        {
            return _msg;
        }
        public void ClearFPSAndCpuInfo()
        {
            _msg = null;
        }
        public int GetFrame()
        {
            return (int)_averageFramesPerSecond;
        }
        public int GetSleep()
        {
            return (int)_averageSleepTimePerSecond;
        }
        /// <summary>
        /// 设置 fps
        /// </summary>
        /// <param name="fps"> fps值</param>
        /// <returns></returns>
        public void SetFPS(double fps)
        {
            FPS = fps;
            _timePerFrame = ONESECOND / FPS;
            Console.WriteLine("Set a new FPS: {0}", FPS);
        }
    }
}
