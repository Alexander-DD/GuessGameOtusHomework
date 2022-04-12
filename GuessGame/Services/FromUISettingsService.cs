using GuessGame.Contracts;

namespace GuessGame.Services
{
    public class FromUISettingsService<T> : ISettingsService<T>
    {
        private readonly IUIService _ui;
        private readonly IParsingService<T> _parsingService;
        private readonly IParsingService<int> _intParsingService;
        private readonly IInitialValidationService<T> _initialValidationService;

        private GameSettings<T> settings;

        public FromUISettingsService(IUIService ui, IParsingService<T> parsingService, IParsingService<int> intParsingService, IInitialValidationService<T> initialValidationService)
        {
            _ui = ui;
            _parsingService = parsingService;
            _intParsingService = intParsingService;
            _initialValidationService = initialValidationService;
        }

        public void InitializeSettings()
        {
            settings = GetSettings();
        }

        public GameSettings<T> Settings => settings ?? GetSettings();

        public GameSettings<T> GetSettings()
        {
            _ui.ShowMessage("***Getting settings***");

            T from, to;
            int maxAttempts;

            do
            {
                _ui.ShowMessage("Enter From:");
            }
            while (!_ui.Get(_parsingService, out from));

            do
            {
                _ui.ShowMessage("Enter To:");

            }
            while (!_ui.Get(_parsingService, out to));

            if (!_initialValidationService.ValidateRange(from, to))
            {
                T temp = from;
                from = to;
                to = temp;

                _ui.ShowWarning("From and To were swapped!");
            }

            do
            {
                _ui.ShowMessage("Enter max of attempts:");
            }
            while (!_ui.Get(_intParsingService, out maxAttempts));

            return new GameSettings<T>(from, to, maxAttempts);
        }
    }
}
