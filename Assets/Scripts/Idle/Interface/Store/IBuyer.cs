using Idle.Interface.Observer;

namespace Idle.Interface.Store
{
    public interface IBuyer : IObservable<IPurchasable,PurchasingResult>
    {
        void MakePurchase(IPurchasable item);
    }
}
