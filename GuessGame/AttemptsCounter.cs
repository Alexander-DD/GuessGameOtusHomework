namespace GuessGame
{
    public class AttemptsCounter
    {
        private int maxAttempts;
        private int attempts;

        public AttemptsCounter(int maxAttempts)
        {
            this.maxAttempts = maxAttempts;
        }

        public int GetAttemptCount() => attempts;

        public bool TryAddAttempt()
        {
            attempts++;

            return attempts <= maxAttempts;
        }
    }
}
