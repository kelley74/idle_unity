namespace Idle.Interface.Observer
{
    public interface IObserver<T,N>
    {
        void Notify(T notificationObject, N notification);
    }
}
