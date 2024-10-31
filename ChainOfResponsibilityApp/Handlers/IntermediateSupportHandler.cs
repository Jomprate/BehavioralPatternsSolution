using ChainOfResponsibilityApp.Interfaces;

namespace ChainOfResponsibilityApp.Handlers
{
    public class IntermediateSupportHandler : ISupportHandler
    {
        private ISupportHandler _nextHandler;

        public void HandleRequest(string request)
        {
            if (request.Contains("intermediate"))
            {
                System.Console.WriteLine("IntermediateSupportHandler: Request handled at the intermediate level.");
            }
            else if (_nextHandler != null)
            {
                System.Console.WriteLine("IntermediateSupportHandler: Passing to the next level.");
                _nextHandler.HandleRequest(request);
            }
            else
            {
                System.Console.WriteLine("IntermediateSupportHandler: No handler available for this request.");
            }
        }

        public void SetNext(ISupportHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }
    }
}