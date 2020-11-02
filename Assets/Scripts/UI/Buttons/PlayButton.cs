using UnityEngine;
using Zenject;

namespace UI.Buttons
{
    public class PlayButton : ButtonViewModel
    {
        [Inject] private EventManager _eventManager;
        
        protected override void OnClickAction()
        {
            //TODO Открывает Сцену С игрой
            _eventManager.OnPlayButtonPressed?.Invoke();
        }
    }    
}

