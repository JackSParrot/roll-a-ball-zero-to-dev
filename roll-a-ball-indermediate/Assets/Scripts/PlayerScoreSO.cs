using UnityEngine;

[CreateAssetMenu]
public class PlayerScoreSO : EventBus
{
    private int _score = 0;
    
    public int Score
    {
        get => _score;
        set
        {
            _score = value;
            Raise();
        }
    }

    public override void Reset()
    {
        base.Reset();
        _score = 0;
    }
}
