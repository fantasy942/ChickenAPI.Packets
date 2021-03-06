﻿using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlpt")]
    public class MinilandPointPacket : PacketBase
    {
        [PacketIndex(0)]
        public long MinilandPoint { get; set; }

        [PacketIndex(0)]
        public byte Unknown { get; set; }
    }
}
