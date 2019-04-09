using System;
using System.Collections.Generic;
using System.Text;
using Model.Base;

namespace Model
{
    public class ObjectPool : Component
    {
        public string Name { get; set; }

        private readonly Dictionary<Type, ComponentQueue> dictionary = new Dictionary<Type, ComponentQueue>();

        public Component Fetch(Type type)
        {
            Component obj;
            if (!this.dictionary.TryGetValue(type, out ComponentQueue queue))
            {
                obj = (Component)Activator.CreateInstance(type);
            }
            else if (queue.Count == 0)
            {
                obj = (Component)Activator.CreateInstance(type);
            }
            else
            {
                obj = queue.Dequeue();
            }

            obj.IsFromPool = true;
            return obj;
        }

        public T Fetch<T>() where T : Component
        {
            T t = (T)this.Fetch(typeof(T));
            return t;
        }

        public void Recycle(Component obj)
        {
            obj.Parent = this;
            Type type = obj.GetType();
            ComponentQueue queue;
            if (!this.dictionary.TryGetValue(type, out queue))
            {
                queue = new ComponentQueue(type.Name);
                queue.Parent = this;
                this.dictionary.Add(type, queue);
            }
            queue.Enqueue(obj);
        }

        public void Clear()
        {
            foreach (var kv in this.dictionary)
            {
                kv.Value.IsFromPool = false;
                kv.Value.Dispose();
            }
            this.dictionary.Clear();
        }
    }
}
    