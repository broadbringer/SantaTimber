using System.Collections;
using System.Collections.Generic;
using Model.ApplicationData;
using UniRx;
using View.Window;
using UnityEngine;

namespace ViewModel.Window
{
    public class MenuWindowViewModel : ViewModelBase
    {
        private ApplicationModel _model;
        private MenuWindowView _menuView;
        
        public override void Bind()
        {
            //Модель будет внедряться через контейнер, это пока для теста создана здесь.
            _model = new ApplicationModel();
            _menuView = GetComponent<MenuWindowView>();
            _model.Coins.ObserveEveryValueChanged(x => x.Value).Subscribe(
                xs => { _menuView.DrawCoinValue(xs); }
            ).AddTo(this);
            _menuView.OnShown();
            StartCoroutine(ChangeValue(10));
        }

        private IEnumerator ChangeValue(float value)
        {
            while (true)
            {
                yield return new WaitForSeconds(5);
                _model.Coins.Value += value;
            }
        }
    }   
}

