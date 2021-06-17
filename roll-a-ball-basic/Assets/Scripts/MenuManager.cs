using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void Play()
    {
        GameManager.Instance.GoToGameplay();
    }

    public void Exit()
    {
        GameManager.Instance.Exit();
    }
}
