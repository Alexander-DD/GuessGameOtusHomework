using System.Collections.Generic;

namespace GuessGame.Contracts
{
    public interface IUIErrorsService
    {
        void ShowWarning(string warning);
        void ShowWarnings(IList<string> warnings);

        void ShowError(string error);
        void ShowErrors(IList<string> error);
    }
}
