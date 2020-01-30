namespace Idle.Core
{

#region Store

    public enum Currency
    {
        Money,
        Crystal,
        Iap,
        Ads
    }

    public enum PurchaseError
    {
        None = 0,
        Unknown = 1,
        NotEnoughMoney = 2,
        NoInternetConnection = 3,
        UncompleteRewarded = 4
    }

    public enum StoreType
    {
        VirtualStore,
        IapStore,
        AdsStore
    }

#endregion
    
}