﻿namespace ChickenAPI.Packets.Enumerations
{
    public enum RbrPacketTsConditionType
    {
        AutomaticPartyTeleport = 0, //Automatic teleport into the TS for all the party members near the TS when the instance is started.
        CanEnterAlone = 1,
        FullPartyRequired = 2, // 3 members required
    }
}