namespace GuessGame.Contracts

{
    public interface ISettingsService<T>
    {
        public GameSettings<T> GetSettings();
        public bool TryAddAttempt();
        public int GetAttemptCount();
    }
}
