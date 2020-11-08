using UnityEngine;

namespace View
{
    public class ViewBase : MonoBehaviour, IView
    {
        public  virtual void OnShown()
        {
            throw new System.NotImplementedException();
        }

        public virtual void OnHidden()
        {
            throw new System.NotImplementedException();
        }
    }    
}

