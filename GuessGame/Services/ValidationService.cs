using GuessGame.Contracts;

namespace GuessGame.Services
{
    public class ValidationService<T> : IValidationService<T>
    {
        private readonly ICompareService<T> _compareService;
        private readonly ISettingsService<T> _settingsService;

        public ValidationService(ICompareService<T> compareService, ISettingsService<T> settingsService)
        {
            _compareService = compareService;
            _settingsService = settingsService;
        }

        public bool ValidateValInRange(T value)
        {
            return _compareService.Compare(value, _settingsService.Settings.From) >= 0 
                && _compareService.Compare(value, _settingsService.Settings.To) <= 0;
        }
    }
}
