using Idle.Core.Inventory;
using Idle.Core.Purchases;
using Idle.Interface;
using Idle.Interface.Observer;
using Idle.Interface.Store;
using UnityEngine;

namespace Idle.Core.Test
{
    public class ClientA : MonoBehaviour, IObserver<IPurchasable,PurchasingResult>
    {
        private PlayerInventory _inventory;

        void Start()
        {
            _inventory = new PlayerInventory();
            _inventory.Subscribe(this);
            
            var price = new Price((int)Currency.Money,0.2f);
            var product = new Product("house_A_0",1,price, StoreType.VirtualStore);
            
            IStore store = GetStore((StoreType) product.StoreType);//to do store fabric
            
            store.RequestPurchasing(product,_inventory);

        }

        public void Notify(IPurchasable notificationObject, PurchasingResult notification)
        {
            Debug.Log($"{notification.IsSuccess}: {notificationObject}");
        }

        //Fabric
        IStore GetStore(StoreType storeType)
        {
            IStore store = null;
            
            switch (storeType)
            {
                case StoreType.VirtualStore:
                    store = new VirtualStore.VirtualStore();
                    break;
            }

            return store;
        }
    }
}
