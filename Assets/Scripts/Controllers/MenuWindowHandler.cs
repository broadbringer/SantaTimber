using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Customization;
public class MenuWindowHandler : MonoBehaviour
{
    [SerializeField] private MenuWindow _menuView;
    
    public void SubscribeButton(Button button, UnityAction action)
    {
        button.onClick.AddListener(action);
    }

    private void Start()
    {
        SubscribeButton(_menuView.PlayButton, () => { SceneManager.LoadScene(Constants.Level.MainGame); });
        //TODO Реализовать другие кнопки.
    }
}
