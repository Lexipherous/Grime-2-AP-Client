using Archipelago.MultiClient.Net.Enums;
using Archipelago.MultiClient.Net.Exceptions;
using Archipelago.MultiClient.Net.Packets;
using Il2Cpp;
using MelonLoader;
using Grime2APClient.Enums;
using UnityEngine;

namespace Grime2APClient.Archipelago;

public class LocationSend
{
    /// <summary>
    /// Hook for items.
    /// This seems to include: white items, purple items, atrium, fragments. Force Cap items untested.
    /// </summary>
    public static bool APItemPickup(Gameplay_PickableItem __instance, bool instant) {
        // Replace current item with obsolete hidden item
        var newItem = ItemReceive.GetItemById("6c96f712-0211-4c1f-a794-cdb781a574dc");
        __instance.targetItem = newItem;

        SendHandler("ItemPickup", __instance.gameObject.GetComponent<Syncer>().syncerID, __instance.gameObject.scene.name, __instance.gameObject.transform.position);
        return true;
    }

    /// <summary>
    /// Hook for interactibles.
    /// This seems to include: Overgrown Barrier.
    /// </summary>
    public static bool APInteractAbsorb(Gameplay_InteractableAbsorbable __instance) {
        SendHandler("InteractAbsorb", __instance.gameObject.GetComponent<Syncer>().syncerID, __instance.gameObject.scene.name, __instance.gameObject.transform.position);
        return true;
    }

    /// <summary>
    /// Hook for interactibles.
    /// This seems to include: Lahav Knight force drops
    /// </summary>
    public static bool APObjectAbsorb(Gameplay_ObjectAbsorbHandler __instance) {
        SendHandler("ObjectAbsorb", __instance.gameObject.GetComponent<Syncer>().syncerID, __instance.gameObject.scene.name, __instance.gameObject.transform.position);
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
    /// </summary>
    public static bool APCheckpoint(Gameplay_CheckpointHandler __instance) {
        SendHandler("Checkpoint", __instance.gameObject.GetComponent<Syncer>().syncerID, __instance.gameObject.scene.name, __instance.gameObject.transform.position);
        return true;
    }

    /// <summary>
    /// </summary>
    public static bool APBeacon(BeaconHandler __instance) {
        SendHandler("Beacon", __instance.gameObject.GetComponent<Syncer>().syncerID, __instance.gameObject.scene.name, __instance.gameObject.transform.position);
        return true;
    }

    public static void SendHandler(string source, long syncerID, string areaName, Vector3 pos)
    {
        string sendString = $"{source}|[\"{areaName}:{syncerID}\"] = new LocationEnum(0, \"{areaName}\"), // {pos}";
        Melon<Grime2ApClientClass>.Logger.Msg(sendString);
        //SendLocation(syncerID);
    }

    private static void SendLocation(int syncerID)
    {
        // Submit location as checked
        int apId = Grime2Dicts.TempleIds[syncerID].apId;
        Melon<Grime2ApClientClass>.Logger.Msg($"apId '{apId}'.");
        Grime2ApClientClass.session.Locations.CompleteLocationChecks(apId);
        Melon<Grime2ApClientClass>.Logger.Msg($"APItemPickup done.");

        if (syncerID == 498091)
        {
            VictoryCon();
        }
    }

    public static void VictoryCon()
    {
        Grime2ApClientClass.session.Socket.SendPacketAsync(new StatusUpdatePacket() { Status = ArchipelagoClientState.ClientGoal });
    }
}