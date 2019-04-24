﻿using System;
using System.Diagnostics;
using System.Threading;
using Model;
using Model.Base;
using NLog;

namespace App
{


    internal static class Program
	{
        public static int AppId = 1001;

        public static AppType AppType = AppType.Realm;

        public static string ServerIP = "192.168.10.123";

        private static void Main(string[] args)
		{

            // 异步方法全部会回掉到主线程
            SynchronizationContext.SetSynchronizationContext(SingletonSynchronizationContext.Instance);
            switch (AppType)
            {
                case AppType.Realm:
                    Game.Scene.AddComponent<ActorMessageDispatcherComponent>();
                    Game.Scene.AddComponent<NetInnerComponent, string>(innerConfig.Address);
                    Game.Scene.AddComponent<NetOuterComponent, string>(outerConfig.Address);
                    break;
            }
            //LogManager.Configuration.Variables["appType"] = $"{AppType}";
            //LogManager.Configuration.Variables["appId"] = $"{AppId}";
            //LogManager.Configuration.Variables["appTypeFormat"] = $"{AppType,-8}";
            //LogManager.Configuration.Variables["appIdFormat"] = $"{AppId:0000}";
            //while (true)
            //{
            //    Log.Trace($"server start.............Trace........... {AppId} {AppType}");
            //    Log.Debug($"server start.............Debug........... {AppId} {AppType}");
            //    Log.Info($"server start.............Info............ {AppId} {AppType}");
            //    Log.Warn($"server start.............Warn........... {AppId} {AppType}");
            //    Log.Error($"server start.............Error........... {AppId} {AppType}");
            //    Log.Fatal($"server start.............Fatal........... {AppId} {AppType}");
            //}

            Console.ReadKey();
        }
    }
}
