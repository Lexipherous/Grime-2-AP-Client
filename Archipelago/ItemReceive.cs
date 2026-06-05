using UnityEngine;
using Il2Cpp;
using MelonLoader;
using Archipelago.MultiClient.Net.Helpers;
using Archipelago.MultiClient.Net.MessageLog.Messages;
using Grime2APClient.Enums;
using Il2CppSystem.Collections;

namespace Grime2APClient.Archipelago;

public class ItemReceive
{
    public static Queue<long> InboundQueue = new();
    
    public static void OnItemReceived(ReceivedItemsHelper helper)
    {
        var item = helper.DequeueItem();
        InboundQueue.Enqueue(item.ItemId);
        Grime2ApClientClass.session.Locations.CompleteLocationChecks(1);
    }

    public static void Update()
    {
        if (InboundQueue.Count != 0)
        {
            while (InboundQueue.Count != 0)
            {
                var itemId = InboundQueue.Dequeue();
                APGiveItemToPlayer(itemId);
            }
        }
    }
    
    public static void APGiveItemToPlayer(long apItemID){
        // Get Item from Enums
        Grime2Dicts.ItemEnum gameItemEnum = Grime2Dicts.ItemTranslation[apItemID];
        //Melon<Grime2ApClientClass>.Logger.Msg($"gameItemEnum.gameId '{gameItemEnum.gameId}'.");
        
        // Get item data from hashtable
        Data_Item gameItem = GetItemById(gameItemEnum.gameId);
        //Melon<Grime2ApClientClass>.Logger.Msg($"gameItem '{gameItem.name} - {gameItem.itemID}'.");
        
        //Send Item to player
        GiveItemById(gameItem, gameItemEnum.quantity);
    }
    
    public static Data_Item GetItemById(string itemId)
    {
        Hashtable_Items hashtable = Hashtable_Items.getHashtable;
        if (hashtable == null) {
            Melon<Grime2ApClientClass>.Logger.Msg("Hashtable_Items.getHashtable is null.");
        }
        Data_Item item = hashtable.GetItemByID(itemId);
        if (item == null) {
            Melon<Grime2ApClientClass>.Logger.Msg($"Could not find item with id '{itemId}'.");
        }
        return item;
    }
    
    public static void GiveItemById(Data_Item item, int quantity = 1){
        PlayerData_Inventory.instance.GiveItem(item, quantity);
        Melon<Grime2ApClientClass>.Logger.Msg($"Gave {quantity}x {item.name} with id {item.itemID}.");
    }
}