using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class ScenesChanger : MonoBehaviour
{
    [Inject] private EventManager _eventManager;

    private void Awake()
    {
        _eventManager.OnPlayButtonPressed += LoadMainGame;
    }
    private void LoadMainGame()
    {
        SceneManager.LoadScene(Customization.Constants.Levels.MainGame);
    }

    private void LoadMainMenu()
    {
        SceneManager.LoadScene(Customization.Constants.Levels.MainMenu);
    }

    private void OnDestroy()
    {
        _eventManager.OnPlayButtonPressed -= LoadMainGame;
    }
}
