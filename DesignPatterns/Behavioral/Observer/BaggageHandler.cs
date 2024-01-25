using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    internal class BaggageHandler : IObservable<BaggageInfo>
    {
        private readonly HashSet<IObserver<BaggageInfo>> _observers = new();
        private readonly HashSet<BaggageInfo> _flights = new();

        public IDisposable Subscribe(IObserver<BaggageInfo> observer)
        {
            //Firstly we check if the given observer is already a subscriber or not. (The Add method returns with a bool value)
            //Then if it is not, we add it to the HashSet of observers, and give the new observer all the already stored information currently in the _flights HashSet.
            if (_observers.Add(observer))
            {
                foreach (BaggageInfo item in _flights)
                {
                    observer.OnNext(item);
                }
            }

            //It is used from the outside, if the given subscriber wants to unsubscribe from the provider before it's OnCompleted method is called.
            return new Unsubscriber<BaggageInfo>(_observers, observer);
        }

        public void BaggageStatus(int flightNumber) => BaggageStatus(flightNumber, string.Empty, 0);
        
        public void BaggageStatus(int flightNumber, string from, int carousel)
        {
            BaggageInfo info = new BaggageInfo(flightNumber, from, carousel);

            if (carousel > 0 && _flights.Add(info))
            {
                foreach (IObserver<BaggageInfo> observer in _observers)
                {
                    observer.OnNext(info);
                }
            }
            else if (carousel == 0)
            {
                if (_flights.RemoveWhere(
                    flight => flight.FlightNumber == info.FlightNumber) > 0)
                {
                    foreach(IObserver<BaggageInfo> observer in _observers)
                    {
                        observer.OnNext(info);
                    }
                }
            }
        }

        public void LastBaggageClaimed()
        {
            foreach(IObserver<BaggageInfo> observer in _observers)
            {
                observer.OnCompleted();
            }

            _observers.Clear();
        }
    }
}
