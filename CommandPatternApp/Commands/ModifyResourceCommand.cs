using CommandPatternApp.Interfaces;
using CommandPatternApp.Receivers;

namespace CommandPatternApp.Commands
{
    public class ModifyResourceCommand : ICommand
    {
        private readonly ResourceManager _resourceManager;

        public ModifyResourceCommand(ResourceManager resourceManager)
        {
            _resourceManager = resourceManager;
        }

        public void Execute()
        {
            Console.WriteLine("ModifyResourceCommand: Executing modify command.");
            _resourceManager.ModifyResource();
        }

        public void Undo()
        {
            Console.WriteLine("ModifyResourceCommand: Undoing modify command.");
            _resourceManager.UndoModifyResource();
        }
    }
}