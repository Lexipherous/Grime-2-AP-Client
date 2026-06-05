using Il2Cpp;
using MelonLoader;
using Grime2APClient.Enums;

namespace Grime2APClient.Archipelago;

public class LocationSend
{
    public static bool APItemPickup(Gameplay_PickableItem __instance, bool instant)
    {
        // Replace current item with obsolete hidden item
        var newItem = ItemReceive.GetItemById("6c96f712-0211-4c1f-a794-cdb781a574dc");
        __instance.targetItem = newItem;
        Melon<Grime2ApClientClass>.Logger.Msg($"newItem '{newItem.itemID}'.");
        
        // Submit location as checked
        int apId = GetAP_ID(__instance.syncer.getSyncerID);
        Melon<Grime2ApClientClass>.Logger.Msg($"apId '{apId}'.");
        Grime2ApClientClass.session.Locations.CompleteLocationChecks(apId);
        Melon<Grime2ApClientClass>.Logger.Msg($"APItemPickup done.");
        return true;
    }

    private static int GetAP_ID(int syncerID)
    {
        return Grime2Dicts.TempleIds[syncerID].apId;
    }
}