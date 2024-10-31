namespace CommandPatternApp.Interfaces
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}