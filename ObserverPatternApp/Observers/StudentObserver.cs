namespace ObserverPatternApp.Observers
{
    public class StudentObserver : IObserver
    {
        public string StudentName { get; private set; }

        public StudentObserver(string name)
        {
            StudentName = name;
        }

        public void Update(string message)
        {
            System.Console.WriteLine($"[Student {StudentName}]: {message}");
        }
    }
}