using GuessGame.Contracts;

namespace GuessGame.Services
{
    public class InitialValidationService<T> : IInitialValidationService<T>
    {
        private readonly ICompareService<T> _compareService;

        public InitialValidationService(ICompareService<T> compareService)
        {
            _compareService = compareService;
        }

        public bool ValidateRange(T from, T to)
        {
            return _compareService.Compare(from, to) < 0;
        }
    }
}
