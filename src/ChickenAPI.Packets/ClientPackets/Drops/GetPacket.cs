﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ClientPackets.Drops
{
    [PacketHeader("get")]
    public class GetPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType PickerType { get; set; }

        [PacketIndex(1)]
        public long PickerId { get; set; }

        [PacketIndex(2)]
        public long VisualId { get; set; }
    }
}