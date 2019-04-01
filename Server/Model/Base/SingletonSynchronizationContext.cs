using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Model.Base
{
    public class SingletonSynchronizationContext : SynchronizationContext
    {
        public static SingletonSynchronizationContext Instance { get; } = new SingletonSynchronizationContext();

        private readonly int mainThreadId = Thread.CurrentThread.ManagedThreadId;

        // 线程同步队列,发送接收socket回调都放到该队列,由poll线程统一执行
        private readonly ConcurrentQueue<Action> queue = new ConcurrentQueue<Action>();

        private Action action;

        public void Update()
        {
            while (true)
            {
                if (!this.queue.TryDequeue(out action))
                {
                    return;
                }
                action();
            }
        }

        public override void Post(SendOrPostCallback callback, object state)
        {
            Log.Debug($"current thread id {Thread.CurrentThread.ManagedThreadId}");
            if (Thread.CurrentThread.ManagedThreadId == this.mainThreadId)
            {
                callback(state);
                return;
            }

            this.queue.Enqueue(() => { callback(state); });
        }
    }
}
