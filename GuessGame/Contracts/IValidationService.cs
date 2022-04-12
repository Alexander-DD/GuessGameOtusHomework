namespace GuessGame.Contracts
{
    public interface IValidationService<T>
    {
        public bool ValidateValInRange(T value);
    }
}
