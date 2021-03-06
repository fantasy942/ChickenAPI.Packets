﻿using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Groups
{
    [PacketHeader("pinit")]
    public class PinitPacket : PacketBase
    {
        [PacketIndex(0)]
        public int GroupSize { get; set; }

        [PacketIndex(1, SpecialSeparator = "|")]
        public List<PinitSubPacket> PinitSubPackets { get; set; }
    }
}