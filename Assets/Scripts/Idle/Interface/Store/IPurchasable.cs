using Idle.Interface.Item;

namespace Idle.Interface.Store
{
    public interface IPurchasable: IItem
    {
        int StoreType { get; }
        IPrice Price { get; }
        int Number { get; }
    }
}
