using GuessGame.Contracts;

namespace GuessGame.Services
{
    public class ValidationService<T> : IValidationService<T>
    {
        private readonly IUIService _ui;
        private readonly ICompareService<T> _compareService;

        public ValidationService(IUIService ui, ICompareService<T> compareService)
        {
            _ui = ui;
            _compareService = compareService;
        }

        public bool ValidateRange(T from, T to)
        {
            if (_compareService.Compare(from, to) > 0)
            {
                _ui.ShowError("from > to");
                return false;
            }

            return true;
        }

        public bool ValidateValInRange(T value, GameSettings<T> settings)
        {
            return _compareService.Compare(value, settings.From) >= 0 && _compareService.Compare(value, settings.To) <= 0;
        }
    }
}
