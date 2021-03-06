﻿using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Customization;
using SantaTimber.Views;

namespace SantaTimber.Controllers
{
    public class MenuWindowHandler 
    {
        private MenuWindow _menuView;

        public MenuWindowHandler(MenuWindow menuView)
        {
            _menuView = menuView;
            
            Bind();
         
        }
     
        private void SubscribeButton(Button button, UnityAction action)
        {
            button.onClick.AddListener(action);
        }

        private void Bind()
        {
            SubscribeButton(_menuView.PlayButton, () => { SceneManager.LoadScene(Constants.Level.MainGame); });
            //TODO Реализовать другие кнопки.
        }
    }
}

