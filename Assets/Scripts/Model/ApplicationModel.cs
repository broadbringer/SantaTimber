

using UnityEngine;

namespace Model.ApplicationData
{
    public class ApplicationModel : ModelBase
    {
        public float CoinsAmount { get; set; }
        
        public ApplicationModel()
        {
            CoinsAmount = 0;
            Debug.LogError("Application model Created");
        }
    }
}

