using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Notificador : IObservable<Mensaje>
    {
        public IDisposable Subscribe(IObserver<Mensaje> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        public Notificador()
        {
            observers = new List<IObserver<Mensaje>>();
        }

        private List<IObserver<Mensaje>> observers;

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Mensaje>> _observers;
            private IObserver<Mensaje> _observer;

            public Unsubscriber(List<IObserver<Mensaje>> observers, IObserver<Mensaje> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void TrackMensaje(Mensaje men)
        {
            foreach (var observer in observers)
            {
                if (men.Texto == "")
                    observer.OnError(new Exception("error"));
                else
                    observer.OnNext(men);
            }
        }


        public void EndTransmission()
        {
            foreach (var observer in observers.ToArray())
                if (observers.Contains(observer))
                    observer.OnCompleted();

            observers.Clear();
        }

    }
}
