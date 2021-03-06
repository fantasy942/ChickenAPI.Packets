﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Player
{
    [PacketHeader("fs")]
    public class FsPacket : PacketBase
    {
        [PacketIndex(0)]
        public FactionType Faction { get; set; }
    }
}