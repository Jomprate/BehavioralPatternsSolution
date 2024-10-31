// Location: Program.cs
using ChainOfResponsibilityApp.Handlers;
using ChainOfResponsibilityApp.Interfaces;

namespace ChainOfResponsibilityApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Set up the chain of responsibility
            ISupportHandler basicHandler = new BasicSupportHandler();
            ISupportHandler intermediateHandler = new IntermediateSupportHandler();
            ISupportHandler advancedHandler = new AdvancedSupportHandler();

            basicHandler.SetNext(intermediateHandler);
            intermediateHandler.SetNext(advancedHandler);

            // Test requests
            System.Console.WriteLine("Testing with a basic request:");
            basicHandler.HandleRequest("This is a basic support request.");

            System.Console.WriteLine("\nTesting with an intermediate request:");
            basicHandler.HandleRequest("This is an intermediate support request.");

            System.Console.WriteLine("\nTesting with an advanced request:");
            basicHandler.HandleRequest("This is an advanced support request.");

            System.Console.WriteLine("\nTesting with an unknown request:");
            basicHandler.HandleRequest("This is an unknown support request.");
        }
    }
}