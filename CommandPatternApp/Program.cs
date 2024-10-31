using CommandPatternApp.Interfaces;
using CommandPatternApp.Commands;
using CommandPatternApp.Receivers;
using CommandPatternApp.Invoker;

namespace CommandPatternApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ResourceManager resourceManager = new ResourceManager();

            ICommand accessCommand = new AccessResourceCommand(resourceManager);
            ICommand modifyCommand = new ModifyResourceCommand(resourceManager);

            CommandInvoker invoker = new CommandInvoker();

            Console.WriteLine("Executing access command:");
            invoker.ExecuteCommand(accessCommand);

            Console.WriteLine("\nExecuting modify command:");
            invoker.ExecuteCommand(modifyCommand);

            Console.WriteLine("\nUndoing the last command:");
            invoker.UndoLastCommand();

            Console.WriteLine("\nUndoing the previous command:");
            invoker.UndoLastCommand();

            Console.WriteLine("\nAttempting to undo with no commands left:");
            invoker.UndoLastCommand();
        }
    }
}