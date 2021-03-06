﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.ServerPackets.Movement;

namespace ChickenAPI.Packets.ServerPackets.Parcel
{
    [PacketHeader("parcel")]
    public class ParcelPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public byte Unknown { get; set; }

        [PacketIndex(2)]
        public short Id { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public ParcelAttachmentSubPacket ParcelAttachment { get; set; }
    }
}