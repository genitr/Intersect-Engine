﻿namespace Intersect.Migration.UpgradeInstructions.Upgrade_1.Intersect_Convert_Lib
{
    public enum GameObject
    {
        Animation = 0,
        Class,
        Item,
        Npc,
        Projectile,
        Quest,
        Resource,
        Shop,
        Spell,
        Map,
        CommonEvent,
        PlayerSwitch,
        PlayerVariable,
        ServerSwitch,
        ServerVariable,
        Tileset,
    }

    public enum ClientPackets
    {
        Ping = 0,
        Login,
        NeedMap,
        SendMove,
        LocalMessage,
        EditorLogin,
        SaveMap,
        CreateMap,
        EnterMap,
        TryAttack,
        SendDir,
        EnterGame,
        ActivateEvent,
        EventResponse,
        CreateAccount,
        PickupItem,
        SwapItems,
        DropItems,
        UseItem,
        SwapSpells,
        ForgetSpell,
        UseSpell,
        UnequipItem,
        UpgradeStat,
        HotbarChange,
        MapListUpdate,
        CreateCharacter,
        OpenAdminWindow,
        AdminAction,
        NeedGrid,
        UnlinkMap,
        LinkMap,
        SellItem,
        BuyItem,
        CloseShop,
        DepositItem,
        WithdrawItem,
        MoveBankItem,
        CloseBank,
        NewGameObject,
        OpenObjectEditor,
        SaveGameObject,
        DeleteGameObject,
    }

    public enum ServerPackets
    {
        RequestPing = 0,
        ServerConfig,
        JoinGame,
        MapData,
        EntityData,
        EntityPosition,
        EntityLeave,
        ChatMessage,
        GameData,
        EnterMap,
        EntityMove,
        EntityVitals,
        EntityStats,
        EntityDir,
        EventDialog,
        MapList,
        LoginError,
        MapItems,
        MapItemUpdate,
        InventoryUpdate,
        SpellUpdate,
        PlayerEquipment,
        StatPoints,
        HotbarSlots,
        CreateCharacter,
        OpenAdminWindow,
        MapGrid,
        CastTime,
        SendSpellCooldown,
        Experience,
        ProjectileSpawnDead,
        SendAlert,
        HoldPlayer,
        ReleasePlayer,
        SendPlayAnimation,
        PlayMusic,
        FadeMusic,
        PlaySound,
        StopSounds,
        OpenShop,
        CloseShop,
        OpenBank,
        CloseBank,
        BankUpdate,
        GameObject,
        GameObjectEditor,
        EntityDash,
        EntityAttack,
    }

    public enum MapZones
    {
        Normal = 0,
        Safe = 1
    }

    public enum Stats
    {
        Attack = 0,
        AbilityPower,
        Defense,
        MagicResist,
        Speed,
        StatCount
    }

    public enum Vitals
    {
        Health,
        Mana,
        VitalCount
    }

    public enum ItemTypes
    {
        None = 0,
        Equipment = 1,
        Consumable = 2,
        Currency = 3,
        Spell = 4,
        Event = 5,
    }

    public enum SpellTypes
    {
        CombatSpell = 0,
        Warp = 1,
        WarpTo = 2,
        Dash = 3,
        Event = 4,
    }

    public enum SpellTargetTypes
    {
        Self = 0,
        Single = 1,
        AoE = 2,
        Projectile = 3,
    }

    public enum TargetTypes
    {
        Hover = 0,
        Selected = 1,
    }

    public enum MapListUpdates
    {
        MoveItem = 0,
        AddFolder = 1,
        Rename = 2,
        Delete = 3,
    }

    public enum AdminActions
    {
        WarpTo = 0,
    }

    public enum EntityTypes
    {
        GlobalEntity = 0,
        Player = 1,
        Resource = 2,
        Projectile = 3,
        Event = 4,
    }

    public enum Directions
    {
        Up = 0,
        Down,
        Left,
        Right
    }

    public enum SwitchVariableTypes
    {
        PlayerSwitch = 0,
        PlayerVariable,
        ServerSwitch,
        ServerVariable,
    }

    public enum StatusTypes
    {
        None = 0,
        Silence = 1,
        Stun = 2,
        Snare = 3,
        Blind = 4,
        Stealth = 5,
        Transform = 6,
    }

    public enum ItemBonusEffects
    {
        CooldownReduction = 0,
        LifeSteal
    }

    // Map Attribtes
    public enum MapAttributes
    {
        Walkable = 0,
        Blocked,
        Item,
        ZDimension,
        NpcAvoid,
        Warp,
        Sound,
        Resource,
        Animation,
        GrappleStone,
        Slide
    }

    public enum NpcBehavior
    {
        AttackWhenAttacked = 0,
        AttackOnSight,
        Friendly,
        Guard,
    }
}