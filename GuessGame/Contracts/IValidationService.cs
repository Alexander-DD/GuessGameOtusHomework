namespace GuessGame.Contracts
{
    public interface IValidationService<T>
    {
        public bool ValidateRange(T from, T to);

        public bool ValidateValInRange(T value, GameSettings<T> settings);
    }
}
