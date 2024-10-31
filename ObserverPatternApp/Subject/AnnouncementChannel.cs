using ObserverPatternApp.Observers;

namespace ObserverPatternApp.Subject
{
    public class AnnouncementChannel : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            if (observer is StudentObserver student)
            {
                System.Console.WriteLine($"[Channel]: {student.StudentName} has unsubscribed from the announcements.");
            }
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update("New announcement published on the channel.");
            }
        }

        public void PublishAnnouncement(string announcement)
        {
            System.Console.WriteLine($"[Channel]: Publishing announcement: {announcement}");
            Notify();
        }
    }
}