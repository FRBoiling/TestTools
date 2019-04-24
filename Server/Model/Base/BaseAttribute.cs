using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Base
{
    public class BaseAttribute : Attribute
    {
        public Type AttributeType { get; }

        public BaseAttribute()
        {
            this.AttributeType = this.GetType();
        }
    }
}
