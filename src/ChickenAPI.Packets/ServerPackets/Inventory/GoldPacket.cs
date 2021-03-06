﻿using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Inventory
{
    [PacketHeader("gold")]
    public class GoldPacket : PacketBase
    {
        [PacketIndex(0)]
        public long Gold { get; set; }

        [PacketIndex(1)]
        public int Unknown { get; set; }
    }
}