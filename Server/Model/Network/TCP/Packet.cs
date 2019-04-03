using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Network.TCP
{
    public static class Packet
    {
        public const int PacketSizeLength2 = 2;
        public const int PacketSizeLength4 = 4;
        public const int MinPacketSize = 2;
        public const int OpcodeIndex = 0;
        public const int MessageIndex = 2;
    }
}
