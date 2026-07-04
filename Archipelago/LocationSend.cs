using Archipelago.MultiClient.Net.Enums;
using Archipelago.MultiClient.Net.Exceptions;
using Archipelago.MultiClient.Net.Packets;
using Il2Cpp;
using MelonLoader;
using Grime2APClient.Enums;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Grime2APClient.Archipelago;

public class LocationSend
{
    public static Queue<string> FleshQueue = new();
    
    
    /// <summary>
    /// Hook for items.
    /// This seems to include: white items, purple items, atrium, fragments. Force Cap items untested.
    /// </summary>
    public static bool APItemPickup(Gameplay_PickableItem __instance, bool instant) {
        // Replace current item with obsolete hidden item
        var newItem = ItemReceive.GetItemById("6c96f712-0211-4c1f-a794-cdb781a574dc");
        if (__instance.pickupType == Gameplay_PickableItem.PickupType.Exp)
        {
            __instance.pickupType = Gameplay_PickableItem.PickupType.Item;
        }
        __instance.targetItem = newItem;

        SendHandler("ItemPickup", __instance.gameObject.GetComponent<Syncer>().syncerID, __instance.gameObject.scene.name, __instance.gameObject.transform.position);
        return true;
    }

    /// <summary>
    /// Hook for interactibles.
    /// This seems to include: Overgrown Barrier.
    /// </summary>
    public static bool APInteractAbsorb(Gameplay_InteractableAbsorbable __instance) {
        __instance.rewardType = (Gameplay_InteractableAbsorbable.RewardType)3;
        SendHandler("InteractAbsorb", __instance.gameObject.GetComponent<Syncer>().syncerID, __instance.gameObject.scene.name, __instance.gameObject.transform.position);
        return true;
    }

    /// <summary>
    /// Hook for interactibles.
    /// This seems to include: Lahav Knight force drops
    /// </summary>
    public static bool APObjectAbsorb(Gameplay_ObjectAbsorbHandler __instance) {
        SendHandler("ObjectAbsorb", __instance.gameObject.GetComponent<Syncer>().syncerID, __instance.gameObject.scene.name, __instance.gameObject.transform.position);
        if (__instance.absorbFlesh)
        {
            string currentScenea = LevelStreaming_Handler._instance.name;
            Melon<Grime2ApClientClass>.Logger.Msg($"Unknown scene: {currentScenea}");
            string currentScene = LevelStreaming_Handler._instance.tempSceneName;

            switch (currentScene)
            {
                case "05_Underheads_Background_Far_Right_BAKED_BASE_HARD_HIGH_LAYER 1": // Marah's Orchard / Grasphook
                    FleshQueue.Enqueue("05_Underheads_13:-5180110");//Trait_Special_Super Jump
                    return false;
                case "10_Kankan_Lower_06_BAKED_BASE_SOFT_HIGH_LAYER 1": // Kankan / Wall Jump
                    FleshQueue.Enqueue("10_Kankan_Lower_07:-1941005");//Trait_Special_Double Jump
                    return false;
                //case "09_DregBourg_Background_BAKED_BASE_HARD_HIGH_LAYER 1": // Nailglade / Air Dash
                //    FleshQueue.Enqueue(Grime2Dicts.ItemBaseID + 10482);//Trait_Special_Grasphook
                //    return false;
                //case "12_PaintReef_Background_Purple_BAKED_BASE_HARD_HIGH_LAYER 1": // Dregbourg / Burst Jump
                //    FleshQueue.Enqueue(Grime2Dicts.ItemBaseID + 10483);//Trait_Special_Grasphook Sliding
                //    return false;
                //case "12_PaintReef_05_BAKED_BASE_SOFT_HIGH_LAYER 0": // Paint Reef / Grasp Slide
                //    FleshQueue.Enqueue(Grime2Dicts.ItemBaseID + 10484);//Trait_Special_Air Dash
                //    return false;
                //case "15_Mudpits_03_BAKED_BASE_SOFT_HIGH_LAYER 0": // Mudpits / Dash Slide
                //    FleshQueue.Enqueue(Grime2Dicts.ItemBaseID + 10485);//Trait_Special_Wall Snap
                //    return false;
                //case "17_Starmire_Background_BAKED_BASE_HARD_HIGH_LAYER 1": // Starmire / Hand Jump
                //    FleshQueue.Enqueue(Grime2Dicts.ItemBaseID + 10486);//Trait_Special_Dash Plunge
                //    return false;
                default:
                    Melon<Grime2ApClientClass>.Logger.Msg($"Unknown scene: {currentScene}");
                    return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Hook for Bloodroot and Marah Strand.
    /// This seems to include: Lahav Knight force drops
    /// </summary>
    public static bool APMarahBloodroot(AbsorbableCluster_Event __instance) {
        SendHandler("MarahBloodroot", __instance.gameObject.GetComponent<Syncer>().syncerID, __instance.gameObject.scene.name, __instance.gameObject.transform.position);
        return true;
    }

    /// <summary>
    /// </summary>
    public static bool AP_NPC(Profile_NPC __instance) {
        Melon<Grime2ApClientClass>.Logger.Msg($"NPC: syncerID: {__instance.getGlobalSyncerFlag}");
        return true;
    }

    /// <summary>
    /// Hook for Surrogates.
    /// </summary>
    public static bool APCheckpoint(Gameplay_CheckpointHandler __instance) {
        SendHandler("Checkpoint", __instance.gameObject.GetComponent<Syncer>().syncerID, __instance.gameObject.scene.name, __instance.gameObject.transform.position);
        return true;
    }

    /// <summary>
    /// Hook for Seals.
    /// </summary>
    public static bool APBeacon(BeaconHandler __instance) {
        SendHandler("Beacon", __instance.gameObject.GetComponent<Syncer>().syncerID, __instance.gameObject.scene.name, __instance.gameObject.transform.position);
        return true;
    }

    /// <summary>
    /// Hook that's called at the end of an object absorption.
    /// Used for processing Discarded Flesh.
    /// </summary>
    public static bool APTraitUnlock(Data_Trait __instance)
    {
        //__instance.traitID
        //Melon<Grime2ApClientClass>.Logger.Msg("APTraitUnlock detected ");
        //SendHandler("Beacon", __instance.gameObject.GetComponent<Syncer>().syncerID, __instance.gameObject.scene.name, __instance.gameObject.transform.position);

        
        if (FleshQueue.Count != 0)
        {
            while (FleshQueue.Count != 0)
            {
                var fleshId = FleshQueue.Dequeue();
                SendLocation(fleshId);
            }
        }
        
        return false;
    }

    /// <summary>
    /// </summary>
    public static bool CutsceneGiveItem(PlayerData_Inventory __instance, ref Data_Item item) {
        Data_Item proxyItem = ItemReceive.GetItemById("6c96f712-0211-4c1f-a794-cdb781a574dc");
        string currentScene = LevelStreaming_Handler._instance.tempSceneName;

        // Identify current scene
        Melon<Grime2ApClientClass>.Logger.Msg(currentScene);
        
        // Handle items being given
        if (item.itemID == "96f4e840-0412-4231-824f-bba5ecbb0503") // Locked Sphere - Manzil - Mudfalls
        {//02_Mudfalls_06_BAKED_BASE_SOFT_HIGH_LAYER 0
            SendHandler("NPC_Give", 1000000, "02_Mudfalls_04", new Vector3(0,0,0)); //"Manzil: Locked Sphere"
            //Melon<Grime2ApClientClass>.Logger.Msg($"Locked Sphere received.");
            item = proxyItem;
        }
        else if (item.itemID == "492737f1-ec66-47b2-9335-c4e20daabcb6") // Manzil's Breathcrown - Manzil - Mudfalls
        {
            SendHandler("NPC_Give", 1000002, "02_Mudfalls_04", new Vector3(0,0,0)); //"Manzil: Manzil's Breathcrown"
            //Melon<Grime2ApClientClass>.Logger.Msg($"Manzil's Breathcrown received.");
            item = proxyItem;
        }
        else if (item.itemID == "c1fcb616-316c-44cf-b097-a92f58d0e5e7") // Sharpening Weave - Sibs - Mudfalls
        {
            SendHandler("NPC_Give", 1000001, "02_Mudfalls_04", new Vector3(0,0,0)); //"Inked Siblings: Sharpening Weave"
            //Melon<Grime2ApClientClass>.Logger.Msg($"Sharpening Weave received.");
            item = proxyItem;
        }
        else if (item.itemID == "f92e6e09-c70c-4e15-b26d-e3c4106be29b") // Pitcher Spear - Pitcher Vanguard - Jagged Forest
        {
            Melon<Grime2ApClientClass>.Logger.Msg($"Pitcher Spear received.");
            item = proxyItem;
        }
        else if (item.itemID == "cc3fc898-f110-418f-89be-72fa681469f9") // Bloodroot Splinter - Rakik - Kankan
        {
            Melon<Grime2ApClientClass>.Logger.Msg($"Bloodroot Splinter received.");
            item = proxyItem;
        }
        else if (item.itemID == "34c87072-2c4e-4cb8-ae71-0ded388ed557") // Nailglade Workshop Key - Rakik - Nailglade
        {
            Melon<Grime2ApClientClass>.Logger.Msg($"Nailglade Workshop Key received.");
            item = proxyItem;
        }
        else if (item.itemID == "cc3fc898-f110-418f-89be-72fa681469f9") // Bloodroot Splinter - Rakik - Nailglade
        {
            Melon<Grime2ApClientClass>.Logger.Msg($"Nailglade Workshop Key received.");
            item = proxyItem;
        }
        else
        {
            Melon<Grime2ApClientClass>.Logger.Msg($"item:{item.name} - id:{item.itemID}");
        }
        //SendHandler("Checkpoint", item);
        // Goldhead - Head
        // Rakik - Kankan
        // Rakik - Nailglade
        // Penspears
        // Forged Little - Not Handleron
        // Holsters Remains - Not Handleron
        // Returning to Masay - Not Handleron
        // Mudfalls delivery? Is there a reward that isnt more shop items?
        // Firstsmith Delivery - Not Handleron
        return true;
    }

    /// <summary>
    /// Hook that's called at the end of an object absorption.
    /// Used for processing Discarded Flesh.
    /// </summary>
    public static bool APObjectives(Misc_ObjectiveActions __instance)
    {
        Melon<Grime2ApClientClass>.Logger.Msg($"OBJECTIVE | Name:{__instance.name} Value:{__instance.value}");
        return false;
    }
    
    public static bool DataGiveItem(Data_Item __instance)
    {
	    if (Grime2ApClientClass.isConnected)
	    {
	        string locationNameID = $"{__instance.name}";
	        Melon<Grime2ApClientClass>.Logger.Msg($"DataGiveItem | {locationNameID}");
	        SendLocation(locationNameID);
	        return false;
	    }
	    Melon<Grime2ApClientClass>.Logger.Msg($"DataGiveItem | Vanilla");
		return true;
    }
    
    // CriticalFailsafeOverride to avoid the game trying to insist we take quest items.
    /// <summary>
    /// Hook that's called to make sure the player gets quest items.
    /// Override ir
    /// </summary>
    public static bool OverrideCriticalQuestItemsFailsafe()
    {
	    if (Grime2ApClientClass.isConnected)
	    {
	        Melon<Grime2ApClientClass>.Logger.Msg("Failsafe has screamed, but it has no mouth and cannot be heard.");
	        return false;
	    }
		return true;
    }

    public static void SendHandler(string source, long syncerID, string areaName, Vector3 pos)
    {
        string sendString = $"{source}|[\"{NameToIDName(areaName)}:{syncerID}\"] = new LocationEnum(0, \"{GetAreaFromSceneName(areaName)}\"), // {pos}";
        Melon<Grime2ApClientClass>.Logger.Msg(sendString);
        SendLocation($"{NameToIDName(areaName)}:{syncerID}");
    }
    
    private static string NameToIDName(string fullSceneName) {
        // Input: "00_Tutorial_01_BAKED_BASE_HARD_HIGH_LAYER 0"
        // Output: "00_Tutorial_01"
        
        if (fullSceneName.Contains("_BAKED"))
        {
            fullSceneName = fullSceneName.Substring(0, fullSceneName.IndexOf("_BAKED"));
        }
    
        return fullSceneName;
    }
    
    private static string GetAreaFromSceneName(string cleanSceneName) {
        var parts = cleanSceneName.Split('_');
        return parts[1];
    }

    private static void SendLocation(string syncerID)
    {
        // Submit location as checked
        long apId;
        try
        {
	        apId = Grime2Dicts.LocationIds[syncerID].apId;
        }
        catch
        {
	        UI_NotificationHandler.instance.WriteSimpleNotification($"Missing ID. Please report this to the dev.");
	        Melon<Grime2ApClientClass>.Logger.Msg($"---Missing ID---");
	        Melon<Grime2ApClientClass>.Logger.Msg($"Failed with ID: {syncerID}");
	        Melon<Grime2ApClientClass>.Logger.Msg($"Player location: {LevelStreaming_Handler._instance.tempSceneName}");
	        Melon<Grime2ApClientClass>.Logger.Msg($"----------------");
	        return;
        }
        
        
        Melon<Grime2ApClientClass>.Logger.Msg($"Sending AP ID: '{apId}' ({apId-Grime2Dicts.LocationBaseID}).");
        Grime2ApClientClass.session.Locations.CompleteLocationChecks(apId);
        Melon<Grime2ApClientClass>.Logger.Msg($"APItemPickup done.");

        /*if (syncerID == "498091")
        {
            VictoryCon();
        }*/
    }

    public static void VictoryCon()
    {
        Grime2ApClientClass.session.Socket.SendPacketAsync(new StatusUpdatePacket() { Status = ArchipelagoClientState.ClientGoal });
    }
}