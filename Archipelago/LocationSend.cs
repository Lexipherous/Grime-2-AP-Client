using Archipelago.MultiClient.Net.Enums;
using Archipelago.MultiClient.Net.Exceptions;
using Archipelago.MultiClient.Net.Packets;
using Il2Cpp;
using MelonLoader;
using Grime2APClient.Enums;

namespace Grime2APClient.Archipelago;

public class LocationSend
{
    /// <summary>
    /// Hook for items.
    /// This seems to include: white items, purple items, atrium, fragments. Force Cap items untested.
    /// </summary>
    public static bool APItemPickup(Gameplay_PickableItem __instance, bool instant)
    {
        // Replace current item with obsolete hidden item
        var newItem = ItemReceive.GetItemById("6c96f712-0211-4c1f-a794-cdb781a574dc");
        __instance.targetItem = newItem;
        Melon<Grime2ApClientClass>.Logger.Msg($"newItem '{newItem.itemID}'.");

        SendLocation(__instance.syncer.syncerID);
        return true;
    }

    /// <summary>
    /// Hook for interactibles.
    /// This seems to include: Overgrown Barrier.
    /// </summary>
    public static bool APInteractAbsorb(Gameplay_InteractableAbsorbable __instance)
    {
        Melon<Grime2ApClientClass>.Logger.Msg($"IA: syncerID: {__instance.syncer.syncerID} - {__instance.name}");
        SendLocation(__instance.syncer.syncerID);
        return true;
    }

    /// <summary>
    /// Hook for interactibles.
    /// This seems to include: Lahav Knight force drops
    /// </summary>
    public static bool APObjectAbsorb(Gameplay_ObjectAbsorbHandler __instance)
    {
        Melon<Grime2ApClientClass>.Logger.Msg($"OAH: syncerID: {__instance.syncer.syncerID} - Name: {__instance.name} - isFlesh: {__instance.absorbFlesh} - graspText: {__instance.graspText}");
        SendLocation(__instance.syncer.syncerID);
        return true;
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