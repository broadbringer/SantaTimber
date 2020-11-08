using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

namespace View.Window
{
    public class MenuWindowView : ViewBase
    {
        [SerializeField] private RectTransform _playButton;
        [SerializeField] private RectTransform _settingButton;
        [SerializeField] private RectTransform _shopButton;
        [SerializeField] private RectTransform _coinsRect;
        [SerializeField] private Text _coinValue;
        
                         
        public override void OnShown()
        {
            _playButton.DOShakeRotation(2f, new Vector3(0, 45, 0));
            _settingButton.DOShakeRotation(2f, new Vector3(0, 45, 0));
            _shopButton.DOShakeRotation(2f, new Vector3(0, 45, 0));
        }

        public void DrawCoinValue(float value)
        {
            _coinValue.text = value.ToString();
        }
    }   
}

