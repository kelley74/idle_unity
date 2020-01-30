using UnityEngine;

namespace Idle.Interface.Store
{
    [System.Serializable]
    public class Price
    {
        [SerializeField] private int _currency;
        [SerializeField] private float _cost;
        
        public int Currency => _currency;
        public float Cost => _cost;

        public Price(int currency, float cost)
        {
            _currency = currency;
            _cost = cost;
        }
    }
}
