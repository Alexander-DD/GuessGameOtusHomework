using GuessGame.Contracts;
using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace GuessGame
{
    public class Worker<T> : BackgroundService
    {
        private readonly IGameService _gameService;

        public Worker(IGameService gameService)
        {
            _gameService = gameService;
        }
 
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _gameService.StartGame();
            _gameService.EndGame();
        }
    }
}
