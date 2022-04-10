using GuessGame.Contracts;

namespace GuessGame.Services
{
    public class FromUISettingsService<T> : ISettingsService<T>
    {
        private readonly IUIService _ui;
        private readonly IParsingService<T> _parsingService;
        private readonly IParsingService<int> _intParsingService;
        private readonly IValidationService<T> _validationService;

        private GameSettings<T> settings;

        public FromUISettingsService(IUIService ui, IParsingService<T> parsingService, IParsingService<int> intParsingService, IValidationService<T> validationService)
        {
            _ui = ui;
            _parsingService = parsingService;
            _intParsingService = intParsingService;
            _validationService = validationService;
        }

        public GameSettings<T> GetSettings()
        {
            if (settings is null)
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

                if (!_validationService.ValidateRange(from, to))
                {
                    T temp = from;
                    from = to;
                    to = temp;
                }

                do
                {
                    _ui.ShowMessage("Enter max of attempts:");
                }
                while (!_ui.Get(_intParsingService, out maxAttempts));

                settings = new GameSettings<T>(from, to, maxAttempts);
            }

            return settings;
        }
    }
}
