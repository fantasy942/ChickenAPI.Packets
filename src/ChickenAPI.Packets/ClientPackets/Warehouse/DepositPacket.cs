﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ClientPackets.Warehouse
{
    [PacketHeader("deposit")]
    public class DepositPacket : PacketBase
    {     
        [PacketIndex(0)]
        public PocketType Inventory { get; set; }

        [PacketIndex(1)]
        public byte Slot { get; set; }

        [PacketIndex(2)]
        public short Amount { get; set; }

        [PacketIndex(3)]
        public byte NewSlot { get; set; }

        [PacketIndex(4)]
        public bool PartnerBackpack { get; set; }
    }
}