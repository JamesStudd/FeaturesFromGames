using System;

namespace Utility.Events
{
    public interface IEventBus<T>
    {
        T LastEvent { get; }
        IObservable<T> OnEvent { get; }
        
        void Publish(T value);
    }
}