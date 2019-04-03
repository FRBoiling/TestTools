using Model.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Base
{
    public abstract class Component : Object, IDisposable
    {
        public long InstanceId { get; private set; }

        private bool isFromPool;

        public bool IsFromPool
        {
            get
            {
                return this.isFromPool;
            }
            set
            {
                this.isFromPool = value;

                if (!this.isFromPool)
                {
                    return;
                }

                if (this.InstanceId == 0)
                {
                    this.InstanceId = IdGenerater.GenerateInstanceId();
                }
            }
        }

        public bool IsDisposed
        {
            get
            {
                return this.InstanceId == 0;
            }
        }

        private Component parent;

        public Component Parent
        {
            get
            {
                return this.parent;
            }
            set
            {
                this.parent = value;
            }
        }

        public T GetParent<T>() where T : Component
        {
            return this.Parent as T;
        }

        public Entity Entity
        {
            get
            {
                return this.Parent as Entity;
            }
        }

        protected Component()
        {
            this.InstanceId = IdGenerater.GenerateInstanceId();
        }


        public virtual void Dispose()
        {
            if (this.IsDisposed)
            {
                return;
            }

            // 触发Destroy事件
            Game.EventSystem.Destroy(this);

            Game.EventSystem.Remove(this.InstanceId);

            this.InstanceId = 0;

            if (this.IsFromPool)
            {
                Game.ObjectPool.Recycle(this);
            }
            else
            {
            }
        }

        public override void EndInit()
        {
            Game.EventSystem.Deserialize(this);
        }

        public override string ToString()
        {
            return MongoHelper.ToJson(this);
        }
    }
}
