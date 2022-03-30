namespace GuessGame.Contracts
{
    public interface IRandomizer<T>
    {
        T Random(GameSettings<T> settings);
    }
}
