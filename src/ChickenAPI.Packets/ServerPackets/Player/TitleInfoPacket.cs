﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Player
{
    [PacketHeader("titinfo")]
    public class TitleInfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public short VisibleTitle { get; set; }

        [PacketIndex(3)]
        public short EffectiveTitle { get; set; }
    }
}