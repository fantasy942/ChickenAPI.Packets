﻿using System.ComponentModel.DataAnnotations;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("sell")]
    public class SellPacket : IPacket
    {
        [PacketIndex(2)]
        public short Data { get; set; }

        [PacketIndex(3)]
        public byte? Slot { get; set; }

        [PacketIndex(4)]
        [Range(1, short.MaxValue)]
        public short? Amount { get; set; }
    }
}