using System;
using System.Collections.Generic;
using System.Text;

namespace Model.System
{
    public interface IEvent
    {
        void Handle();
        void Handle(object a);
        void Handle(object a, object b);
        void Handle(object a, object b, object c);
    }
}
