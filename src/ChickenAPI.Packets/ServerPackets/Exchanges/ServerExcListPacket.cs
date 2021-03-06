﻿using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Exchanges
{
    [PacketHeader("exc_list")]
    public class ServerExcListPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public long? Gold { get; set; }

        [PacketIndex(3)]
        public long? BankGold { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public List<ServerExcListSubPacket> SubPackets { get; set; }
    }
}