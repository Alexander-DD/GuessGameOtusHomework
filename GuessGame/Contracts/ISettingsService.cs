namespace GuessGame.Contracts

{
    public interface ISettingsService<T>
    {
        public void InitializeSettings();
        public GameSettings<T> Settings { get; }
    }
}
