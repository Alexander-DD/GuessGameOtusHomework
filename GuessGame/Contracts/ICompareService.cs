namespace GuessGame.Contracts
{
    public interface ICompareService<T>
    {
        /// <summary>
        /// returns 1 if value1 more than value2; -1 if value1 less than value2; 0 if value1 == value2.
        /// </summary>
        int Compare(T value1, T value2);
    }
}
