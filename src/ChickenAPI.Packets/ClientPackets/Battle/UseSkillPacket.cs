﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Battle
{
    [PacketHeader("u_s")]
    public class UseSkillPacket : IPacket
    {
        [PacketIndex(0)]
        public long CastId { get; set; }

        [PacketIndex(1)]
        public VisualType TargetVisualType { get; set; }

        [PacketIndex(2)]
        public long TargetId { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public short? MapX { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public short? MapY { get; set; }
    }
}