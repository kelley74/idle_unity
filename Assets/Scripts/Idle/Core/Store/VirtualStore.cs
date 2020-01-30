using Idle.Interface.Store;

namespace Idle.Core.Store
{
    public class VirtualStore : IStore
    {

        public int StoreType => (int)Core.StoreType.VirtualStore;
        
        public void RequestPurchasing(IPurchasable item, IBuyer buyer)
        {
            //Virtual store doesn't have any limits for buying items
            buyer.MakePurchase(item);
        }
    }
}
