using Model.Base;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Model.Network
{
    public abstract class AService : Component
    {
        public abstract AChannel GetChannel(long id);

        private Action<AChannel> acceptCallback;

        public event Action<AChannel> AcceptCallback
        {
            add
            {
                this.acceptCallback += value;
            }
            remove
            {
                this.acceptCallback -= value;
            }
        }

        protected void OnAccept(AChannel channel)
        {
            this.acceptCallback.Invoke(channel);
        }

        public abstract AChannel ConnectChannel(IPEndPoint ipEndPoint);

        public abstract AChannel ConnectChannel(string address);

        public abstract void Remove(long channelId);

        public abstract void Update();
    }
}

