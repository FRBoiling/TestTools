using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Message
{
    public interface IMessageDispatcher
    {
        void Dispatch(Session session, ushort opcode, object message);
    }
}
