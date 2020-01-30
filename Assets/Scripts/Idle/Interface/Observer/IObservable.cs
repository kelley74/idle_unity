namespace Idle.Interface.Observer
{
    public interface IObservable<T,N>
    {
        void Subscribe(IObserver<T,N> observer);
        void Unsubscribe(IObserver<T,N> observer);
        void Notify(T notificationObject, N notification);
    }
}
