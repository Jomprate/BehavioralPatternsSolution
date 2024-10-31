namespace ChainOfResponsibilityApp.Interfaces
{
    public interface ISupportHandler
    {
        void HandleRequest(string request);

        void SetNext(ISupportHandler nextHandler);
    }
}