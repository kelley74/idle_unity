
namespace Idle.Interface.Store
{
    public interface IStore
    {
        int StoreType { get; }
        void RequestPurchasing(IPurchasable item, IBuyer buyer);
    }
}
