﻿using Idle.Core.Inventory;
using Idle.Core.Store;
using Idle.Interface;
using Idle.Interface.Observer;
using Idle.Interface.Store;
using UnityEngine;

namespace Idle.Core.Test
{
    public class ClientA : MonoBehaviour, IObserver<IPurchasable,PurchasingResult>
    {

        public ScriptableProduct product;
        
        private PlayerInventory _inventory;

        void Start()
        {
            _inventory = new PlayerInventory();
            _inventory.Subscribe(this);

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
                    store = new VirtualStore();
                    break;
            }

            return store;
        }
    }
}
