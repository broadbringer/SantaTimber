using System.Collections;
using System.Collections.Generic;
using Model.ApplicationData;
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
            _model = new ApplicationModel();
            
        }
    }   
}

