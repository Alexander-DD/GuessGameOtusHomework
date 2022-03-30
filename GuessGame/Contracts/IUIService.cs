using System.Collections.Generic;

namespace GuessGame.Contracts
{
    public interface IUIService
    {
        void ShowMessage(string message);
        void ShowMessages(IList<string> messages);

        void ShowWarning(string warning);
        void ShowWarnings(IList<string> warnings);

        void ShowError(string error);
        void ShowErrors(IList<string> error);

        void Clear();

        bool Get<T>(IParsingService<T> parsingService, out T value);
    }
}
