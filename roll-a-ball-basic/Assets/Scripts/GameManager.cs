using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public int Score = 0;
    
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void GoToGameplay()
    {
        Score = 0;
        SceneManager.LoadScene("level1");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
