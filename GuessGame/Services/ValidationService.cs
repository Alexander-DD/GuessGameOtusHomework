using GuessGame.Contracts;

namespace GuessGame.Services
{
    public class ValidationService<T> : IValidationService<T>
    {
        private readonly ICompareService<T> _compareService;

        public ValidationService(ICompareService<T> compareService)
        {
            _compareService = compareService;
        }

        public bool ValidateRange(T from, T to)
        {
            return _compareService.Compare(from, to) < 0;
        }

        public bool ValidateValInRange(T value, GameSettings<T> settings)
        {
            return _compareService.Compare(value, settings.From) >= 0 && _compareService.Compare(value, settings.To) <= 0;
        }
    }
}
