using Model.System;

namespace Model.Opcode
{
    public class OpcodeTypeComponentSystem : AAwakeSystem<OpcodeTypeComponent>
    {
        public override void Awake(OpcodeTypeComponent self)
        {
            self.Load();
        }
    }
}
