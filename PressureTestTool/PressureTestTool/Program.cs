using DataProperty;
using Logger;
using ModelLibrary;
using PressureTestToolLib;
using System;
using System.IO;
using System.Threading;
using TimeLibrary;
using UtilityLibrary;

namespace PressureTestTool
{
    class Program
    {
        public static int Id = 0;
        public static bool bWorked = true;

        static void InitXml()
        {
            DataListManager.InitManager();
            string[] files = Directory.GetFiles(PathExt.FullPathFromServerData("XML"), "*.xml", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                DataListManager.inst.Parse(file);
            }
            Constant.inst.LoadXml();
        }

        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Id = int.Parse(args[0]);
            }
            LogManager.inst.Init(Id);
            PathExt.InitPath();
            TimeManager.inst.Init();
            InitXml();
            ConsoleInputHandler.inst.Init();
            CryptoManage.inst.Init();
            MovePatchManager.inst.Init();
            ProtocolGroupManager.inst.Init();
            ClientManager.inst.Init(Id);

            new Thread(ConsoleInputHandler.inst.Run).Start();
            Console.WriteLine("Ready to work ...");

            FrameManager fps = new FrameManager();
            fps.Init();
            fps.SetFPS(50);
            while (bWorked)
            {
                fps.SetFrameBegin();
                ClientManager.inst.Update();
                TimeManager.inst.RefreshTime();
                if (fps.GetFPSAndCpuInfo() != null && fps.GetFPSAndCpuInfo().fps < 10)
                {
                    if ((FrameManager.Now - FrameManager.FlagStartTime).TotalSeconds > 1)
                    {
                        Log.Error("fps warning!");
                    }
                }
                fps.SetFrameEnd();
            }
        }
    }
}
