using System;
using System.Collections.Generic;
using UnityEngine;

public class MessageBus : MonoBehaviour
{
    private static readonly Dictionary<Enum, Action> eventDictionary = new();

    public static bool IsSubscribed(Enum eventType)
    {
        return eventDictionary.ContainsKey(eventType) && eventDictionary[eventType] != null;
    }

    public static void Subscribe(Enum messageType, Action listener)
    {
        Debug.Log("Subscribing to event: " + messageType);
        if (eventDictionary.ContainsKey(messageType))
        {
            eventDictionary[messageType] += listener;
        }
        else
        {
            eventDictionary.Add(messageType, listener);
        }
    }

    public static void Unsubscribe(Enum eventType, Action listener)
    {
        Debug.Log("Unsubscribing from event: " + eventType);
        if (eventDictionary.ContainsKey(eventType))
        {
            eventDictionary[eventType] -= listener;
        }
    }

    public static void TriggerEvent(Enum eventType)
    {
        Debug.Log("Triggering event: " + eventType);
        if (eventDictionary.ContainsKey(eventType) && eventDictionary[eventType] != null)
        {
            eventDictionary[eventType].Invoke();
        }
    }
}