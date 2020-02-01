using Idle.Core.Common;
using Idle.Interface.Store;

namespace Idle.Core.Inventory
{
    public class PlayerInventory : BaseBuyer, IInventory
    {

        public PlayerInventory() : base()
        {
            
        }
        public override void MakePurchase(IPurchasable item)
        {
            Notify(item,PurchasingResult.Success());
        }
    }
}
