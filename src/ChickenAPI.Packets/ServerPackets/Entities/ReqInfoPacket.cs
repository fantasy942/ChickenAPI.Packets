﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Entities
{
    [PacketHeader("req_info")]
    public class ReqInfoPacket : IPacket
    {
        [PacketIndex(0)]
        public ReqInfoType ReqType { get; set; }

        [PacketIndex(1)]
        public long TargetVNum { get; set; }

        [PacketIndex(2)]
        public int? MateVNum { get; set; }
    }
}