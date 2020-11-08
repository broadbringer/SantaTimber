using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;

namespace View.Window
{
    public class MenuWindowView : ViewBase
    {
        [SerializeField] private RectTransform _playButton;
        [SerializeField] private RectTransform _settingButton;
        [SerializeField] private RectTransform _shopButton;
        [SerializeField] private RectTransform _coinsRect;
        [SerializeField] private TextMeshProUGUI _coinValue;
        
                         
        public override void OnShown()
        {
            _playButton.DOMove(new Vector3(), 1);
            _settingButton.DOMove(new Vector3(), 1);
            _shopButton.DOMove(new Vector3(), 1);
        }

        public void DrawCoinValue(float value)
        {
            _coinValue.text = value.ToString();
        }
    }   
}

