﻿namespace DesignPatterns.Behavioral.Observer
{
    internal sealed class Unsubscriber<BaggageInfo> : IDisposable
    {
        private readonly ISet<IObserver<BaggageInfo>> _observers;

        private readonly IObserver<BaggageInfo> _observer;

        internal Unsubscriber(ISet<IObserver<BaggageInfo>> observers, IObserver<BaggageInfo> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            _observers.Remove(_observer);
        }
    }
}
