using UnityEngine;

public class ScoreCoinInteractible : AInteractible
{
    [SerializeField]
    private int _score = 1;
    
    [SerializeField]
    private PlayerScoreSO _playerScore = null;

    public override void Interact()
    {
        _playerScore.Score += _score;
        Destroy(gameObject);
    }
}
