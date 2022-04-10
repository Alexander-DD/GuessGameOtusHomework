namespace GuessGame.Contracts

{
    public interface ISettingsService<T>
    {
        public GameSettings<T> GetSettings();
    }
}
