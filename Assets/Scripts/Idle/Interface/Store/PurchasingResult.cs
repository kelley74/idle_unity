namespace Idle.Interface.Store
{
    public class PurchasingResult
    {
        public bool IsSuccess { get; private set; }
        public int ErrorCode { get; private set; }

        private PurchasingResult()
        {
            IsSuccess = true;
            ErrorCode = 0;
        }

        private PurchasingResult(int errorCode)
        {
            IsSuccess = false;
            ErrorCode = errorCode;
        }
    
        public static PurchasingResult Success()
        {
            return new PurchasingResult();
        }
    
        public static PurchasingResult Error(int eroor)
        {
            return new PurchasingResult(eroor);
        }
    }
}
