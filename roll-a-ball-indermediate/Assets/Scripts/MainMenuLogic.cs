using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{
    [SerializeField]
    private string _sceneName = "level1";
    
    public void GoToLevel()
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void Exit()
    {
        if (!Application.isEditor)
        {
            Application.Quit();
            return;
        }
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
