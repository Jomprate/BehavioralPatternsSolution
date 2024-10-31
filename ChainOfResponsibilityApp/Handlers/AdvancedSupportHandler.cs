using ChainOfResponsibilityApp.Interfaces;

namespace ChainOfResponsibilityApp.Handlers
{
    public class AdvancedSupportHandler : ISupportHandler
    {
        public void HandleRequest(string request)
        {
            Console.WriteLine("AdvancedSupportHandler: Checking request...");

            if (request.Contains("advanced"))
            {
                Console.WriteLine("AdvancedSupportHandler: Request handled at the advanced level.");
            }
            else
            {
                Console.WriteLine("AdvancedSupportHandler: Request cannot be handled. No further handlers available.");
                Console.WriteLine("AdvancedSupportHandler: End of chain reached. No handler could process this request.");
            }
        }

        public void SetNext(ISupportHandler nextHandler)
        {
            // No next handler, as this is the last level in the chain
        }
    }
}