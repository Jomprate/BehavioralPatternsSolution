using ObserverPatternApp.Observers;

namespace ObserverPatternApp.Subject
{
    public interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}