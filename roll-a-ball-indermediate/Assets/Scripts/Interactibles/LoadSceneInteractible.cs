using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneInteractible : AInteractible
{
    [SerializeField]
    private string _sceneName = String.Empty;

    public override void Interact()
    {
        SceneManager.LoadScene(_sceneName);
    }
}