using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Base
{
    public class ComponentQueue : Component
    {
        public string TypeName { get; }

        private readonly Queue<Component> queue = new Queue<Component>();

        public ComponentQueue(string typeName)
        {
            this.TypeName = typeName;
        }

        public void Enqueue(Component component)
        {
            component.Parent = this;
            this.queue.Enqueue(component);
        }

        public Component Dequeue()
        {
            return this.queue.Dequeue();
        }

        public Component Peek()
        {
            return this.queue.Peek();
        }

        public int Count
        {
            get
            {
                return this.queue.Count;
            }
        }

        public override void Dispose()
        {
            if (this.IsDisposed)
            {
                return;
            }
            base.Dispose();

            while (this.queue.Count > 0)
            {
                Component component = this.queue.Dequeue();
                component.IsFromPool = false;
                component.Dispose();
            }
        }
    }
}
