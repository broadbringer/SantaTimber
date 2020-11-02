using System.Collections;
using System.Collections.Generic;
using UI.Buttons;
using UI.Windows;
using UnityEngine;
using UnityEngine.Serialization;

namespace UI.Windows
{
    public class MainMenu : MonoBehaviour, IWindow
    {
        [SerializeField] private ButtonViewModel _playButton;
        [SerializeField] private ButtonViewModel _shopButton;
        [SerializeField] private ButtonViewModel _settingsButton;

        public void OnShown()
        {
            throw new System.NotImplementedException();
        }

        public void OnHidden()
        {
            throw new System.NotImplementedException();
        }
    }    
}

