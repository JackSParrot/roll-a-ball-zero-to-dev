using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EventBus", menuName = "EventBus", order = 0)]
public class EventBus : ScriptableObject
{
    private List<Action> _listeners = new List<Action>();
    private List<Action> _listenersToAdd = new List<Action>();
    private List<Action> _listenersToRemove = new List<Action>();

    private bool _working = false;

    public void AddListener(Action callback)
    {
        if (_working)
        {
            _listenersToAdd.Add(callback);
            return;
        }
        _listeners.Add(callback);
    }

    public void RemoveListener(Action callback)
    {
        if (_working)
        {
            _listenersToRemove.Add(callback);
            return;
        }
        _listeners.Remove(callback);
    }

    public void Raise()
    {
        _working = true;
        _listeners.ForEach(c => c?.Invoke());
        _working = false;
        foreach (var listener in _listenersToRemove)
        {
            _listeners.Remove(listener);
        }
        _listeners.AddRange(_listenersToAdd);
        _listenersToAdd.Clear();
        _listenersToRemove.Clear();
    }

    public virtual void Reset()
    {
        _listeners.Clear();
    }
}