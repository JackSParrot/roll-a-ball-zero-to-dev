using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneLogicInitializer : MonoBehaviour
{
    [SerializeField]
    private PlayerScoreSO _playerScore = null;
    
    void Awake()
    {
        _playerScore.Reset();
    }
}
