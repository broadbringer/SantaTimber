using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Buttons
{
    public abstract class ButtonViewModel: MonoBehaviour
    {
        [SerializeField] private Button _buttonView;

        protected void Start()
        {
            _buttonView = GetComponent<Button>();
            if (_buttonView == null)
            {
                Debug.LogError($"In class {this.name} _button is Null");
            }
            else
            {
                _buttonView.onClick.AddListener(OnClickAction);
            }
        }

        protected abstract void OnClickAction();

    }    
}

