﻿using ChainOfResponsibilityApp.Interfaces;

namespace ChainOfResponsibilityApp.Handlers
{
    public class AdvancedSupportHandler : ISupportHandler
    {
        private ISupportHandler? _nextHandler;

        public void HandleRequest(string request)
        {
            Console.WriteLine("AdvancedSupportHandler: Checking request...");

            if (request.Contains("advanced"))
            {
                Console.WriteLine("AdvancedSupportHandler: Request handled at the advanced level.");
            }
            else if (_nextHandler != null)
            {
                Console.WriteLine("AdvancedSupportHandler: Request cannot be handled. No further handlers available.");
                _nextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("AdvancedSupportHandler: Request cannot be handled. No further handlers available.");
            }
        }

        public void SetNext(ISupportHandler nextHandler)
        {
            // No next handler, as this is the last level in the chain
            _nextHandler = nextHandler;
        }
    }
}