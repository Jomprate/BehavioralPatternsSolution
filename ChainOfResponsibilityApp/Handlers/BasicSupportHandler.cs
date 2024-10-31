using ChainOfResponsibilityApp.Interfaces;

namespace ChainOfResponsibilityApp.Handlers
{
    public class BasicSupportHandler : ISupportHandler
    {
        private ISupportHandler? _nextHandler;

        public void HandleRequest(string request)
        {
            if (request.Contains("basic"))
            {
                Console.WriteLine("BasicSupportHandler: Request handled at the basic level.");
            }
            else if (_nextHandler != null)
            {
                Console.WriteLine("BasicSupportHandler: Passing to the next level.");
                _nextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("BasicSupportHandler: No handler available for this request.");
            }
        }

        public void SetNext(ISupportHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }
    }
}