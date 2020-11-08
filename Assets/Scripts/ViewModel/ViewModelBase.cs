using System.Collections;
using System.Collections.Generic;
using Model;
using UnityEngine;
using View;

namespace ViewModel
{
    public class ViewModelBase : MonoBehaviour, IViewModel
    {
        protected IView _view;
        protected IModel _model;
        
        public virtual void Bind()
        {
            _view = GetComponent<ViewBase>();
        }
    }    
}

