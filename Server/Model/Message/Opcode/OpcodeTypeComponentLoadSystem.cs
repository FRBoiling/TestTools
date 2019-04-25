using Model.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Opcode
{
    public class OpcodeTypeComponentLoadSystem : ALoadSystem<OpcodeTypeComponent>
    {
        public override void Load(OpcodeTypeComponent self)
        {
            self.Load();
        }
    }

}
