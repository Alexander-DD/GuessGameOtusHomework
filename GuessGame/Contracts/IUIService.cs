using System.Collections.Generic;

namespace GuessGame.Contracts
{
    public interface IUIService
    {
        void ShowMessage(string message);
        void ShowMessages(IList<string> messages);

        bool Get<T>(IParsingService<T> parsingService, out T value);
    }
}
