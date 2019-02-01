using System;

namespace ObserverPattern
{
    public class Observer1 : IObserver<PayLoad>
    {
        public string Message { get; set; }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(PayLoad value)
        {
            Message = value.Message;
        }

        public IDisposable Register(Subject subject)
        {
            return subject.Subscribe(this);
        }
    }
}