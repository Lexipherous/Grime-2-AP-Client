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
        [231201] = new LocationEnum(4, "fragments birthplace left"),
        [498091] = new LocationEnum(5, "OVERGROWN_BARRIER"),
        
        [-65034] = new LocationEnum(5, "HANDCLOTH_CHEST"),
        [-63824] = new LocationEnum(6, "HANDCLOTH_HANDS"),
        [-290390] = new LocationEnum(7, "KNIFEHAND"),
        [-61483] = new LocationEnum(8, "ATRIUM_SPIKE_PIT"),
        [-2068462] = new LocationEnum(9, "HANDCLOTH_LEGS"),
        [-4001340] = new LocationEnum(10, "FRAGMENTS BEFORE SEAL"),
        [-65034] = new LocationEnum(11, "ATRIUM ABOVE SEAL"),
        [-16365970] = new LocationEnum(12, "FRAGMENTS CHAINS ROOM 1"),
        [-16346351] = new LocationEnum(13, "FRAGMENTS CHAINS ROOM 2"),
        [-2558262] = new LocationEnum(14, "CLASPED_MACE"),
        [-71950] = new LocationEnum(15, "ATRIUM AFTER CLASPED MACE"),
        [-4272738] = new LocationEnum(16, "ITEM IN SPIKE PIT"),
        [-478360] = new LocationEnum(17, "FRAGMENTS UNDER SEALED CHAMBER"),
        [331596] = new LocationEnum(18, "BOUND SHELL"),
        [-908060] = new LocationEnum(19, "PRISMATIC PEARL ABOVE BOUND SHELL"),
        [-228152] = new LocationEnum(20, "LEFT OF HALL SURROGATE"),
        [-236336] = new LocationEnum(21, "RIGHT OF HALL SURROGATE"),
        [-245153] = new LocationEnum(22, "Embedding nail under Hall surrogate"),
        [3249986] = new LocationEnum(23, "THROWING THUMBS"),
        [-269954] = new LocationEnum(24, "ATRIUM UNDER YEARNING PAINT"),
        [-276879] = new LocationEnum(25, "ATRIUM ABOVE HALL"),
        [-232360] = new LocationEnum(26, "ATRIUM TOPLEFT HALL"),
        [-3418146] = new LocationEnum(27, "TOPLEFT HALL OVERGROWN BLOD"),
        [-220778] = new LocationEnum(28, "TOPLEFT ATRIUM"),
        [-6156777] = new LocationEnum(29, "FRAGMENTS ABOVE HALL"),
        [-2056161] = new LocationEnum(30, "Pearl Above Hall"),
        [-225757] = new LocationEnum(31, "ATRIUM Above hall, pluging finger"),
        [-4001340] = new LocationEnum(32, "Fragments above hunt HALL "),
        [-240260] = new LocationEnum(33, "Fragments after hunt on ledge"),
        [-215481] = new LocationEnum(34, "homing droplet after hunt"),
        [231201] = new LocationEnum(35, "fragments top left dried paint"),
        [-737262] = new LocationEnum(36, "atrium atop left dried paint"),
        [-474732] = new LocationEnum(37, "Formless Skin"),
        [-680796] = new LocationEnum(38, "embedding nail birthplace upper"),
        [-2052999] = new LocationEnum(39, "Atrium right of Hall"),
        [176047] = new LocationEnum(40, "birthplace force pickup"),
        [-11410638] = new LocationEnum(42, "Rust Fists"),
        
    };
    
    public readonly record struct ItemEnum(string gameId, string GameName, int quantity = 1);
    public static readonly Dictionary<long, ItemEnum> ItemTranslation = new() {
        [10007] = new ItemEnum("ff17e22a-c733-4b4f-9bb9-0b0c1f065cde", "Bloodmetal Scythe"),
        [11001] = new ItemEnum("96f4e840-0412-4231-824f-bba5ecbb0503", "Locked Sphere"),
        [12003] = new ItemEnum("cc3fc898-f110-418f-89be-72fa681469f9", "Bloodroot Splinter",3),
        
        [10001] = new ItemEnum("66737bdd-e371-4b5c-abe1-2b54365ce837", "Attuning Bow"),
        [10009] = new ItemEnum("cf98b165-e720-4dc9-8477-689648b937b0", "Clasped Mace"),
        [10021] = new ItemEnum("fce3835f-fe0e-46ee-8e0f-9c2ba1fee49c", "Knifehand"),
        [10023] = new ItemEnum("c53681b1-3628-42b5-ae88-5d05319d723f", "Maul Axe"),
        [10031] = new ItemEnum("3ae1652d-004c-49ef-9336-7106b9fc60cd", "Throwing Thumbs"),
        [12001] = new ItemEnum("924cc1b9-8b66-4302-9cf1-ae2b949a0ee6", "Bloodroot Chunk"),
        [12002] = new ItemEnum("3317fe57-2dd2-4d46-a124-050ad9e2754a", "Bloodroot Shard"),
        [12003] = new ItemEnum("cc3fc898-f110-418f-89be-72fa681469f9", "Bloodroot Splinter"),
        [12004] = new ItemEnum("2bdaab02-ba9f-4455-a907-f091e93c493b", "Thin Marah Strand"),
        [12005] = new ItemEnum("1d18e1f8-1cae-4498-8465-fb4c7ae13817", "Long Marah Strand"),
        [12006] = new ItemEnum("dfcc44ec-44b9-4694-8f75-af64ec09fba5", "Luscious Marah Strand"),
    };
}