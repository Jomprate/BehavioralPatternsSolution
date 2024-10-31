using CommandPatternApp.Interfaces;
using CommandPatternApp.Receivers;

namespace CommandPatternApp.Commands
{
    public class UndoAccessResourceCommand : ICommand
    {
        private readonly ResourceManager _resourceManager;

        public UndoAccessResourceCommand(ResourceManager resourceManager)
        {
            _resourceManager = resourceManager;
        }

        public void Execute()
        {
            System.Console.WriteLine("UndoAccessResourceCommand: Executing undo command.");
            _resourceManager.UndoAccessResource();
        }

        public void Undo()
        {
            System.Console.WriteLine("UndoAccessResourceCommand: Command cannot be undone further.");
        }
    }
}