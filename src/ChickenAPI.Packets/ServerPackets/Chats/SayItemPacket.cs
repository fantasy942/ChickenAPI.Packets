﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.ServerPackets.Inventory;

namespace ChickenAPI.Packets.ServerPackets.Chats
{
    [PacketHeader("sayitem")]
    public class SayItemPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public byte OratorSlot { get; set; }

        /// <summary>
        /// Spaces should be replaced by '^'
        /// </summary>
        [PacketIndex(3, IsOptional = true)]
        public string Message { get; set; }

        [PacketIndex(4, IsOptional = true, RemoveHash = true)]
        public IconInfoPacket IconInfo { get; set; }

        [PacketIndex(5, IsOptional = true, RemoveHash = true)]
        public EInfoPacket EquipmentInfo { get; set; }

        [PacketIndex(6, IsOptional = true, RemoveHash = true)]
        public SlInfoPacket SlInfo { get; set; }

    }
}