

using UniRx;
using UnityEngine;

namespace Model.ApplicationData
{
    public class ApplicationModel : ModelBase
    {
        public ReactiveProperty<float> Coins { get; set; }
        public float CoinsAmount { get; set; }
        
        public ApplicationModel()
        {
            Coins = new ReactiveProperty<float>(0);
            CoinsAmount = 0;
            Debug.LogError("Application model Created");
        }
    }
}

