using Idle.Interface;
using Idle.Interface.Store;
using UnityEngine;

namespace Idle.Core.Purchases
{
    public class Product : IPurchasable
    {
        public string Id { get; private set; }
        public int StoreType { get; private set;}
        public Price Price { get; private set;}
        public int Number { get; private set;}
        
        public Product(string id, int number, Price price, StoreType storeType)
        {
            Id = id;
            StoreType = (int)storeType;
            Price = price;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Id}: {Number} pcs - {Price.Cost}{Price.Currency} in {(StoreType)StoreType}";
        }
    }
}
