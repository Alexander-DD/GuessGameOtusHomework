using GuessGame.Contracts;

namespace GuessGame
{
    public class AttemptsCounter<T>
    {
        private int attempts;

        private readonly ISettingsService<T> _settingsService;
        public AttemptsCounter(ISettingsService<T> settingsService)
        {
            _settingsService = settingsService;
        }

        public int GetAttemptCount() => attempts;

        public bool TryAddAttempt()
        {
            attempts++;

            return attempts <= _settingsService.Settings.MaxAttempts;
        }
    }
}
