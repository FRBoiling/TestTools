using Model.Base;
using System;
using System.Threading;

namespace TestApp
{
    class Program
    {
        private static int loopCount = 0;

        private static void Main()
        {
            SingletonSynchronizationContext _ = SingletonSynchronizationContext.Instance;

            WaitTimeAsync(5000, WaitTimeFinishCallback);

            while (true)
            {
                SingletonSynchronizationContext.Instance.Update();

                Thread.Sleep(1);

                ++loopCount;
                if (loopCount % 10000 == 0)
                {
                    Console.WriteLine($"loop count: {loopCount}");
                }
            }
        }

        private static void WaitTimeAsync(int waitTime, Action action)
        {
            Thread thread = new Thread(() => WaitTime(waitTime, action));
            thread.Start();
        }

        private static void WaitTimeFinishCallback()
        {
            Console.WriteLine($"WaitTimeAsync finsih loopCount的值是: {loopCount}");
        }

        /// <summary>
        /// 在另外的线程等待
        /// </summary>
        private static void WaitTime(int waitTime, Action action)
        {
            Thread.Sleep(waitTime);

            // 将action扔回主线程执行
            SingletonSynchronizationContext.Instance.Post((o) => action(), null);
        }
    }
}
