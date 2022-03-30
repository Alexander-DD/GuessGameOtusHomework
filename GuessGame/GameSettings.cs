namespace GuessGame
{
    public class GameSettings<T>
    {
        public GameSettings(T from, T to, int maxAttempts)
        {
            From = from;
            To = to;
            MaxAttempts = maxAttempts;
        }

        public T From { get; }
        public T To { get; }
        public int MaxAttempts { get; }
    }
}
