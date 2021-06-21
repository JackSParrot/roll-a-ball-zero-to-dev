using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnScore : MonoBehaviour
{
    [SerializeField]
    private PlayerScoreSO _playerScore = null;

    [SerializeField]
    private int _targetScore = 5;

    [SerializeField]
    private bool _activate = true;

    void Awake()
    {
        gameObject.SetActive(!_activate);
        _playerScore.AddListener(OnScoreUpdated);
        OnScoreUpdated();
    }

    void OnScoreUpdated()
    {
        if (_playerScore.Score >= _targetScore)
        {
            gameObject.SetActive(_activate);
            _playerScore.RemoveListener(OnScoreUpdated);
        }
    }
}