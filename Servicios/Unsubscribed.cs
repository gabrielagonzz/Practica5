namespace Practica5.Servicios
{
    public class Unsubscribed : IDisposable
    {
        private readonly List<IObserver<Models.Task>> _observers;
        private readonly IObserver<Models.Task> _observer;

        public Unsubscribed(List<IObserver<Models.Task>> observers, IObserver<Models.Task> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
