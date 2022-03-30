using GuessGame.Contracts;
using System;

namespace GuessGame.Services
{
    public class FromUISettingsService<T> : ISettingsService<T>
    {
        private readonly IUIService _ui;
        private readonly IParsingService<T> _parsingService;
        private readonly IParsingService<int> _intParsingService;
        private readonly IValidationService<T> _validationService;

        private GameSettings<T> settings;
        private int attempts;

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

                while (true)
                {
                    _ui.ShowMessage("Enter From:");
                    if (!_ui.Get(_parsingService, out from))
                    {
                        continue;
                    }

                    _ui.ShowMessage("Enter To:");
                    if (!_ui.Get(_parsingService, out to))
                    {
                        continue;
                    }

                    if (!_validationService.ValidateRange(from, to))
                    {
                        continue;
                    }

                    _ui.ShowMessage("Enter max of attempts:");
                    if (!_ui.Get(_intParsingService, out maxAttempts))
                    {
                        continue;
                    }

                    break;
                }

                settings = new GameSettings<T>(from, to, maxAttempts);
            }

            return settings;
        }

        public int GetAttemptCount() => attempts;

        public bool TryAddAttempt()
        {
            if (settings is null)
            {
                throw new Exception("Settings not initialized");
            }

            attempts++;

            if (attempts > settings.MaxAttempts)
            {
                return false;
            }

            return true;
        }
    }
}
