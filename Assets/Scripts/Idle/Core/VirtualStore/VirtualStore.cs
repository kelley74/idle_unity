using Idle.Interface.Store;
using UnityEngine;

namespace Idle.Core.VirtualStore
{
    public class VirtualStore : IStore
    {

        public int StoreType => (int)Interface.StoreType.VirtualStore;
        
        public void RequestPurchasing(IPurchasable item, IBuyer buyer)
        {
            //Virtual store doesn't have any limits for buying items
            buyer.MakePurchase(item);
        }
    }
}
