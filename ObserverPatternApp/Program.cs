using ObserverPatternApp.Subject;
using ObserverPatternApp.Observers;

namespace ObserverPatternApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AnnouncementChannel channel = new();

            StudentObserver student1 = new("Alice the bad student");
            StudentObserver student2 = new("Bob the good student");

            channel.Attach(student1);
            channel.Attach(student2);

            channel.PublishAnnouncement("Final exam will be next Monday.");

            channel.Detach(student1);

            channel.PublishAnnouncement("Project submission extended until Friday.");
        }
    }
}