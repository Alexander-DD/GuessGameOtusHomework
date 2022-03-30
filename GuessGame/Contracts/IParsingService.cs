namespace GuessGame.Contracts
{
    public interface IParsingService<S>
    {
        public IParsingResult<S> TryParse(string input);

    }
}
