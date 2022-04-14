using GuessGame.Contracts;
using GuessGame.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GuessGame
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //setup our DI
            ServiceProvider serviceProvider = new ServiceCollection()
                            .AddScoped<IGameService, GameService<bool>>()
                            .AddScoped<IParsingService<int>, IntegerParsingService>()
                            .AddScoped<IParsingService<bool>, BoolParsingService>()
                            .AddScoped<IValidationService<bool>, ValidationService<bool>>()
                            .AddScoped<IInitialValidationService<bool>, InitialValidationService<bool>>()
                            .AddScoped<IRandomizer<bool>, BoolRandomizer>()
                            .AddScoped<ICompareService<bool>, BoolCompareService>()
                            .AddScoped<IUIService, ConsoleUIService>()
                            .AddScoped<IUIErrorsService, ConsoleUIErrorsService>()
                            .AddSingleton<ISettingsService<bool>, FromUISettingsService<bool>>()
                            .AddSingleton<AttemptsCounter<bool>>()
                            .AddSingleton<IWorker, Worker<bool>>()
                            .BuildServiceProvider();

            //do the actual work here
            IWorker bar = serviceProvider.GetService<IWorker>();
            bar.StartGame();
        }
    }
}
