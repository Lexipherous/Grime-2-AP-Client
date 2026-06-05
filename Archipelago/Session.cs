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
using Il2CppSirenix.Serialization;

namespace Grime2APClient.Archipelago;

public class Session
{
    public static void TryConnect(string host, string port, string name, string password)
    {
        LoginResult result;

        try
        {
            Grime2ApClientClass.session = ArchipelagoSessionFactory.CreateSession(host, int.Parse(port));
            Grime2ApClientClass.session.MessageLog.OnMessageReceived += OnMessageReceived;
            Grime2ApClientClass.session.Items.ItemReceived += ItemReceive.OnItemReceived;
            result = Grime2ApClientClass.session.TryConnectAndLogin(
                "Grime 2",
                name,
                ItemsHandlingFlags.AllItems,
                new Version(0, 6, 5),
                new string[] { "DeathLink" },
                password: password,
                requestSlotData: true);
        }
        catch (Exception e)
        {
            Toasts.AddNew("Error while connecting: " + e.GetBaseException().Message);
            result = new LoginFailure(e.GetBaseException().Message);
        }

        if (!result.Successful)
        {
            LoginFailure failure = (LoginFailure)result;
            string errorMessage = $"Failed to Connect to {host}:{port} as {name}:";
            Toasts.AddNew(errorMessage);
            foreach (string error in failure.Errors)
            {
                errorMessage += $"\n    {error}";
            }
            foreach (ConnectionRefusedError error in failure.ErrorCodes)
            {
                errorMessage += $"\n    {error}";
            }

            return; // Did not connect, show the user the contents of `errorMessage`
        }
    
        // Successfully connected, `ArchipelagoSession` (assume statically defined as `session` from now on) can now be
        // used to interact with the server and the returned `LoginSuccessful` contains some useful information about the
        // initial connection (e.g. a copy of the slot data as `loginSuccess.SlotData`)
        var loginSuccess = (LoginSuccessful)result;
        Grime2ApClientClass.isConnected = true;
        Toasts.AddNew($"Successfully connected to {host} as {loginSuccess.Slot}!");
    }
    
    public static void OnMessageReceived(LogMessage message)
    {
        Melon<Grime2ApClientClass>.Logger.Msg($"Received message: {message}");
        Toasts.AddNew(message.ToString());
    }
}