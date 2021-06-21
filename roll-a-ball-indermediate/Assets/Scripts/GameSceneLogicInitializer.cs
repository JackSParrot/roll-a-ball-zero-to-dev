using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneLogicInitializer : MonoBehaviour
{
    [SerializeField]
    private List<EventBus> _eventBuses = new List<EventBus>();

    void Awake()
    {
        _eventBuses.ForEach(e => e.Reset());
    }
}