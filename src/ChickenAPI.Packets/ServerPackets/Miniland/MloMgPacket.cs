﻿using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlo_mg")]
    public class MloMgPacket : PacketBase
    {
        [PacketIndex(0)]
        public short MinigameVNum { get; set; }

        [PacketIndex(1)]
        public long MinilandPoint { get; set; }

        [PacketIndex(2)]
        public byte Unknown1 { get; set; }

        [PacketIndex(3)]
        public byte Unknown2 { get; set; }

        [PacketIndex(4)]
        public long DurabilityPoint { get; set; }

        [PacketIndex(5)]
        public long MinilandObjectPoint { get; set; }
    }
}