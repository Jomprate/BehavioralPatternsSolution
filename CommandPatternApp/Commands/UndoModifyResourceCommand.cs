using CommandPatternApp.Interfaces;
using CommandPatternApp.Receivers;

namespace CommandPatternApp.Commands
{
    public class UndoModifyResourceCommand : ICommand
    {
        private readonly ResourceManager _resourceManager;

        public UndoModifyResourceCommand(ResourceManager resourceManager)
        {
            _resourceManager = resourceManager;
        }

        public void Execute()
        {
            Console.WriteLine("UndoModifyResourceCommand: Executing undo modify command.");
            _resourceManager.UndoModifyResource();
        }

        public void Undo()
        {
            Console.WriteLine("UndoModifyResourceCommand: Command cannot be undone further.");
        }
    }
}