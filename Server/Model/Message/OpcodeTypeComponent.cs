using Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Message
{
    public class OpcodeTypeComponent : Component
    {
        private readonly DoubleMap<ushort, Type> opcodeTypes = new DoubleMap<ushort, Type>();

        private readonly Dictionary<ushort, object> typeMessages = new Dictionary<ushort, object>();

        public void Load()
        {
            this.opcodeTypes.Clear();
            this.typeMessages.Clear();

            List<Type> types = Game.EventSystem.GetTypes(typeof(MessageAttribute));
            foreach (Type type in types)
            {
                object[] attrs = type.GetCustomAttributes(typeof(MessageAttribute), false);
                if (attrs.Length == 0)
                {
                    continue;
                }

                MessageAttribute messageAttribute = attrs[0] as MessageAttribute;
                if (messageAttribute == null)
                {
                    continue;
                }

                this.opcodeTypes.Add(messageAttribute.Opcode, type);
                this.typeMessages.Add(messageAttribute.Opcode, Activator.CreateInstance(type));
            }
        }

        public ushort GetOpcode(Type type)
        {
            return this.opcodeTypes.GetKeyByValue(type);
        }

        public Type GetType(ushort opcode)
        {
            return this.opcodeTypes.GetValueByKey(opcode);
        }

        // 客户端为了0GC需要消息池，服务端消息需要跨协程不需要消息池
        public object GetInstance(ushort opcode)
        {
			Type type = this.GetType(opcode);
			return Activator.CreateInstance(type);
        }

        public override void Dispose()
        {
            if (this.IsDisposed)
            {
                return;
            }

            base.Dispose();
        }
    }
}
