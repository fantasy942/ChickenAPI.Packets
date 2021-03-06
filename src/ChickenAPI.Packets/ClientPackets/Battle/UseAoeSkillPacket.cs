﻿using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Battle
{
    [PacketHeader("u_as")]
    public class UseAoeSkillPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CastId { get; set; }

        [PacketIndex(1)]
        public short MapX { get; set; }

        [PacketIndex(2)]
        public short MapY { get; set; }
    }
}