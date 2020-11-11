using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuWindow : MonoBehaviour
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _shopButton;
    [SerializeField] private Button _settingButton;
    [SerializeField] private RectTransform _coinsValueParrent;
    [SerializeField] private TextMeshProUGUI _coinValue;

    public Button PlayButton => _playButton;
    public Button ShopButton => _shopButton;
    public Button SettingsButton => _settingButton;
    public RectTransform CoinsValueTransform => _coinsValueParrent;
    
    private void OnShown()
    {
        //TODO Реализовать анимацию
    }

    private void OnHidden()
    {
        
    }

    public void RenderCoinsValue(int value)
    {
        _coinValue.text = value.ToString();
    }
}
