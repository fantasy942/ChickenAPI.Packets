﻿namespace ChickenAPI.Packets.Enumerations
{
    public enum WindowType : byte
    {
        ItemToPart = 0,
        UpgradeItem = 1, //  UpgradeMode.Normal, UpgradeProtection.None, hasAmulet: HasAmulet
        CellonItem = 3,
        RarifyItem = 7, // mode, protection
        SumResistance = 8,
        UpgradeSpNoProtection = 9, // UpgradeProtection.None
        UpgradeItemProtected = 20, // UpgradeMode.Normal, UpgradeProtection.Protected, hasAmulet: HasAmulet
        RarifyItemProtected = 21, // RarifyMode.Normal, RarifyProtection.Scroll
        UpgradeSpProtected = 25, // Scroll Blue or red - Need to verify
        UpgradeSpProtected2 = 26, // Scroll Blue or red - Need to verify
        Production = 27,
        Production2 = 28,
        ExamineRelics = 29,
        Exchange = 30,
        NosBazaar = 32,
        ExamineRelics2 = 33,
        UpgradeSpChiken = 35, // Scroll Chiken - event
        ListFamilySkills = 37,
        UpgradeSpPyjama = 38, // Scroll Pyjama - Event
        PerfectSp = 41,
        UpgradeSpPirate = 42, // Scroll Pirate - Event
        UpgradeItemGoldScroll = 43, // UpgradeMode.Reduced, UpgradeProtection.Protected, hasAmulet: hasAmulet ( Gold scroll)
        GoldenSPCardHolder = 44,
        CreateFairyZenas = 50,
        CreateFairyErenia = 51,
        CreateFairyFernon = 52,
        FusionItem = 53,
    }
}
