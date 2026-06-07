using HarmonyLib;
using MelonLoader;
using Il2Cpp;
using Il2CppInterop.Runtime;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.UI;
using Archipelago.MultiClient.Net;
using Archipelago.MultiClient.Net.Enums;
using Archipelago.MultiClient.Net.Helpers;
using Archipelago.MultiClient.Net.MessageLog.Messages;
using Grime2APClient.Archipelago;
using Il2CppSirenix.Serialization;
using Il2CppSystem.Collections;

[assembly: MelonInfo(typeof(Grime2APClient.Grime2ApClientClass), "Grime2 AP Client", "0.0.1", "Lexipherous")]

namespace Grime2APClient;


public class Grime2ApClientClass : MelonMod
{
    private bool _showMenu = false;
    //public static Rect _itemWindowRect = new Rect(50, 50, 300, 145);
    public static Rect _itemWindowRect = new Rect(50, 50, 300, 190);
    public static string _modNameText = "Grime2 AP Client";
    public static bool isConnected = false;

    public static ArchipelagoSession session;
    
    private string _inputHost = "localhost";
    private string _inputPort = "5000";
    private string _inputName = "egg";
    private string _inputPassword = "";
    
    public override void OnInitializeMelon() {
        MelonEvents.OnGUI.Subscribe(DrawMenu, 100); // The higher the value, the lower the priority.
            
        MethodInfo originalPickableItem = AccessTools.Method(typeof(Gameplay_PickableItem), "Pickup");
        MethodInfo patchPickableItem = AccessTools.Method(typeof(LocationSend), "APItemPickup");
        HarmonyInstance.Patch(originalPickableItem, new HarmonyMethod(patchPickableItem));
            
        MethodInfo originalInteractableAbsorbable = AccessTools.Method(typeof(Gameplay_InteractableAbsorbable), "OnInteract");
        MethodInfo patchInteractableAbsorbable = AccessTools.Method(typeof(LocationSend), "APInteractAbsorb");
        HarmonyInstance.Patch(originalInteractableAbsorbable, new HarmonyMethod(patchInteractableAbsorbable));
        
        MethodInfo originalObjectAbsorbHandler = AccessTools.Method(typeof(Gameplay_ObjectAbsorbHandler), "OnSelfPullStart");
        MethodInfo patchObjectAbsorbHandler = AccessTools.Method(typeof(LocationSend), "APObjectAbsorb");
        HarmonyInstance.Patch(originalObjectAbsorbHandler, new HarmonyMethod(patchObjectAbsorbHandler));
        
        Melon<Grime2ApClientClass>.Logger.Msg($"[{_modNameText}] Initialized! :D");
    }
    
    public override void OnUpdate() {
        if (Input.GetKeyDown(KeyCode.F3)) {
            _showMenu = !_showMenu;
        }
        ItemReceive.Update();
    }
    
    private void DrawMenu()
    {
        Toasts.Render();
        if (!_showMenu) {
            return;
        }
        _itemWindowRect = GUI.Window(1001, _itemWindowRect, (GUI.WindowFunction)DrawItemWindow, _modNameText);
    }

    private void DrawItemWindow(int windowId)
    {
        GUILayout.BeginHorizontal();
        GUILayout.Label("Host: ");
        _inputHost =  GUILayout.TextField(_inputHost);
        GUILayout.EndHorizontal();
        
        GUILayout.BeginHorizontal();
        GUILayout.Label("Port: ");
        _inputPort = GUILayout.TextField(_inputPort, GUILayout.Width(200), GUILayout.Height(20));
        GUILayout.EndHorizontal();
        
        GUILayout.BeginHorizontal();
        GUILayout.Label("Name: ");
        _inputName = GUILayout.TextField(_inputName, GUILayout.Width(200), GUILayout.Height(20));
        GUILayout.EndHorizontal();
        
        GUILayout.BeginHorizontal();
        GUILayout.Label("Password: ");
        _inputPassword = GUILayout.TextField(_inputPassword, GUILayout.Width(200), GUILayout.Height(20));
        GUILayout.EndHorizontal();
        
        GUILayout.BeginHorizontal();
        if (!isConnected) {
            if (GUILayout.Button("Connect"))  { Session.TryConnect(_inputHost, _inputPort, _inputName, _inputPassword); }
        } else {
            if (GUILayout.Button("Disconnect"))  { Session.TryConnect(_inputHost, _inputPort, _inputName, _inputPassword); }
        }
        GUILayout.EndHorizontal();
        
        GUILayout.BeginHorizontal();
        if (GUILayout.Button("TestSend")) {
            session.Locations.CompleteLocationChecks(1);
        }
        if (GUILayout.Button("TestLocs")) {
            Melon<Grime2ApClientClass>.Logger.Msg("TestLocs");
            var locations = session.Locations.AllLocations;
            Melon<Grime2ApClientClass>.Logger.Msg($"TestLoc Count: {locations.Count}");
            foreach (var loc in locations) {
                Melon<Grime2ApClientClass>.Logger.Msg($"Location ID: {loc}");
            }
        }
        if (GUILayout.Button("Flags&Skip")) {
            SyncHandler.SetGlobalFlagValue("Intro Finished", 1);
            SyncHandler.SetGlobalFlagValue("GSF_Cinematic_Intro", 1);
            LevelStreaming_Handler._instance.TeleportPlayerToPosition(new Vector3(1798.55f, 1602.17f, 0.00f));
        }
        if (GUILayout.Button("Goal")) {
            LocationSend.VictoryCon();
        }
        GUILayout.EndHorizontal();
    }
}