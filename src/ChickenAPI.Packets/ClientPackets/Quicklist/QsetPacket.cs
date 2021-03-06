﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ClientPackets.Quicklist
{
    [PacketHeader("qset")]
    public class QsetPacket : PacketBase
    {
        [PacketIndex(0)]
        public QSetType Type { get; set; }

        [PacketIndex(1)]
        public short OriginQuickList { get; set; }

        [PacketIndex(2)]
        public short OriginQuickListSlot { get; set; }

        [PacketIndex(3)]
        public short? FirstData { get; set; }

        [PacketIndex(4)]
        public short? SecondData { get; set; }
    }
}