﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Bazaar
{
    [PacketHeader("rc_reg")]
    public class RCRegPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType Type { get; set; }
    }
}