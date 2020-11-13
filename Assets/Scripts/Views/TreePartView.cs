using UnityEngine;

namespace SantaTimber.Views
{
    public class TreePartView : MonoBehaviour
    {
        public Transform CachedTransform { get; private set; }
        public SpriteRenderer _sprite { get; private set; }

        private void Awake()
        {
            _sprite = GetComponentInChildren<SpriteRenderer>();
            CachedTransform = GetComponent<Transform>();
        }
        
        public void OnHit()
        {
            //TODO Улетает за пределы экрана, плюс плавно исчезает
        }
    }    
}

