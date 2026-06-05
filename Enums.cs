namespace Grime2APClient.Enums;


public class Grime2Dicts
{
    
    /*Grime2LocationData("Temple of Hands", LocTemple.BIRTHPLACE_MAUL_AXE, 1, -130168),
    Grime2LocationData("Temple of Hands", LocTemple.BIRTHPLACE_ATRIUM_1, 2, -131692),
    Grime2LocationData("Temple of Hands", LocTemple.BIRTHPLACE_ATRIUM_2, 3, -131290),
    Grime2LocationData("Temple of Hands", LocTemple.HANDCLOTH_CHEST, 4, -65034),*/
    
    public readonly record struct LocationEnum(int apId, string WorldTextName);
    
    public static readonly Dictionary<int, LocationEnum> TempleIds = new() {
        [-130168] = new LocationEnum(1, "BIRTHPLACE_MAUL_AXE"),
        [-131692] = new LocationEnum(2, "BIRTHPLACE_ATRIUM_1"),
        [-131290] = new LocationEnum(3, "BIRTHPLACE_ATRIUM_2"),
        [498091] = new LocationEnum(4, "OVERGROWN_BARRIER"),
        [-65034] = new LocationEnum(5, "HANDCLOTH_CHEST"),
        
    };
    
    public readonly record struct ItemEnum(string gameId, string GameName, int quantity = 1);
    public static readonly Dictionary<long, ItemEnum> ItemTranslation = new() {
        [10007] = new ItemEnum("ff17e22a-c733-4b4f-9bb9-0b0c1f065cde", "Bloodmetal Scythe"),
        [11001] = new ItemEnum("96f4e840-0412-4231-824f-bba5ecbb0503", "Locked Sphere"),
        [12003] = new ItemEnum("cc3fc898-f110-418f-89be-72fa681469f9", "Bloodroot Splinter",3),
    };
}