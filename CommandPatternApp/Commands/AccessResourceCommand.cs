using CommandPatternApp.Interfaces;
using CommandPatternApp.Receivers;

namespace CommandPatternApp.Commands
{
    public class AccessResourceCommand : ICommand
    {
        private readonly ResourceManager _resourceManager;

        public AccessResourceCommand(ResourceManager resourceManager)
        {
            _resourceManager = resourceManager;
        }

        public void Execute()
        {
            Console.WriteLine("AccessResourceCommand: Executing access command.");
            _resourceManager.AccessResource();
        }

        public void Undo()
        {
            Console.WriteLine("AccessResourceCommand: Undoing access command.");
            _resourceManager.UndoAccessResource();
        }
    }
}