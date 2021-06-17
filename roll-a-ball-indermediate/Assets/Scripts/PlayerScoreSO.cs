using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerScoreSO : ScriptableObject
{
    private int _score = 0;

    private List<Action> _onPlayerScoreChanged = new List<Action>();

    public void AddListener(Action callback)
    {
        _onPlayerScoreChanged.Add(callback);
    }

    public void RemoveListener(Action callback)
    {
        _onPlayerScoreChanged.Remove(callback);
    }
    
    public int Score
    {
        get => _score;
        set
        {
            _score = value;
            _onPlayerScoreChanged.ForEach(callback => callback?.Invoke());
        }
    }

    public void Reset()
    {
        _score = 0;
        _onPlayerScoreChanged.Clear();
    }
    
}
