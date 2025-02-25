using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObserverManager<T>
{
    static Dictionary<string, List<Action<T>>> listeners = new();

    public static void AddObserver(string name, Action<T> callback)
    {
        if (!listeners.ContainsKey(name)) listeners.Add(name, new List<Action<T>>());
        listeners[name].Add(callback);
    }

    public static void RemoveObserver(string name, Action<T> callback)
    {
        if (!listeners.ContainsKey(name)) return;

        listeners[name].Remove(callback);
    }

    public static void Notify(string name, T call)
    {
        if (!listeners.ContainsKey(name)) return;

        foreach (Action<T> action in listeners[name])
        {
            action?.Invoke(call);
        }
    }
}
