using Idle.Interface;
using Idle.Interface.Store;
using UnityEngine;

namespace Idle.Core.Store
{
    [CreateAssetMenu(menuName = "ScriptableObject/Store/ScriptableProduct")]
    public class ScriptableProduct : ScriptableObject, IPurchasable
    {
        [SerializeField] private string _id;
        [SerializeField] private StoreType _storeType;
        [SerializeField] private Price _price;
        [SerializeField] private int _number;

        public string Id => _id;
        public int StoreType => (int)_storeType;
        public IPrice Price => _price;
        public int Number => _number;
        
        public override string ToString()
        {
            return $"{Id}: {Number} pcs - {Price.Cost}{Price.Currency} in {(StoreType)StoreType}";
        }
    }
}
