using GuessGame.Contracts;

namespace GuessGame.Services
{
    public class Worker<T> : IWorker
    {
        private readonly IGameService _gameService;

        public Worker(IGameService gameService)
        {
            _gameService = gameService;
        }

        public void StartGame()
        {
            _gameService.StartGame();
            _gameService.EndGame();
        }
    }
}
