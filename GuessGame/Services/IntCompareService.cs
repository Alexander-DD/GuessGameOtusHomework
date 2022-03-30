using GuessGame.Contracts;

namespace GuessGame.Services
{
    public class IntCompareService : ICompareService<int>
    {
        public int Compare(int value1, int value2)
        {
            if (value1 < value2)
            {
                return -1;
            }
            
            if (value1 > value2)
            {
                return 1;
            }

            return 0;
        }
    }
}
