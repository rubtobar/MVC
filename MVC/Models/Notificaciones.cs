using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Notificaciones : IObserver<Mensaje>
    {
        private IDisposable unsubscriber;

        public virtual void Subscribe(IObservable<Mensaje> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public void OnCompleted()
        {
            this.Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("error");
        }

        public void OnNext(Mensaje value)
        {
            Console.WriteLine(value.Texto);
        }
        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
