using GuessGame.Contracts;
using System;

namespace GuessGame.Services
{
    public class GameService<T> : IGameService
    {
        private readonly IUIService _ui;
        private readonly IParsingService<T> _parsingService;
        private readonly ISettingsService<T> _settingsService;
        private readonly ICompareService<T> _compareService;
        private readonly IRandomizer<T> _randomService;
        private readonly IValidationService<T> _validationService;
        private readonly AttemptsCounter<T> _attemptsCounter;

        public GameService(IUIService ui, IParsingService<T> parsingService, ISettingsService<T> settingsService, ICompareService<T> compareService, IRandomizer<T> randomService, IValidationService<T> validationService, AttemptsCounter<T> attemptsCounter)
        {
            _ui = ui;
            _parsingService = parsingService;
            _settingsService = settingsService;
            _compareService = compareService;
            _randomService = randomService;
            _validationService = validationService;
            _attemptsCounter = attemptsCounter;
        }

        public void StartGame()
        {
            _ui.ShowMessage("Hi there, this is a GUESSING GAME!!!");

            _settingsService.InitializeSettings();

            T hidden = _randomService.Random();

            _ui.ShowMessage("PLAYPLAYPLAYPLAYPLAYPLAYPLAYPLAYPLAYPLAY");

            while (_attemptsCounter.TryAddAttempt())
            {
                _ui.ShowMessage("-------------------");
                _ui.ShowMessage("Enter value:");

                T value;
                if(!_ui.Get(_parsingService, out value))
                {
                    continue;
                }

                if(!_validationService.ValidateValInRange(value))
                {
                    _ui.ShowMessage("Your value out of range");
                    continue;
                }

                int compareResult = _compareService.Compare(value, hidden);
                if (compareResult == 0)
                {
                    _ui.ShowMessage("Winner, winner, chicken dinner");
                    return;
                }

                _ui.ShowMessage(compareResult < 0 ? "Your value < ***hidden***" : "***hidden*** < Your value");
            }

            _ui.ShowMessage("GAME OVER");
        }

        public void EndGame()
        {
            Environment.Exit(0);
        }
    }
}
