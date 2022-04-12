namespace GuessGame.Contracts
{
    public interface IInitialValidationService<T>
    {
        public bool ValidateRange(T from, T to);
    }
}
