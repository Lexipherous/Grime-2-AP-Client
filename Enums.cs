namespace Grime2APClient.Enums;


public class Grime2Dicts
{
    
    /*Grime2LocationData("Temple of Hands", LocTemple.BIRTHPLACE_MAUL_AXE, 1, -130168),
    Grime2LocationData("Temple of Hands", LocTemple.BIRTHPLACE_ATRIUM_1, 2, -131692),
    Grime2LocationData("Temple of Hands", LocTemple.BIRTHPLACE_ATRIUM_2, 3, -131290),
    Grime2LocationData("Temple of Hands", LocTemple.HANDCLOTH_CHEST, 4, -65034),*/
    
    private static readonly long LocationBaseID = 6942013371314159;
    public readonly record struct LocationEnum(int apId, string WorldTextName);

    public static readonly Dictionary<int, LocationEnum> TempleIds = new()
    {
        [163122] = new LocationEnum(1, "Temple-Birthplace: Surrogate"), // World Text/Area/Temple/Checkpoint 1
        [-130168] = new LocationEnum(2, "Temple-Birthplace-Lower: Maul Axe"),
        [-131692] = new LocationEnum(3, "Temple-Birthplace-Lower: Atrium Left"),
        [-131290] = new LocationEnum(4, "Temple-Birthplace-Lower: Atrium Right"),
        [498091] = new LocationEnum(5, "Temple-Birthplace-Lower: Left of Surrogate"),
        [231201] = new LocationEnum(6, "Temple-Birthplace-Lower: Overgrown Barrier"),

        [-474732] = new LocationEnum(7, "Temple-Birthplace-Upper: Formless Skin"),
        [-680796] = new LocationEnum(8, "Temple-Birthplace-Upper: Embedding Nail"),
        [176047] = new LocationEnum(9, "Temple-Birthplace-Upper: Force Capacity Upgrade"),

        [163122] = new LocationEnum(10, "Temple-Dried Paint: Surrogate"), // World Text/Area/Temple/Checkpoint 2
        [-411008] = new LocationEnum(11, "Temple-Dried Paint: Seal"),
        [-65034] = new LocationEnum(12, "Temple-Dried Paint: Handcloth Chest"),
        [-63824] = new LocationEnum(13, "Temple-Dried Paint: Handcloth Hands"),
        [-290390] = new LocationEnum(14, "Temple-Dried Paint: Knifehand"),
        [-61483] = new LocationEnum(15, "Temple-Dried Paint: Hidden Atrium in spike pit"),
        [-2068462] = new LocationEnum(16, "Temple-Dried Paint: Handcloth Legs"),
        [-4001340] = new LocationEnum(17, "Temple-Dried Paint: Fragments before Seal"),
        [-65034] = new LocationEnum(18, "Temple-Dried Paint: Atrium above seal"),
        [-16365970] = new LocationEnum(19, "Temple-Dried Paint: Fragments in Chains Room 1"),
        [-16346351] = new LocationEnum(20, "Temple-Dried Paint: Fragments in Chains Room 2"),
        [-2558262] = new LocationEnum(21, "Temple-Dried Paint: Clasped Mace"),
        [-71950] = new LocationEnum(22, "Temple-Dried Paint: Hidden Atrium after Clasped Mace"),
        [-4272738] = new LocationEnum(23, "Temple-Dried Paint: Item in Spike Pit"),
        [231201] = new LocationEnum(24, "Temple-Dried Paint: Fragments past Spike Gap Above Surrogate"),
        [-737262] = new LocationEnum(25, "Temple-Dried Paint: Atrium past Spike Gap Above Surrogate"),

        [682908046] = new LocationEnum(26, "Temple-Sealed Chamber: Surrogate"), // World Text/Area/Temple/Checkpoint 3
        [-478360] = new LocationEnum(27, "Temple-Sealed Chamber: Fragments under Surrogate"),
        [331596] = new LocationEnum(28, "Temple-Sealed Chamber: Bound Shell drop"),
        [-908060] = new LocationEnum(29, "Temple-Sealed Chamber: Pearl above Surrogate"),

        [682908046] = new LocationEnum(30, "Temple-Hall: Surrogate"), // World Text/Area/Temple/Checkpoint 4
        [-472583] = new LocationEnum(31, "Temple-Hall: Seal"),
        [-228152] = new LocationEnum(32, "Temple-Hall: Left of Surrogate"),
        [-236336] = new LocationEnum(33, "Temple-Hall: Right of Surrogate"),
        [-245153] = new LocationEnum(34, "Temple-Hall: Ceiling item under Surrogate"),
        [3249986] = new LocationEnum(35, "Temple-Hall: Throwing Thumbs"),
        [-269954] = new LocationEnum(36, "Temple-Hall: Ceiling item under Yearning Paint NPC"),
        [-276879] = new LocationEnum(37, "Temple-Hall: Atrium above Surrogate"),
        [-232360] = new LocationEnum(38, "Temple-Hall: Atrium through gap above Surrogate"),
        [-3418146] = new LocationEnum(39, "Temple-Hall: Overgrown Blob in top-left"),
        [-220778] = new LocationEnum(40, "Temple-Hall: Atrium in top-left"),
        [-6156777] = new LocationEnum(41, "Temple-Hall: Fragments on ledge above Surrogate"),
        [-2056161] = new LocationEnum(42, "Temple-Hall: Pearl Above Hall"),
        [-225757] = new LocationEnum(43, "Temple-Hall: Ceiling Atrium near top"),
        [-4001340] = new LocationEnum(44, "Temple-Hall: Fragments after Hunt Prey "),
        [-240260] = new LocationEnum(45, "Temple-Hall: Fragments after Hunt Prey on ledge"),
        [-215481] = new LocationEnum(46, "Temple-Hall: Item after Hunt Prey behind wall"),
        [-2052999] = new LocationEnum(47, "Temple-Hall: Atrium right of Knifehand"),
        [-11410638] = new LocationEnum(48, "Temple-Hall: Rust Fists"),
        [-8923429] = new LocationEnum(49, "Temple-Hall: Bloodroot Splinter"),


        [-899401] = new LocationEnum(0, "Mudfalls-Hidden Alcove: Surrogate"),
        [-4821536] = new LocationEnum(0, "Mudfalls: Atrium left of Alcove Surrogate"),
        [-3418594] = new LocationEnum(0, "Mudfalls: Fragments, breakable floor left of Alcove Surrogate"),
        [-1050026] = new LocationEnum(0, "Mudfalls: Overgrown Blob left of Alcove Surrogate"),
        [2125770] = new LocationEnum(0, "Mudfalls: Bloodroot by Alcove Surrogate"),
        [-4825730] = new LocationEnum(0, "Mudfalls: Atrium after Alcove Surrogate"),
        [-1330473] = new LocationEnum(0, "Mudfalls: Mudfalls Delivery Item"),
        [75605] = new LocationEnum(0, "Mudfalls: Bloodroot Splinter near Palladium Elevator"),
        [-3418594] = new LocationEnum(0, "Mudfalls: Hidden Fragments near Palladium Elevator"),
        [-12547286] =
            new LocationEnum(0,
                "Mudfalls: Lump of Hands near Palladium Elevator"), // Needs jump boost and Grasp Hook and Grasp Slide
        [-5460941] =
            new LocationEnum(0, "Mudfalls: Pearl by Chisel Door"), // Needs jump boost and Grasp Hook and Grasp Slide
        [-565248] = new LocationEnum(0, "Mudfalls: Seal by Manzil's House"),
        [-4841441] = new LocationEnum(0, "Mudfalls-Manzils HouseExt: Top floor - Breakable floor Force"),
        [-3333341] = new LocationEnum(0, "Mudfalls-Manzils House: Prismatic Pearl"),
        [-3329257] =
            new LocationEnum(0, "Mudfalls: Pearl above Manzils House"), // Needs Grasp Hook OR Burst Jump or Handjump
        [-204959] = new LocationEnum(0, "Mudfalls: Sigil Barrier high above Manzil's House"), // Burst Jump or Handjump
        [-1659388] = new LocationEnum(0, "Mudfalls: Atrium above Manzil's House"), // Wall Jump
        [-3420776] =
            new LocationEnum(0, "Mudfalls: Homing Droplet above Manzil's House"), // HandJump AND Air Dash OR Wall Jump
        [-2320546] =
            new LocationEnum(0,
                "Mudfalls: Reinforcing Weave above Manzil's House"), // ((HandJump AND Air Dash) OR Wall Jump) AND Item Grasp
        [-3348632] =
            new LocationEnum(0,
                "Mudfalls: Lump of Hands top-left of Manzil's House"), // Grasp Hook AND Grasp Slide AND (BurstJumpORHandJump) AND Air Dash
        [75668] = new LocationEnum(0,
            "Mudfalls: Bloodroot Chunk high above Manzils House"), // Grasp Hook AND Grasp Slide AND (BurstJumpORHandJump) AND Air Dash AND WallJump`
        [-3064732] =
            new LocationEnum(0,
                "Mudfalls: Luscious Marah Strand in platforming area before Manzil's House."), // Wall Jump AND Grasp Hook
        [-266586] = new LocationEnum(0, "Mudfalls: Homing Droplet underground left of Manzil's House"),
        [75605] = new LocationEnum(0, "Mudfalls: Bloodroot Splinter underground left of Manzil's House"),
        [-259810] = new LocationEnum(0, "Mudfalls: Atrium in wall gap underground"),
        [-6869090] = new LocationEnum(0, "Mudfalls: Heart of a Dancer in Spike Pit"), // Item Grasp
        [-1050026] = new LocationEnum(0, "Mudfalls: Forged Littles Armor Set"),
        [231201] = new LocationEnum(0, "Mudfalls: Fragments in far right"),
        [-63518] = new LocationEnum(0, "Mudfalls: Overgrown Blob in far right"),
        [-2090335] = new LocationEnum(0, "Mudfalls: Seal far right"),
        [-54420] = new LocationEnum(0, "Mudfalls: Pearl below Seal on the right"),
        [360556] = new LocationEnum(0, "Mudfalls: Overgrown Blob"),
        [-82942] = new LocationEnum(0, "Mudfalls: Atrium before Faceless Mountains"),
        [-259810] = new LocationEnum(0, "Mudfalls: Forged Stake"), // BARRIER/Underheads . Wall Jump (Burst/Hand Jump)
        [-2503524] =
            new LocationEnum(0,
                "Mudfalls: Throwing Stars"), // Chisel Key // Needs jump boost and Grasp Hook and Grasp Slide

        [-2025829] = new LocationEnum(0, "Faceless Mountains: Halfmade Pit Surrogate"),
        [-5205525] = new LocationEnum(0, "Faceless Mountains: Pearl above Surrogate"), //(2812.89, 1847.89, 0.00)
        [-2649266] =
            new LocationEnum(0,
                "Faceless Mountains: Spike Ball Above Surrogate"), // (2772.26, 1856.95, 0.21) (Wall Climb AND Dash Slide) OR Item Grasp AND (Wall Clumb OR Hand Jump OR Burst Jump)
        [-2649266] = new LocationEnum(0, "Faceless Mountains: Bloodroot Splinter"), //(2788.52, 1869.90, 2.86)
        [-2080584] = new LocationEnum(0, "Faceless Mountains: Seal (Upper)"),
        [-6016342] =
            new LocationEnum(0, "Faceless Mountains: Spike Ball in pit under Faceless Hunt"), //(2893.77, 1872.37, 0.00)
        [-8865795] = new LocationEnum(0, "Faceless Mountains: Fragments below upper Seal"), //(2918.18, 1870.25, 0.00)
        [-6016342] =
            new LocationEnum(0,
                "Faceless Mountains: Attuning Bow"), //(2967.00, 1879.89, 0.00) HandJump OR BurstJump OR ItemGrasp
        [-5232493] = new LocationEnum(0, "Faceless Mountains: Surrogate - Intertwining Nail"),
        [-2653618] =
            new LocationEnum(0, "Faceless Mountains: Atrium in long Faceless room."), // (2934.56, 1852.77, 0.00) 
        [-1286712] =
            new LocationEnum(0, "Faceless Mountains: Atrium in long Faceless room."), // (2881.10, 1852.91, 0.00)
        [-85346] = new LocationEnum(0,
            "Faceless Mountains: Spike Ball in long Faceless room."), // (2870.44, 1865.35, 0.00)
        [-247214284] =
            new LocationEnum(0,
                "Faceless Mountains: Homing Droplet in long Faceless room."), // (2947.61, 1857.55, 0.00)
        [-53609] = new LocationEnum(0, "Faceless Mountains: Grunt Garbs Hands"), // (2882.61, 1839.75, 0.00)
        [75605] = new LocationEnum(0,
            "Faceless Mountains: Bloodroot Splinter after long Faceless Room"), // (2861.54, 1851.36, 1.65)
        [-39062] = new LocationEnum(0, "Faceless Mountains: Grunt Garbs Legs"), // (2851.52, 1835.63, 0.00) Grasp
        [-2651450] = new LocationEnum(0, "Faceless Mountains: Grunt Garbs Chest"), // (2825.33, 1835.62, 0.00)
        [-3737340] =
            new LocationEnum(0, "Faceless Mountains: Fragments above Melded Giant (Left)"), // (2761.71, 1818.63, 0.00)
        [-3737786] =
            new LocationEnum(0, "Faceless Mountains: Fragments above Melded Giant (Right)"), // (2794.31, 1818.57, 0.00)
        [2480078] = new LocationEnum(0, "Faceless Mountains: Melded Giant Reward"), // (2780.23, 1801.55, 0.00)
        [-8865795] =
            new LocationEnum(0,
                "Faceless Mountains: Fragments near Mudfalls"), // (2718.90, 1813.66, 0.00) - Grasp OR Hand Jump OR Burst Jump
        // Galloping Dropot only needs Wall CLimb
        [-100088] = new LocationEnum(0, "Faceless Mountains: Brute Garbs Hands"), // (2921.84, 1816.16, 0.00) - Grasp
        [-2869320] = new LocationEnum(0, "Faceless Mountains: Faceless Spear"), // (2882.89, 1816.46, 0.00)
        [-2833950] = new LocationEnum(0, "Faceless Mountains: Seal (By Tree Roots)"),
        [-3289494] = new LocationEnum(0, "Faceless Mountains: Brute Garbs Chest"), // (2948.63, 1829.22, 1.00)
        [-100088] = new LocationEnum(0, "Faceless Mountains: Brute Garbs Legs"), //(2962.94, 1833.30, 0.00)
        [-3171870] =
            new LocationEnum(0, "Faceless Mountains: Bloodroot Splinter before Darsh"), //(2986.82, 1834.81, 2.45)
        [-3740013] =
            new LocationEnum(0, "Faceless Mountains: Overgrown Blob"), // (3040.50, 1849.97, 0.00) Volatile Vase
        [498091] = new LocationEnum(0, "Faceless Mountains: Faceless Bishop Darsh"), // (3062.66, 1863.24, 0.00)
        [-1419899] =
            new LocationEnum(0,
                "Faceless Mountains: Atrium #1 near Wanting Tree"), //(3044.94, 1878.21, 0.00) WallJump AND Grasphook
        [-2330071] =
            new LocationEnum(0,
                "Faceless Mountains: Atrium #2 near Wanting Tree"), //(3003.69, 1900.64, 0.00) WallJump AND Grasphook AND BurstJump/Handjump
        [75605] = new LocationEnum(0,
            "Faceless Mountains: Bloodroot Splinter near Wanting Tree"), //(2999.23, 1907.21, 1.43) WallJump AND Grasphook AND BurstJump/Handjump
        [75602] = new LocationEnum(0,
            "Faceless Mountains: Bloodroot Shard near Wanting Tree"), //(2996.89, 1907.14, 1.31) WallJump AND Grasphook AND BurstJump/Handjump
        [75668] = new LocationEnum(0,
            "Faceless Mountains: Bloodroot Chunk by Intertwining Nail Surrogate"), // (2993.80, 1882.43, 2.14) (Handjump OR BurstJump) AND Wall BClimb
        //["03_FacelessMountains_14:-10049494"] = new LocationEnum(0, "Faceless Mountains: Bottom of Elevator after Darsh"), // (3083.73, 1793.72, 0.00)

        [-5656911] = new LocationEnum(0, "Underheads: Surrogate - Sunken Faces "),
        [-3513696] = new LocationEnum(0, "Underheads: Seal - Sunken Faces "),
    };
    public static readonly Dictionary<string, LocationEnum> Locations = new() {
        ["05_Underheads_20:75605"] = new LocationEnum(0, "Underheads: Bloodroot from Mudfalls, near Sunked Faces Surrogate"), // (2808.81, 1687.65, 3.63)
        ["05_Underheads_05:-22446721"] = new LocationEnum(0, "Underheads: Spike Ball in wall gap, right of Sunken Faces"), // (2936.80, 1681.07, 0.00)
        ["05_Underheads_06:-7519404"] = new LocationEnum(0, "Underheads: Forged Pick"), // (2868.86, 1674.18, 0.00) //GraspANDGraspHook
        ["05_Underheads_06:-7380661"] = new LocationEnum(0, "Underheads: Scatter Stone near Forged Pick"), // (2897.26, 1664.04, 0.00)
        ["05_Underheads_06:-10257227"] = new LocationEnum(0, "Underheads: Fragments after Forged Pick"), // (2878.11, 1642.50, 0.00)
        ["05_Underheads_06:-2624242"] = new LocationEnum(0, "Underheads: Forged Boulder Chest"), // (2849.44, 1656.24, 0.00)
        ["05_Underheads_23:-22453799"] = new LocationEnum(0, "Underheads: Spike Ball, platforming under left Seal"), // (2777.20, 1657.60, 0.00)
        ["05_Underheads_23:75605"] = new LocationEnum(0, "Underheads: Bloodroot below left Seal"), // (2810.22, 1652.82, 3.81)
        ["05_Underheads_23:-22454741"] = new LocationEnum(0, "Underheads: Scatter Stone in falling sand room"), // (2739.41, 1646.54, 0.00)
        ["05_Underheads_24:-2699432"] = new LocationEnum(0, "Underheads: Marah Strand near Dropot Runner"), // (2814.13, 1625.98, 5.12)
        ["05_Underheads_18:1084940"] = new LocationEnum(0, "Underheads: Hidden Atrium in falling sand descent room"), // (2845.20, 1630.88, 0.36)
        ["05_Underheads_17:-5849332"] = new LocationEnum(0, "Underheads: Scatter Stone behind wall near Forged Boulder Legs"), // (2889.82, 1617.93, 0.00)
        ["05_Underheads_16:-22451873"] = new LocationEnum(0, "Underheads: Forged Boulder Hands"), // (2981.51, 1640.19, 0.00) // (GraspANDGraspHook) AND (WallClimb Or AirDash)
        ["05_Underheads_16:75605"] = new LocationEnum(0, "Underheads: Bloodroot by Forged Boulder Hands"), // (2963.75, 1653.54, 5.80)
        ["05_Underheads_07:-5661621"] = new LocationEnum(0, "Underheads: Seal (Right)"), // (2935.53, 1672.72, 0.00)
        ["05_Underheads_06:-2347346"] = new LocationEnum(0, "Underheads: Atrium below right Seal #1"), // (2896.62, 1645.55, 0.00)
        ["05_Underheads_06:-22446721"] = new LocationEnum(0, "Underheads: Atrium below right Seal #2"), // (2924.09, 1645.55, 0.00)
        ["05_Underheads_17:246068"] = new LocationEnum(0, "Underheads: Atrium below right Seal gap in wall"), // (2896.94, 1629.70, 0.00)
        ["05_Underheads_17:-2367744"] = new LocationEnum(0, "Underheads: Forged Boulder Legs"), // (2917.83, 1624.70, 0.00)
        ["05_Underheads_02:-7519404"] = new LocationEnum(0, "Underheads: Spike Ball above SF Surrogate platforming"), // (2835.19, 1722.02, 0.34) // GraspANDGraspHook
        ["05_Underheads_02:-647354"] = new LocationEnum(0, "Underheads: Alveoli Tree at top"), // (2790.40, 1766.82, 0.00) // GraspAndGraspHook
        ["05_Underheads_08:-8843070"] = new LocationEnum(0, "Underheads: Atrium below Forged Sergeant Hunt"), // (2979.14, 1661.42, 0.00)
        ["05_Underheads_08:-5660294"] = new LocationEnum(0, "Underheads: Surrogate - Curling Nails"), // (3028.85, 1670.58, 0.00)
        ["05_Underheads_09:-5870628"] = new LocationEnum(0, "Underheads: Smidge of Paint above CN Surrogate"), // (3051.15, 1680.45, 0.00) // Grasphook AND WallJump
        ["05_Underheads_09:14214086"] = new LocationEnum(0, "Underheads: Mountainborn Reward"), // (3070.11, 1661.89, 0.00)
        ["05_Underheads_11:75605"] = new LocationEnum(0, "Underheads: Bloodroot right of Mountainborn"), // (3119.75, 1676.72, 1.80)
        ["05_Underheads_09:-2699432"] = new LocationEnum(0, "Underheads: Marah Strand above Mountainborn room"), // (3067.92, 1693.37, 9.23)
        ["05_Underheads_09:-94685"] = new LocationEnum(0, "Underheads: Overgrown Blob Above Mountainborn room"), // (3056.57, 1703.07, 0.00) //BurstJumpOrHandJumpANDWallJump
        ["05_Underheads_08:-3435540"] = new LocationEnum(0, "Underheads: Barbed Sword"), // (3005.15, 1713.21, 0.00)//GraspANDGraspHookANDWallJump
        ["05_Underheads_09:-88328"] = new LocationEnum(0, "Underheads: Hidden Homing Droplets right of Mountainborn"), // (3089.03, 1674.74, 0.00)
        ["05_Underheads_09:-3064732"] = new LocationEnum(0, "Underheads: Marah Strand in Mountainborn Room"), // (3062.17, 1682.89, 0.00) BurstJumpANDAirDashANDWallJump
        ["05_Underheads_10:10459504"] = new LocationEnum(0, "Underheads: Third Lahav Knight Reward"), // (3014.98, 1641.51, 0.00)
        ["05_Underheads_15:-2165452"] = new LocationEnum(0, "Underheads: Bloodroot on Jagged Forest path"), // (3149.53, 1634.22, 7.41)
        ["05_Underheads_02:-1065414"] = new LocationEnum(0, "Underheads: Atrium platforming path from Mudfalls #1"), // (2783.53, 1754.23, 0.34) //AirDashANDWallJump(GraspHookANDGrasp)
        ["05_Underheads_02:-1065016"] = new LocationEnum(0, "Underheads: Atrium platforming path from Mudfalls #2"), // (2787.59, 1754.23, 0.34)
        ["05_Underheads_02:-7515698"] = new LocationEnum(0, "Underheads: Force platforming path from Mudfalls"), // (2791.21, 1754.23, 0.00)
        
        ["07_NailGlade_04:-697800"] = new LocationEnum(0, "Nailglade: Lahavist Nomad Legs"), // (3006.79, 1629.63, 0.00)
        ["07_NailGlade_04:-699780"] = new LocationEnum(0, "Nailglade: Lahavist Nomad Hands"), // (3008.96, 1629.63, 0.00)
        ["07_NailGlade_04:-700212"] = new LocationEnum(0, "Nailglade: Lahavist Nomad Chest"), // (3011.04, 1629.63, 0.00)

        /*[] = new LocationEnum(0, "Underheads: "),
        [] = new LocationEnum(0, "Underheads: "),
        [] = new LocationEnum(0, "Underheads: "),
        [] = new LocationEnum(0, "Underheads: "),
        [] = new LocationEnum(0, "Underheads: "),
        [] = new LocationEnum(0, "Underheads: "),
        [] = new LocationEnum(0, "Underheads: "),*/
        
        
        //[-6304979] = new LocationEnum(0, "Dregbourg: Entrance Surrogate"),
        /*[] = new LocationEnum(0, "Dregbourg: "),
        [] = new LocationEnum(0, "Dregbourg: "),
        [] = new LocationEnum(0, "Dregbourg: "),
        [] = new LocationEnum(0, "Dregbourg: "),
        [] = new LocationEnum(0, "Dregbourg: "),
        [] = new LocationEnum(0, "Dregbourg: "),
        [] = new LocationEnum(0, "Dregbourg: "),
        [] = new LocationEnum(0, "Dregbourg: "),
        [] = new LocationEnum(0, "Dregbourg: "),
        [] = new LocationEnum(0, "Dregbourg: "),
        [] = new LocationEnum(0, "Dregbourg: "),
        [] = new LocationEnum(0, "Dregbourg: "),
        [] = new LocationEnum(0, "Dregbourg: "),*/
        
        /*[0] = new LocationEnum(0, "m: "),
        [0] = new LocationEnum(0, "Orchard: "),*/
        //["04_Hairlock_01:163122"] = new LocationEnum(0, "Orchard: Surrogate - Bridge to Kankan"), // (3208.98, 1758.49, 0.00)
        ["04_Hairlock_01:-2699432"] = new LocationEnum(0, "Orchard: Marah Strand left of Surrogate"), // (3183.10, 1762.29, 0.94)
        ["05_Underheads_13:-5180110"] = new LocationEnum(0, "Orchard: Discarded Flesh near Surrogate"), // (3181.19, 1716.19, 6.00)
        /*[0] = new LocationEnum(0, "Orchard: "),
        [0] = new LocationEnum(0, "Kankan: "),
        [0] = new LocationEnum(0, "Kankan: "),
        [0] = new LocationEnum(0, "Kankan: "),
        [0] = new LocationEnum(0, "Jagged Forest: "),
        [0] = new LocationEnum(0, "Jagged Forest: "),
        [0] = new LocationEnum(0, "Jagged Forest: "),
        [0] = new LocationEnum(0, "Blade Garden: "),
        [0] = new LocationEnum(0, "Blade Garden: "),
        [0] = new LocationEnum(0, "Blade Garden: "),
        [0] = new LocationEnum(0, "Nailglade: "),
        [0] = new LocationEnum(0, "Nailglade: "),
        [0] = new LocationEnum(0, "Nailglade: "),
        [0] = new LocationEnum(0, "Tree Roots: "),
        [0] = new LocationEnum(0, "Tree Roots: "),
        [0] = new LocationEnum(0, "Tree Roots: "),
        [0] = new LocationEnum(0, "Paint Reef: "),
        [0] = new LocationEnum(0, "Paint Reef: "),
        [0] = new LocationEnum(0, "Paint Reef: "),
        [0] = new LocationEnum(0, "Palladium: "),
        [0] = new LocationEnum(0, "Palladium: "),
        [0] = new LocationEnum(0, "Palladium: "),
        [0] = new LocationEnum(0, "Fallen Path: "),
        [0] = new LocationEnum(0, "Fallen Path: "),
        [0] = new LocationEnum(0, "Fallen Path: "),
        [0] = new LocationEnum(0, "Mudpits: "),
        [0] = new LocationEnum(0, "Mudpits: "),
        [0] = new LocationEnum(0, "Mudpits: "),
        [0] = new LocationEnum(0, "Skyrise: "),
        [0] = new LocationEnum(0, "Skyrise: "),
        [0] = new LocationEnum(0, "Starmire: "),
        [0] = new LocationEnum(0, "Starmire: "),
        [0] = new LocationEnum(0, "Starmire: "),
        [0] = new LocationEnum(0, "WantingTree: "),
        [0] = new LocationEnum(0, "WantingTree: "),
        [0] = new LocationEnum(0, "WantingTree: "),*/
    };

    private static readonly long ItemBaseID = 6942013372314159;
    public readonly record struct ItemEnum(List<string> gameId, string GameName, int quantity = 1);
    public static readonly Dictionary<long, ItemEnum> ItemTranslation = new() {
        [ItemBaseID+10001] = new ItemEnum(new List<string> { "66737bdd-e371-4b5c-abe1-2b54365ce837" }, "Attuning Bow"),
        [ItemBaseID+10002] = new ItemEnum(new List<string> { "b9487eac-9a9c-4b5d-9cbf-b005fee33576" }, "Barbed Sword"),
        [ItemBaseID+10003] = new ItemEnum(new List<string> { "5c109ef3-40cf-4b23-98b7-eb75429259fa" }, "Beak Fists"),
        [ItemBaseID+10004] = new ItemEnum(new List<string> { "4763f53f-1ae9-4ee8-91e7-a939d859cf3c" }, "Beast Bow"),
        [ItemBaseID+10005] = new ItemEnum(new List<string> { "b31dad4f-1bc3-4488-b60c-c3efab095664" }, "Bladeroot Greatsword"),
        [ItemBaseID+10006] = new ItemEnum(new List<string> { "10b865ed-b6bf-41a2-b8c1-8973d9c011c8" }, "Bladeroot Sword"),
        [ItemBaseID+10007] = new ItemEnum(new List<string> { "ff17e22a-c733-4b4f-9bb9-0b0c1f065cde" }, "Bloodmetal Scythe"),
        [ItemBaseID+10008] = new ItemEnum(new List<string> { "87391639-26d9-4354-a9a3-bc6eaa98368d" }, "Bowblades"),
        [ItemBaseID+10009] = new ItemEnum(new List<string> { "cf98b165-e720-4dc9-8477-689648b937b0" }, "Clasped Mace"),
        [ItemBaseID+10010] = new ItemEnum(new List<string> { "af1d39e2-a98a-477a-8db8-ba8cc2444b8f" }, "Clawing Scythe"),
        [ItemBaseID+10011] = new ItemEnum(new List<string> { "c67a2c34-2e7a-472d-bef8-268eebfecc8d" }, "Faceless Spear"),
        [ItemBaseID+10012] = new ItemEnum(new List<string> { "cc6c9d0b-fa48-41cf-ba63-8f78d3590d8d" }, "Finger Fists"),
        [ItemBaseID+10013] = new ItemEnum(new List<string> { "ac20f040-1b8b-4433-be12-3d9b09889e48" }, "Fingerclump Mace"),
        [ItemBaseID+10014] = new ItemEnum(new List<string> { "9bec668b-e98a-4837-acad-42d15c09ab99" }, "Forged Fists"),
        [ItemBaseID+10015] = new ItemEnum(new List<string> { "71bd683f-41e8-4829-8a22-665277113c2f" }, "Forged Pick"),
        [ItemBaseID+10016] = new ItemEnum(new List<string> { "3a0adcbe-ed7b-47c4-95c3-fd3f400f8f28" }, "Forged Stake"),
        [ItemBaseID+10017] = new ItemEnum(new List<string> { "f4d79025-f995-409d-b60d-51ee7efa885a" }, "Goel Greatsword"),
        [ItemBaseID+10018] = new ItemEnum(new List<string> { "d6617c66-b217-4f3a-a954-dcf2b788be7e" }, "Goz Sickle"),
        [ItemBaseID+10019] = new ItemEnum(new List<string> { "7aa15bf2-d502-4372-a951-d09449c52efd" }, "Gripping Greataxe"),
        [ItemBaseID+10020] = new ItemEnum(new List<string> { "0e6f2e0c-8006-4496-b665-72905eaad418" }, "Jaw Axe"),
        [ItemBaseID+10021] = new ItemEnum(new List<string> { "fce3835f-fe0e-46ee-8e0f-9c2ba1fee49c" }, "Knifehand"),
        [ItemBaseID+10022] = new ItemEnum(new List<string> { "07f07e35-9df6-4eb6-9f68-857a46345a2e" }, "Mammoth Axe"),
        [ItemBaseID+10023] = new ItemEnum(new List<string> { "c53681b1-3628-42b5-ae88-5d05319d723f" }, "Maul Axe"),
        [ItemBaseID+10024] = new ItemEnum(new List<string> { "cfc541a1-945a-4906-8b83-d41c7e92ae99" }, "Nail Bow"),
        [ItemBaseID+10025] = new ItemEnum(new List<string> { "f92e6e09-c70c-4e15-b26d-e3c4106be29b" }, "Pitcher Spear"),
        [ItemBaseID+10026] = new ItemEnum(new List<string> { "d43099d9-3c6b-456a-88f9-094a91d3728a" }, "Raking Sword"),
        [ItemBaseID+10027] = new ItemEnum(new List<string> { "7240ae79-0ad4-4449-9540-f8f512457a93" }, "Rust Fists"),
        [ItemBaseID+10028] = new ItemEnum(new List<string> { "825d901c-6a41-466a-895c-b6bdbb0d0b2d" }, "Spearhand"),
        [ItemBaseID+10029] = new ItemEnum(new List<string> { "3665b49e-5528-46d5-b3d4-19d90950e71b" }, "Throwing Nails"),
        [ItemBaseID+10030] = new ItemEnum(new List<string> { "848f020e-fe1a-469d-8d94-41fa4db7a65b" }, "Throwing Stars"),
        [ItemBaseID+10031] = new ItemEnum(new List<string> { "3ae1652d-004c-49ef-9336-7106b9fc60cd" }, "Throwing Thumbs"),
        [ItemBaseID+10032] = new ItemEnum(new List<string> { "ab2f39c4-635f-44d5-b18c-244d0558a8fb" }, "Tooth Hammer"),
        [ItemBaseID+10033] = new ItemEnum(new List<string> { "e5f49c7f-29cf-4f12-8fdc-3d675051e435" }, "Zev Blades"),
        [ItemBaseID+10034] = new ItemEnum(new List<string> { "c1a447c6-43a7-4831-9be6-aba40b230482" }, "Alloybark Cleavers"),
        [ItemBaseID+10035] = new ItemEnum(new List<string> { "e78045b1-86b2-4308-8dc5-3f4148a2eb60" }, "Bladeroot Javelin"),
        [ItemBaseID+10036] = new ItemEnum(new List<string> { "7887cce0-0309-4819-a68d-943be60c2ad5" }, "Coda Scythesword"),
        
        [ItemBaseID+10101] = new ItemEnum(new List<string> { "720a72fd-459d-487d-9591-9ececc1c587e", "5e5e4fbb-771b-400b-b1be-fb45e919201b", "f7943e1f-c043-4a4c-a17c-3df4d2a50aac" }, "Beastplate Set"),
        [ItemBaseID+10102] = new ItemEnum(new List<string> { "b2ed4405-b468-49ac-8f22-22ba44f4267b", "8a2291e9-d7da-4f57-be68-37d9487a3733", "ad9ae90a-6c8f-42f9-9b4b-11ea4419172f" }, "Brute Garbs Set"),
        [ItemBaseID+10103] = new ItemEnum(new List<string> { "05cfff68-4f4f-4776-a75f-8a3a4f99851e", "83af4229-22f1-4a51-b1e2-23cb9046266d", "00b3e702-894f-4206-bc04-367d3240c333" }, "Fallen Greatblade Set"),
        [ItemBaseID+10104] = new ItemEnum(new List<string> { "f6212e1a-49c2-4199-a7e1-672cfed98399", "a00da0a7-d80b-4e4c-be9f-6626beca7ae3", "a8cdd79f-16e7-4e73-a6ef-3e77f080dd24" }, "Forged Boulder Set"),
        [ItemBaseID+10105] = new ItemEnum(new List<string> { "5f83be6e-4837-4c7d-b460-8823f7fd74ff", "465c9617-ca1e-4f39-8169-37ea3c51438b", "cd612f69-1d94-4a2c-a979-6db03b7444b5" }, "Forged Littles Set"),
        [ItemBaseID+10106] = new ItemEnum(new List<string> { "4d418789-6a50-4455-9a62-20b8621c4471", "e750627b-ac3e-4aaf-a896-2d1557d94aad", "d1192172-89f7-451c-88b8-3eaea318611a" }, "Forged Pebble Set"),
        [ItemBaseID+10107] = new ItemEnum(new List<string> { "d386423d-c418-4a7a-be4b-5be8d0c931e6", "335cd052-0420-4c0c-8bfb-4d0bf05e65a5", "31fa0f10-ed33-43ec-8e53-ed743dfaf260" }, "Formless Set"),
        [ItemBaseID+10108] = new ItemEnum(new List<string> { "73e50441-4f76-40bf-9b20-98eecbb8f1c5", "98ff4506-15b9-4b7e-baee-7e5b6aa3e29b", "099c73f1-92ad-4589-8e55-6426d8f99e51" }, "Grunt Garbs Set"),
        [ItemBaseID+10109] = new ItemEnum(new List<string> { "041ff148-dfcd-4ed1-9641-80f7470c5588", "4b9d51c9-4491-468a-9ca7-22329c426d02", "9a72cf2d-8aea-436e-a1e0-99f31fe1414b" }, "Handcloth Set"),
        [ItemBaseID+10110] = new ItemEnum(new List<string> { "eb160faa-79e3-408c-bae5-48941cd1d1ae", "7d32a074-52e8-48b0-bc20-084c50be9a57", "4ac3f38a-9a80-4483-8a9d-0d35ff5174c7" }, "Impaled Smithed Set"),
        [ItemBaseID+10111] = new ItemEnum(new List<string> { "4054e484-c0dd-4eea-92ac-8f708b622b70", "2d18ef7d-2b40-46cf-b14a-05969a012ef0", "7b4b3b15-bec5-42d5-83d6-36bf22ab9986" }, "Lahavist Nomad Set"),
        [ItemBaseID+10112] = new ItemEnum(new List<string> { "630cda1e-a048-489a-a724-cd38fb156513", "2afe46d0-95eb-4582-a6ab-6b6dc616b42b", "de0362aa-73aa-4965-9ead-164cca469832" }, "Lahavist Wanderer Set"),
        [ItemBaseID+10113] = new ItemEnum(new List<string> { "4c5f1b84-350f-4b76-a01d-c953d5eac148", "240e9e8a-33c2-47b8-a6ab-416db64bc4e0", "5338de2b-0da9-46e9-ba94-7b0ca10aabd5" }, "Mask Collector Set"),
        [ItemBaseID+10114] = new ItemEnum(new List<string> { "93ba5086-aac6-4fd5-90d9-f7525fb20adc", "ba241aba-b5c4-48e7-9310-a0e87ac731c6", "12b5172c-6c83-4751-b5bd-2328cb773cbf" }, "Nailglade Fighter Set"),
        [ItemBaseID+10115] = new ItemEnum(new List<string> { "bb1c9823-4095-49ed-bb33-3ed4c85f1038", "349deb58-4627-42d0-8034-4fd5df4390c3", "3c5dbbbc-b470-4243-b444-830dd4c8c04a" }, "Nailglade Scout Set"),
        [ItemBaseID+10116] = new ItemEnum(new List<string> { "f14540c8-a915-4feb-bc52-c86a16200b3f", "0ca4e3d0-4c24-41f9-af94-c523410f55d5", "956f3f3b-1b65-4cd5-a0fe-bd1a85f473a8" }, "Orchard Homage Set"),
        [ItemBaseID+10117] = new ItemEnum(new List<string> { "dec2a8ef-be32-43cb-85ac-ddd75ab4074d", "8fcba95c-779f-4183-b9bb-57bb72921346", "ce26d157-f9c0-455e-89c1-9100106038b8" }, "Penpierced Set"),
        [ItemBaseID+10118] = new ItemEnum(new List<string> { "6469ed00-2319-4823-b618-dc35efcecf2f", "bb7f1ee6-ae63-4fbe-ba2e-6a612f2dd8ca", "f2418b3d-0be0-4c6a-89c9-c23743964da9" }, "Pitcher Guard Set"),
        [ItemBaseID+10119] = new ItemEnum(new List<string> { "f6cf7215-a4b0-449a-9c86-7e3bc3d72ffc", "179f749b-24a7-4dbe-a82d-242eadf2e9fc", "d51d9b19-73d5-465e-8b72-e8579bd419e1" }, "Poacher Set"),
        [ItemBaseID+10120] = new ItemEnum(new List<string> { "69abef79-395f-4380-bfe2-754de1bbbe7e", "1d338b39-a208-43a3-ad24-fbe6ad849043", "8dd903d8-950a-495a-9f79-b2a85ce5c008" }, "Reef Bloom Set"),
        [ItemBaseID+10121] = new ItemEnum(new List<string> { "f1814421-af59-42eb-bd5d-5d599e3d2582", "a563ad32-f5e8-4373-beb9-1ad030d1a59b", "71a819bb-83a5-4a13-a568-aa7a151b7b22" }, "Reef Diver Set"),
        [ItemBaseID+10122] = new ItemEnum(new List<string> { "e69903ec-cf9e-402e-9635-39e763ca5d1d", "c83c1834-1186-4f56-b5bc-172c66ecfb6a", "d456a83a-b3bf-4ccf-8ef0-cf2b1a10447c" }, "Tainted Heckles Set"),
        [ItemBaseID+10123] = new ItemEnum(new List<string> { "cda70208-7018-4c7d-bdba-7a1df6f27884", "f94ec9e5-a141-4079-a0d0-cf322c66066a", "a40e8c30-9319-4c37-88eb-91dee18af044" }, "Witchcap Set"),
        
        [ItemBaseID+10131] = new ItemEnum(new List<string> { "720a72fd-459d-487d-9591-9ececc1c587e" }, "Beastplate Chest"),
        [ItemBaseID+10132] = new ItemEnum(new List<string> { "5e5e4fbb-771b-400b-b1be-fb45e919201b" }, "Beastplate Hands"),
        [ItemBaseID+10133] = new ItemEnum(new List<string> { "f7943e1f-c043-4a4c-a17c-3df4d2a50aac" }, "Beastplate Legs"),
        [ItemBaseID+10134] = new ItemEnum(new List<string> { "b2ed4405-b468-49ac-8f22-22ba44f4267b" }, "Brute Garbs Chest"),
        [ItemBaseID+10135] = new ItemEnum(new List<string> { "8a2291e9-d7da-4f57-be68-37d9487a3733" }, "Brute Garbs Hands"),
        [ItemBaseID+10136] = new ItemEnum(new List<string> { "ad9ae90a-6c8f-42f9-9b4b-11ea4419172f" }, "Brute Garbs Legs"),
        [ItemBaseID+10137] = new ItemEnum(new List<string> { "05cfff68-4f4f-4776-a75f-8a3a4f99851e" }, "Fallen Greatblade Chest"),
        [ItemBaseID+10138] = new ItemEnum(new List<string> { "83af4229-22f1-4a51-b1e2-23cb9046266d" }, "Fallen Greatblade Hands"),
        [ItemBaseID+10139] = new ItemEnum(new List<string> { "00b3e702-894f-4206-bc04-367d3240c333" }, "Fallen Greatblade Legs"),
        [ItemBaseID+10140] = new ItemEnum(new List<string> { "f6212e1a-49c2-4199-a7e1-672cfed98399" }, "Forged Boulder Chest"),
        [ItemBaseID+10141] = new ItemEnum(new List<string> { "a00da0a7-d80b-4e4c-be9f-6626beca7ae3" }, "Forged Boulder Hands"),
        [ItemBaseID+10142] = new ItemEnum(new List<string> { "a8cdd79f-16e7-4e73-a6ef-3e77f080dd24" }, "Forged Boulder Legs"),
        [ItemBaseID+10143] = new ItemEnum(new List<string> { "5f83be6e-4837-4c7d-b460-8823f7fd74ff" }, "Forged Littles Chest"),
        [ItemBaseID+10144] = new ItemEnum(new List<string> { "465c9617-ca1e-4f39-8169-37ea3c51438b" }, "Forged Littles Hands"),
        [ItemBaseID+10145] = new ItemEnum(new List<string> { "cd612f69-1d94-4a2c-a979-6db03b7444b5" }, "Forged Littles Legs"),
        [ItemBaseID+10146] = new ItemEnum(new List<string> { "4d418789-6a50-4455-9a62-20b8621c4471" }, "Forged Pebble Chest"),
        [ItemBaseID+10147] = new ItemEnum(new List<string> { "e750627b-ac3e-4aaf-a896-2d1557d94aad" }, "Forged Pebble Hands"),
        [ItemBaseID+10148] = new ItemEnum(new List<string> { "d1192172-89f7-451c-88b8-3eaea318611a" }, "Forged Pebble Legs"),
        [ItemBaseID+10149] = new ItemEnum(new List<string> { "d386423d-c418-4a7a-be4b-5be8d0c931e6" }, "Formless Chest"),
        [ItemBaseID+10150] = new ItemEnum(new List<string> { "335cd052-0420-4c0c-8bfb-4d0bf05e65a5" }, "Formless Hands"),
        [ItemBaseID+10151] = new ItemEnum(new List<string> { "31fa0f10-ed33-43ec-8e53-ed743dfaf260" }, "Formless Legs"),
        [ItemBaseID+10152] = new ItemEnum(new List<string> { "73e50441-4f76-40bf-9b20-98eecbb8f1c5" }, "Grunt Garbs Chest"),
        [ItemBaseID+10153] = new ItemEnum(new List<string> { "98ff4506-15b9-4b7e-baee-7e5b6aa3e29b" }, "Grunt Garbs Hands"),
        [ItemBaseID+10154] = new ItemEnum(new List<string> { "099c73f1-92ad-4589-8e55-6426d8f99e51" }, "Grunt Garbs Legs"),
        [ItemBaseID+10155] = new ItemEnum(new List<string> { "041ff148-dfcd-4ed1-9641-80f7470c5588" }, "Handcloth Chest"),
        [ItemBaseID+10156] = new ItemEnum(new List<string> { "4b9d51c9-4491-468a-9ca7-22329c426d02" }, "Handcloth Hands"),
        [ItemBaseID+10157] = new ItemEnum(new List<string> { "9a72cf2d-8aea-436e-a1e0-99f31fe1414b" }, "Handcloth Legs"),
        [ItemBaseID+10158] = new ItemEnum(new List<string> { "eb160faa-79e3-408c-bae5-48941cd1d1ae" }, "Impaled Smithed Chest"),
        [ItemBaseID+10159] = new ItemEnum(new List<string> { "7d32a074-52e8-48b0-bc20-084c50be9a57" }, "Impaled Smithed Hands"),
        [ItemBaseID+10160] = new ItemEnum(new List<string> { "4ac3f38a-9a80-4483-8a9d-0d35ff5174c7" }, "Impaled Smithed Legs"),
        [ItemBaseID+10161] = new ItemEnum(new List<string> { "4054e484-c0dd-4eea-92ac-8f708b622b70" }, "Lahavist Nomad Chest"),
        [ItemBaseID+10162] = new ItemEnum(new List<string> { "2d18ef7d-2b40-46cf-b14a-05969a012ef0" }, "Lahavist Nomad Hands"),
        [ItemBaseID+10163] = new ItemEnum(new List<string> { "7b4b3b15-bec5-42d5-83d6-36bf22ab9986" }, "Lahavist Nomad Legs"),
        [ItemBaseID+10164] = new ItemEnum(new List<string> { "630cda1e-a048-489a-a724-cd38fb156513" }, "Lahavist Wanderer Chest"),
        [ItemBaseID+10165] = new ItemEnum(new List<string> { "2afe46d0-95eb-4582-a6ab-6b6dc616b42b" }, "Lahavist Wanderer Hands"),
        [ItemBaseID+10166] = new ItemEnum(new List<string> { "de0362aa-73aa-4965-9ead-164cca469832" }, "Lahavist Wanderer Legs"),
        [ItemBaseID+10167] = new ItemEnum(new List<string> { "4c5f1b84-350f-4b76-a01d-c953d5eac148" }, "Mask Collector Chest"),
        [ItemBaseID+10168] = new ItemEnum(new List<string> { "240e9e8a-33c2-47b8-a6ab-416db64bc4e0" }, "Mask Collector Hands"),
        [ItemBaseID+10169] = new ItemEnum(new List<string> { "5338de2b-0da9-46e9-ba94-7b0ca10aabd5" }, "Mask Collector Legs"),
        [ItemBaseID+10170] = new ItemEnum(new List<string> { "93ba5086-aac6-4fd5-90d9-f7525fb20adc" }, "Nailglade Fighter Chest"),
        [ItemBaseID+10171] = new ItemEnum(new List<string> { "ba241aba-b5c4-48e7-9310-a0e87ac731c6" }, "Nailglade Fighter Hands"),
        [ItemBaseID+10172] = new ItemEnum(new List<string> { "12b5172c-6c83-4751-b5bd-2328cb773cbf" }, "Nailglade Fighter Legs"),
        [ItemBaseID+10173] = new ItemEnum(new List<string> { "bb1c9823-4095-49ed-bb33-3ed4c85f1038" }, "Nailglade Scout Chest"),
        [ItemBaseID+10174] = new ItemEnum(new List<string> { "349deb58-4627-42d0-8034-4fd5df4390c3" }, "Nailglade Scout Hands"),
        [ItemBaseID+10175] = new ItemEnum(new List<string> { "3c5dbbbc-b470-4243-b444-830dd4c8c04a" }, "Nailglade Scout Legs"),
        [ItemBaseID+10176] = new ItemEnum(new List<string> { "f14540c8-a915-4feb-bc52-c86a16200b3f" }, "Orchard Homage Chest"),
        [ItemBaseID+10177] = new ItemEnum(new List<string> { "0ca4e3d0-4c24-41f9-af94-c523410f55d5" }, "Orchard Homage Hands"),
        [ItemBaseID+10178] = new ItemEnum(new List<string> { "956f3f3b-1b65-4cd5-a0fe-bd1a85f473a8" }, "Orchard Homage Legs"),
        [ItemBaseID+10179] = new ItemEnum(new List<string> { "dec2a8ef-be32-43cb-85ac-ddd75ab4074d" }, "Pen-pierced Chest"),
        [ItemBaseID+10180] = new ItemEnum(new List<string> { "8fcba95c-779f-4183-b9bb-57bb72921346" }, "Pen-pierced Hands"),
        [ItemBaseID+10181] = new ItemEnum(new List<string> { "ce26d157-f9c0-455e-89c1-9100106038b8" }, "Pen-pierced Legs"),
        [ItemBaseID+10182] = new ItemEnum(new List<string> { "6469ed00-2319-4823-b618-dc35efcecf2f" }, "Pitcher Gaurd Chest"),
        [ItemBaseID+10183] = new ItemEnum(new List<string> { "bb7f1ee6-ae63-4fbe-ba2e-6a612f2dd8ca" }, "Pitcher Gaurd Hands"),
        [ItemBaseID+10184] = new ItemEnum(new List<string> { "f2418b3d-0be0-4c6a-89c9-c23743964da9" }, "Pitcher Guard Legs"),
        [ItemBaseID+10185] = new ItemEnum(new List<string> { "f6cf7215-a4b0-449a-9c86-7e3bc3d72ffc" }, "Poacher Chest"),
        [ItemBaseID+10186] = new ItemEnum(new List<string> { "179f749b-24a7-4dbe-a82d-242eadf2e9fc" }, "Poacher Hands"),
        [ItemBaseID+10187] = new ItemEnum(new List<string> { "d51d9b19-73d5-465e-8b72-e8579bd419e1" }, "Poacher Legs"),
        [ItemBaseID+10188] = new ItemEnum(new List<string> { "69abef79-395f-4380-bfe2-754de1bbbe7e" }, "Reef Bloom Chest"),
        [ItemBaseID+10189] = new ItemEnum(new List<string> { "1d338b39-a208-43a3-ad24-fbe6ad849043" }, "Reef Bloom Hands"),
        [ItemBaseID+10190] = new ItemEnum(new List<string> { "8dd903d8-950a-495a-9f79-b2a85ce5c008" }, "Reef Bloom Legs"),
        [ItemBaseID+10191] = new ItemEnum(new List<string> { "f1814421-af59-42eb-bd5d-5d599e3d2582" }, "Reef Diver Chest"),
        [ItemBaseID+10192] = new ItemEnum(new List<string> { "a563ad32-f5e8-4373-beb9-1ad030d1a59b" }, "Reef Diver Hands"),
        [ItemBaseID+10193] = new ItemEnum(new List<string> { "71a819bb-83a5-4a13-a568-aa7a151b7b22" }, "Reef Diver Legs"),
        [ItemBaseID+10194] = new ItemEnum(new List<string> { "e69903ec-cf9e-402e-9635-39e763ca5d1d" }, "Tainted Heckles Chest"),
        [ItemBaseID+10195] = new ItemEnum(new List<string> { "c83c1834-1186-4f56-b5bc-172c66ecfb6a" }, "Tainted Heckles Hands"),
        [ItemBaseID+10196] = new ItemEnum(new List<string> { "d456a83a-b3bf-4ccf-8ef0-cf2b1a10447c" }, "Tainted Heckles Legs"),
        [ItemBaseID+10197] = new ItemEnum(new List<string> { "cda70208-7018-4c7d-bdba-7a1df6f27884" }, "Witchcap Chest"),
        [ItemBaseID+10198] = new ItemEnum(new List<string> { "f94ec9e5-a141-4079-a0d0-cf322c66066a" }, "Witchcap Hands"),
        [ItemBaseID+10199] = new ItemEnum(new List<string> { "a40e8c30-9319-4c37-88eb-91dee18af044" }, "Witchcap Legs"),
        
        [ItemBaseID+10280] = new ItemEnum(new List<string> { "96c994c4-5149-4095-9937-39d5bf460527" }, "Celebration Bell"),
        [ItemBaseID+10281] = new ItemEnum(new List<string> { "5e9a3dff-e1ef-4f4f-95ff-c306fd9fe07b" }, "Chain Javelin"),
        [ItemBaseID+10282] = new ItemEnum(new List<string> { "ab746d9a-2c57-41b9-bc44-627af2fc34e3" }, "Charging Javelin"),
        [ItemBaseID+10283] = new ItemEnum(new List<string> { "bd46fc9d-702a-4805-aa8f-cb9c627f62aa" }, "Defense Sigils"),
        [ItemBaseID+10284] = new ItemEnum(new List<string> { "bac92a2a-4828-450b-a856-b7203c20abc1" }, "Dried Alveoli"),
        [ItemBaseID+10285] = new ItemEnum(new List<string> { "4512852e-7ce3-4cea-a34e-7de8bde2fc2e" }, "Embedding Nail"),
        [ItemBaseID+10286] = new ItemEnum(new List<string> { "b8b1a4f3-4e6c-42f3-ba39-0d30eab64118" }, "Homing Droplet"),
        [ItemBaseID+10287] = new ItemEnum(new List<string> { "02ac0c07-6bf4-4e7a-840a-ecd78a91e0a8" }, "Knockback Weave"),
        [ItemBaseID+10288] = new ItemEnum(new List<string> { "d8417ab2-8216-41cb-a079-84c79818b98c" }, "Lump of Hands"),
        [ItemBaseID+10289] = new ItemEnum(new List<string> { "3e070d7f-fc00-4104-9f5e-4ce09d73393a" }, "Overgrown Blob"),
        [ItemBaseID+10290] = new ItemEnum(new List<string> { "68586cce-c519-4e5e-bd11-24fb8fa33b43" }, "Priming Spear"),
        [ItemBaseID+10291] = new ItemEnum(new List<string> { "35fc9135-744d-47dc-8bfa-905acf337fe1" }, "Reinforcing Weave"),
        [ItemBaseID+10292] = new ItemEnum(new List<string> { "74d0d746-708c-4ee0-a725-b1f91bf48012" }, "Scatter Stone"),
        [ItemBaseID+10293] = new ItemEnum(new List<string> { "c1fcb616-316c-44cf-b097-a92f58d0e5e7" }, "Sharpening Weave"),
        [ItemBaseID+10294] = new ItemEnum(new List<string> { "8524ed37-d4f0-4390-808c-9acd56208d25" }, "Sigil Barrier"),
        [ItemBaseID+10295] = new ItemEnum(new List<string> { "413d15d9-1cd9-4306-ba8d-b72876dc9dd8" }, "Smashing Block"),
        [ItemBaseID+10296] = new ItemEnum(new List<string> { "37d3e9c8-01ff-4ad2-a4af-772350f1a509" }, "Smidge of Paint"),
        [ItemBaseID+10297] = new ItemEnum(new List<string> { "6270d565-cad6-462a-b4d9-0ae9b6f9bd34" }, "Spike Ball"),
        [ItemBaseID+10298] = new ItemEnum(new List<string> { "d2627dd5-2f3b-451a-9e4a-921c367dd975" }, "Trigger Bomb"),
        [ItemBaseID+10299] = new ItemEnum(new List<string> { "639e0aed-b6f9-4200-b761-9303bea2c407" }, "Volatile Vase"),

        [ItemBaseID+10330] = new ItemEnum(new List<string> { "0713e805-d790-4c46-ad1f-fc85df881a3f" }, "Curled Finger"),
        [ItemBaseID+10331] = new ItemEnum(new List<string> { "0dd216ff-3aad-4837-aba2-224f2263f98d" }, "Broken Forged"),
        [ItemBaseID+10332] = new ItemEnum(new List<string> { "8d0f49e4-de5a-4b8d-b2b2-005eec40c163" }, "Faceless Charger"),
        [ItemBaseID+10333] = new ItemEnum(new List<string> { "aff170c6-f3e8-4eeb-94af-18415f386f21" }, "Faceless Clubber"),
        [ItemBaseID+10334] = new ItemEnum(new List<string> { "f6c4df9a-f3b6-4b5c-ab77-f5fc527b1d24" }, "Faceless Scrapper"),
        [ItemBaseID+10335] = new ItemEnum(new List<string> { "8fe036d7-d003-4b40-9183-9923cbb463bd" }, "Forged Little"),
        [ItemBaseID+10336] = new ItemEnum(new List<string> { "e9a88163-4a47-4f49-89e3-2610563f6029" }, "Forged Long"),
        [ItemBaseID+10337] = new ItemEnum(new List<string> { "edda6e94-19c6-4b7f-8117-bf054caa9e2d" }, "Forged Pebble"),
        [ItemBaseID+10338] = new ItemEnum(new List<string> { "69f0e9ad-ecf1-4c10-b30a-5f80d5b76428" }, "Forged Soldier"),
        [ItemBaseID+10339] = new ItemEnum(new List<string> { "f65a82bb-09df-40bd-96bc-d2815c64f9ca" }, "Hardened Halfmade"),
        [ItemBaseID+10340] = new ItemEnum(new List<string> { "888c17fb-d6e5-4f90-afa7-cf9ef5b8758c" }, "Heavy Rustedsmithed"),
        [ItemBaseID+10341] = new ItemEnum(new List<string> { "750685a8-76b0-4960-81ee-ad7968df4263" }, "Rusted Halfmade"),
        [ItemBaseID+10342] = new ItemEnum(new List<string> { "1db06bcf-0746-409b-b28d-c7b1417baa08" }, "LaUf Mold"),
        [ItemBaseID+10343] = new ItemEnum(new List<string> { "848758df-ab68-4320-9127-c37a9ae3ff92" }, "LaZev Sharp"),
        [ItemBaseID+10344] = new ItemEnum(new List<string> { "caa4d87d-1d39-46d1-865d-576e6021abb0" }, "Mauling Finger"),
        [ItemBaseID+10345] = new ItemEnum(new List<string> { "7f145633-737f-4645-b0ca-ca11da0c3a29" }, "Meekpalm"),
        [ItemBaseID+10346] = new ItemEnum(new List<string> { "5de3ba65-2415-44c6-9227-d4539ed00210" }, "Nailglade Fighter"),
        [ItemBaseID+10347] = new ItemEnum(new List<string> { "7265e749-c3a8-428b-8355-928d6ef05ef3" }, "Plunging Finger"),
        [ItemBaseID+10348] = new ItemEnum(new List<string> { "90d49432-c876-4c9a-b2e6-b71d4a5ce2b9" }, "Poaching Needler"),
        [ItemBaseID+10349] = new ItemEnum(new List<string> { "3b2db847-b2b4-41f0-b61d-915483b31ae0" }, "Shortblade Axe"),
        [ItemBaseID+10350] = new ItemEnum(new List<string> { "7102f8f2-cf60-4ee5-8e33-dafc3f7ac6e1" }, "Spiked Finger"),
        [ItemBaseID+10351] = new ItemEnum(new List<string> { "d2d4f85d-7fe7-4d79-bda6-5d1b3a7fe857" }, "Star Rustedsmithed"),
        [ItemBaseID+10352] = new ItemEnum(new List<string> { "d7e7ed6e-c8a0-4cf1-88a7-376718255f13" }, "Sword Lahavist"),
        [ItemBaseID+10353] = new ItemEnum(new List<string> { "c7162de0-d934-4eb2-85b3-54c45deb7bab" }, "Sword Scabbard"),
        
        [ItemBaseID+10380] = new ItemEnum(new List<string> { "924cc1b9-8b66-4302-9cf1-ae2b949a0ee6" }, "Bloodroot Chunk"),
        [ItemBaseID+10381] = new ItemEnum(new List<string> { "3317fe57-2dd2-4d46-a124-050ad9e2754a" }, "Bloodroot Shard"),
        [ItemBaseID+10382] = new ItemEnum(new List<string> { "cc3fc898-f110-418f-89be-72fa681469f9" }, "Bloodroot Splinter"),
        [ItemBaseID+10383] = new ItemEnum(new List<string> { "2bdaab02-ba9f-4455-a907-f091e93c493b" }, "Marah Strand - Thin"),
        [ItemBaseID+10384] = new ItemEnum(new List<string> { "1d18e1f8-1cae-4498-8465-fb4c7ae13817" }, "Marah Strand - Long"),
        [ItemBaseID+10385] = new ItemEnum(new List<string> { "dfcc44ec-44b9-4694-8f75-af64ec09fba5" }, "Marah Strand - Luscious"),
        [ItemBaseID+10386] = new ItemEnum(new List<string> { "98abc156-659f-40b2-8262-81cd4523fab8" }, "Breath Mark"),
        [ItemBaseID+10387] = new ItemEnum(new List<string> { "d0b6321e-28a6-4d96-96fa-2685a33fc52e" }, "Chisel Key"),
        [ItemBaseID+10388] = new ItemEnum(new List<string> { "a075f669-10df-4d57-b0bf-1c21acf299b7" }, "Chroma Blue"),
        [ItemBaseID+10389] = new ItemEnum(new List<string> { "33852837-a2d6-479b-b4b2-b3ae32b2a4e3" }, "Chroma Cyan"),
        [ItemBaseID+10390] = new ItemEnum(new List<string> { "ab4e9459-924d-48da-966a-1930c4f5da9a" }, "Chroma Green"),
        [ItemBaseID+10391] = new ItemEnum(new List<string> { "7e9d31b5-4d6e-4103-8f4e-031d7dcccc8e" }, "Chroma Orange"),
        [ItemBaseID+10392] = new ItemEnum(new List<string> { "110e23ec-61cd-43bb-b840-41638321c0dd" }, "Chroma Pink"),
        [ItemBaseID+10393] = new ItemEnum(new List<string> { "cc8a4211-f2cf-41bc-b3ee-5d15bb65d134" }, "Chroma Purple"),
        [ItemBaseID+10394] = new ItemEnum(new List<string> { "b4604d94-60b9-4fc7-9fd2-f18d9f0018d9" }, "Chroma Red"),
        [ItemBaseID+10395] = new ItemEnum(new List<string> { "a6ce8099-78d7-485b-9525-f8de45b06a52" }, "Chroma Yellow"),
        [ItemBaseID+10396] = new ItemEnum(new List<string> { "dcce0d34-c138-46a2-bbc0-06eb89251e84" }, "Dropot Runner Container"),
        [ItemBaseID+10397] = new ItemEnum(new List<string> { "5c16fc03-1e90-461a-8e99-cc50b4e526e9" }, "Galloping Dropot Container"),
        [ItemBaseID+10398] = new ItemEnum(new List<string> { "ffd77f0b-3a2a-4247-975e-80e265e77310" }, "Skittering Dropot Container"),
        [ItemBaseID+10399] = new ItemEnum(new List<string> { "5df3b8d9-a537-4ac4-a3b9-2e60f7073758" }, "Mudfalls Delivery"),
        [ItemBaseID+10400] = new ItemEnum(new List<string> { "6fa1abec-088b-4586-91d7-636b9bf2302d" }, "Firstsmith Delivery"),
        [ItemBaseID+10401] = new ItemEnum(new List<string> { "f2111e88-ffe7-4a1a-8966-ba427a8f6a1c" }, "Glair"),
        [ItemBaseID+10402] = new ItemEnum(new List<string> { "12fe1292-6114-4087-9efe-4bf3093abee4" }, "Heart of a Breathweaver"),
        [ItemBaseID+10403] = new ItemEnum(new List<string> { "2eedc140-6882-4719-b2bb-c661084115ad" }, "Heart of a Traveler"),
        [ItemBaseID+10404] = new ItemEnum(new List<string> { "6bfdf0ae-26e2-492e-a2da-e0d1b2a37b1b" }, "Heart of a Dancer"),
        [ItemBaseID+10405] = new ItemEnum(new List<string> { "9e763ee6-b328-4fb0-92cc-db8d80b4c4df" }, "Heart of a Warrior"),
        [ItemBaseID+10406] = new ItemEnum(new List<string> { "b5810949-ec57-41e8-a6e3-27634dcc11d4" }, "Third of Flesh"),
        
        [ItemBaseID+10250] = new ItemEnum(new List<string> { "96f4e840-0412-4231-824f-bba5ecbb0503" }, "Locked Sphere"),
        [ItemBaseID+10251] = new ItemEnum(new List<string> { "0d79ffea-0e59-4b7d-8b95-fa47bffb09d3" }, "Axe Greatblade Torso"),
        [ItemBaseID+10252] = new ItemEnum(new List<string> { "f41e1e54-f477-4946-b900-eaaba4b71455" }, "Breathsmith Location Info"),
        [ItemBaseID+10253] = new ItemEnum(new List<string> { "47f3f319-1c2e-48f2-bf7e-16ed824ce89a" }, "Holster's Remains"),
        [ItemBaseID+10254] = new ItemEnum(new List<string> { "4059dd7b-8058-4235-84ae-f57083e784e3" }, "Frail Horn"),
        [ItemBaseID+10255] = new ItemEnum(new List<string> { "31babc74-1943-484d-bf88-b779854bb56b" }, "Forged Anvil"),
        [ItemBaseID+10256] = new ItemEnum(new List<string> { "184b22ce-96ad-47c8-8247-7b61703670ce" }, "Penspear #1"),
        [ItemBaseID+10257] = new ItemEnum(new List<string> { "1dacf57d-11ef-43ab-b66a-bc6f0c3d4389" }, "Penspear #2"),
        [ItemBaseID+10258] = new ItemEnum(new List<string> { "795eb3dc-9831-4d85-bfdb-67cf70d62ade" }, "Pitcher Legs"),
        [ItemBaseID+10259] = new ItemEnum(new List<string> { "4f6504c6-f7ac-4a0b-b748-a72b1cd66514" }, "Quadrant Blade"),
        [ItemBaseID+10260] = new ItemEnum(new List<string> { "fc0df10e-a047-4320-8038-0cd1281fac21" }, "Sword Greatblade Torso"),
        [ItemBaseID+10261] = new ItemEnum(new List<string> { "34c87072-2c4e-4cb8-ae71-0ded388ed557" }, "Nailglade Workshop Key"),
        
        [ItemBaseID+10431] = new ItemEnum(new List<string> { "49a0ad8e-eb70-481c-9d6b-b3027ad27371" }, "Handpaint Breathcrown"),
        [ItemBaseID+10432] = new ItemEnum(new List<string> { "e1c01172-8008-459a-bbdc-5b7115dc66e5" }, "Kankan Breathcrown"),
        [ItemBaseID+10433] = new ItemEnum(new List<string> { "01cbb412-a3c3-4a3b-879e-a1cc00bc84ed" }, "Thirsting Breathcrown"),
        [ItemBaseID+10434] = new ItemEnum(new List<string> { "7e76b224-c2b5-4637-acef-52cb80d4aa56" }, "Knight Breathcrown"),
        [ItemBaseID+10435] = new ItemEnum(new List<string> { "2b2c1ccf-9119-45f9-85b5-106a6b3304d2" }, "Lahavist Breathcrown"),
        [ItemBaseID+10436] = new ItemEnum(new List<string> { "492737f1-ec66-47b2-9335-c4e20daabcb6" }, "Manzil's Breathcrown"),
        [ItemBaseID+10437] = new ItemEnum(new List<string> { "6eb4951e-1e2a-4016-8f83-740abc12be87" }, "Nailglader Breathcrown"),
        [ItemBaseID+10438] = new ItemEnum(new List<string> { "5dd3c283-0d1a-4e4a-b515-46609e397e7a" }, "Forged Breathcrown"),
        [ItemBaseID+10439] = new ItemEnum(new List<string> { "1f7cfa4a-0149-4ebc-a21d-080d3292a911" }, "Bladebeast Breathcrown"),
        
        [ItemBaseID+10480] = new ItemEnum(new List<string> { "03adc057-3523-4669-9160-adaa820350fa" }, "Trait_Special_Super Jump"),
        [ItemBaseID+10481] = new ItemEnum(new List<string> { "c39aad5e-eb3a-44ee-b321-692476f3b72e" }, "Trait_Special_Double Jump"),
        [ItemBaseID+10482] = new ItemEnum(new List<string> { "962b2b4a-7218-4fe4-86b6-2010d6438504" }, "Trait_Special_Grasphook"),
        [ItemBaseID+10483] = new ItemEnum(new List<string> { "c368eeca-1dc7-486b-95a8-0eb424f2daac" }, "Trait_Special_Grasphook Sliding"),
        [ItemBaseID+10484] = new ItemEnum(new List<string> { "03a9718e-658b-4f8d-afa9-07723e02ed48" }, "Trait_Special_Air Dash"),
        [ItemBaseID+10485] = new ItemEnum(new List<string> { "005752c6-961e-472c-aa47-8bb3f8641be3" }, "Trait_Special_Wall Snap"),
        [ItemBaseID+10486] = new ItemEnum(new List<string> { "1add4a3e-5964-433c-81f3-e75a0a940d56" }, "Trait_Special_Dash Plunge"),
        [ItemBaseID+10487] = new ItemEnum(new List<string> { "f181cd98-a286-4001-b630-9eec3ab6b52c" }, "Trait_Growth_Chain dash"),
        
        [ItemBaseID+10500] = new ItemEnum(new List<string> { "31a63cc0-ece0-4969-86cd-1b5a7182dba1" }, "Trait_Growth_Mold I Frame"),
        [ItemBaseID+10501] = new ItemEnum(new List<string> { "b66e12f9-68fc-483e-9a93-7a13a01ff4e6" }, "Trait_Special_Grasp"),
        [ItemBaseID+10502] = new ItemEnum(new List<string> { "5d38775c-eed3-4235-8953-f156917b4288" }, "Trait_Special_Force"),
        [ItemBaseID+10503] = new ItemEnum(new List<string> { "e648cf83-07db-4a3f-a275-2a629bb400e8" }, "Trait_Special_Grasp Counter"),
        [ItemBaseID+10504] = new ItemEnum(new List<string> { "1afa2176-8f79-469d-a1f7-41c70c62be53" }, "Trait_Special_Deathmark"),
        [ItemBaseID+10505] = new ItemEnum(new List<string> { "7b8ec722-79dd-415c-b459-178a60d7fb47" }, "Trait_Special_Dash Counter"),
        [ItemBaseID+10506] = new ItemEnum(new List<string> { "7ccb1751-1281-4295-bf59-3c2f8d933342" }, "Trait_Special_Bonus Damage On Red Attacks"),
        [ItemBaseID+10507] = new ItemEnum(new List<string> { "fc80b0b2-1179-477c-8a62-1db072807730" }, "Trait_Special_Additional Mold Set"),
        [ItemBaseID+10508] = new ItemEnum(new List<string> { "fc7a3681-70bc-474a-94f9-e84d0ae6a202" }, "Trait_Special_Item Grasp"),
        [ItemBaseID+10509] = new ItemEnum(new List<string> { "8f059497-fd1d-4134-9a70-6edd7460d005" }, "Trait_Special_Grasp Range"),
        [ItemBaseID+10510] = new ItemEnum(new List<string> { "461b8929-20b3-4af6-98f5-69f11f2e1b78" }, "Trait_Special_Crushing Damage Removal"),
        [ItemBaseID+10511] = new ItemEnum(new List<string> { "7adbfdf0-1924-4733-9212-549384c90289" }, "Trait_Special_Checkpoint Paint Restoration"),
        [ItemBaseID+10512] = new ItemEnum(new List<string> { "9f77800f-1881-441b-9a7a-4c396b46065c" }, "Trait_Special_Projectile Parry"),
        
        [ItemBaseID+10550] = new ItemEnum(new List<string> { "4c22e4a9-fc8b-432c-84c5-55dc21bee80d" }, "Trait_Growth_Force On Parry"),
        [ItemBaseID+10551] = new ItemEnum(new List<string> { "58134c82-8eca-4e5d-9283-cbc36cce0369" }, "Trait_Growth_Force On Mold"),
        [ItemBaseID+10552] = new ItemEnum(new List<string> { "9e03f162-17b3-49a5-8b84-60ca97651c47" }, "Trait_Growth_Dash Echo_Force"),
        [ItemBaseID+10553] = new ItemEnum(new List<string> { "47695e13-d578-45d4-907a-795f5ba46994" }, "Trait_Growth_Parry Fine Edged"),
        [ItemBaseID+10554] = new ItemEnum(new List<string> { "3bbacfae-9c8d-496b-8524-92c93e7934d0" }, "Trait_Growth_Parry Infusion"),
        [ItemBaseID+10555] = new ItemEnum(new List<string> { "0a822b09-8b34-438c-9990-0a6878ea5f74" }, "Trait_Growth_Mold Exhausted Boost"),
        [ItemBaseID+10556] = new ItemEnum(new List<string> { "2519084b-3482-4c5f-8770-6d54179c7898" }, "Trait_Growth_Dash Cooldown Reduction"),
        [ItemBaseID+10557] = new ItemEnum(new List<string> { "5bfb59ba-7e8c-47fc-ba49-e79d860d7a93" }, "Trait_Growth_Parry_First Hit Buff"),
        [ItemBaseID+10558] = new ItemEnum(new List<string> { "08634ccf-3fe3-4233-bc0d-0530ce3d8b07" }, "Trait_Growth_Mold Transformed Protection"),
        [ItemBaseID+10559] = new ItemEnum(new List<string> { "90235837-d9e8-462f-9dd5-589dc61534a0" }, "Trait_Growth_Dash Counter Force"),
        [ItemBaseID+10560] = new ItemEnum(new List<string> { "242db0b4-ff27-4cf9-b240-9f9901a40e77" }, "Trait_Growth_Dash Echo_Damage"),
        [ItemBaseID+10561] = new ItemEnum(new List<string> { "a9e87028-6357-410c-a48b-d412f165dfcc" }, "Trait_Growth_Parry Super"),
        [ItemBaseID+10562] = new ItemEnum(new List<string> { "51f81d29-2ef5-4750-bfec-684c4d8c17c1" }, "Trait_Growth_Parry Stacking Damage Buff"),
        [ItemBaseID+10563] = new ItemEnum(new List<string> { "df76f98c-e54a-4b7a-92cc-c82aa0a5e48a" }, "Trait_Growth_Mold Bonus Damage On Super Attacks"),
        [ItemBaseID+10564] = new ItemEnum(new List<string> { "ea91c60c-a0f3-4fd1-880f-06d40fc8cfe5" }, "Trait_Growth_Force Regen"),
        [ItemBaseID+10565] = new ItemEnum(new List<string> { "4c5bf754-4275-40a0-a2a7-31448d310d48" }, "Trait_Growth_Dash Echo_Damage Super"),
        [ItemBaseID+10566] = new ItemEnum(new List<string> { "b5968a3f-49ec-4243-9771-c4c584c6fb0f" }, "Trait_Growth_Parry Death Mark"),
        [ItemBaseID+10567] = new ItemEnum(new List<string> { "53c31da4-8e23-4881-8c80-eef18270c168" }, "Trait_Growth_Parry Paint"),
        [ItemBaseID+10568] = new ItemEnum(new List<string> { "383da957-e418-4b75-8889-d04793784dac" }, "Trait_Growth_Projectile Reflect Damage Increase"),
        [ItemBaseID+10569] = new ItemEnum(new List<string> { "e74d43cf-f1de-41f2-83c3-c89318a238cb" }, "Trait_Growth_Dash Echo_Paint"),
        [ItemBaseID+10570] = new ItemEnum(new List<string> { "b4e11b6b-1255-4d67-8a9a-547764a7b51f" }, "Trait_Growth_Dash Echo_Buff"),
        [ItemBaseID+10571] = new ItemEnum(new List<string> { "22e2be5e-25c1-42aa-b08a-de3c4ac61567" }, "Trait_Growth_AoE Parry"),
        [ItemBaseID+10572] = new ItemEnum(new List<string> { "8100febc-effa-49e6-8f21-97931ee2723e" }, "Trait_Growth_Projectile Grasp"),
        [ItemBaseID+10573] = new ItemEnum(new List<string> { "7877c149-5ed0-4619-82dc-aa7f25aa3460" }, "Trait_Growth_Grasp Counter Wisps"),
        
    };
}