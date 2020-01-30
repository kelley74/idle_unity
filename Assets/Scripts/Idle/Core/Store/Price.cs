using Idle.Interface;
using Idle.Interface.Store;
using UnityEngine;

namespace Idle.Core.Store
{
    [System.Serializable]
    public class Price : IPrice
    {
        [SerializeField] private Currency _currency;
        [SerializeField] private float _cost;

        public int Currency => (int)_currency;
        public float Cost => _cost;

        public Price(Currency currency, float cost)
        {
            _currency = currency;
            _cost = cost;
        }
    }
}
