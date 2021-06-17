using System;
using TMPro;
using UnityEngine;

public class GameUIView : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _scoreText = null;
    [SerializeField]
    private PlayerScoreSO _playerScore = null;

    private void OnEnable()
    {
        _playerScore.AddListener(UpdateScoreText);
        UpdateScoreText();
    }

    private void OnDisable()
    {
        _playerScore.RemoveListener(UpdateScoreText);
    }

    private void UpdateScoreText()
    {
        _scoreText.text = $"Score: {_playerScore.Score.ToString()}";
    }
}
