using System.Collections.Generic;
using Idle.Interface;
using Idle.Interface.Observer;
using Idle.Interface.Store;

namespace Idle.Core.Common
{
    public class BaseBuyer : IBuyer
    {
        private List<IObserver<IPurchasable,PurchasingResult>> _purchasableObservers;

        public BaseBuyer()
        {
            _purchasableObservers = new List<IObserver<IPurchasable,PurchasingResult>>();
        }

        #region IObservable<IPurchasable>

        public void Subscribe(IObserver<IPurchasable,PurchasingResult> observer)
        {
            _purchasableObservers.Add(observer);
        }

        public void Unsubscribe(IObserver<IPurchasable,PurchasingResult> observer)
        {
            if (_purchasableObservers.Contains(observer))
            {
                _purchasableObservers.Remove(observer);
            }
        }

        public void Notify(IPurchasable notification, PurchasingResult result)
        {
            for (var i = 0; i < _purchasableObservers.Count; i++)
            {
                _purchasableObservers[i].Notify(notification, result);
            }
        }

        #endregion
        
        public virtual void MakePurchase(IPurchasable item)
        {
            Notify(item,PurchasingResult.Error((int)PurchaseError.Unknown));
        }
    }
}
