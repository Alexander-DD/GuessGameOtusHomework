using GuessGame.Contracts;
using GuessGame.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GuessGame
{
    internal class Program
    {
        static void Main(string[] args) =>
            CreateHostBuilder(args).Build().Run();

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                {
                    services.AddHostedService<Worker<bool>>()
                            .AddScoped<IGameService, GameService<bool>>()
                            .AddScoped<IParsingService<int>, IntegerParsingService>()
                            .AddScoped<IParsingService<bool>, BoolParsingService>()
                            .AddScoped<IValidationService<bool>, ValidationService<bool>>()
                            .AddScoped<IInitialValidationService<bool>, InitialValidationService<bool>>()
                            .AddScoped<IRandomizer<bool>, BoolRandomizer>()
                            .AddScoped<ICompareService<bool>, BoolCompareService>()
                            .AddScoped<IUIService, ConsoleUIService>()
                            .AddSingleton<ISettingsService<bool>, FromUISettingsService<bool>>()
                            .AddSingleton<AttemptsCounter<bool>>();
                });
    }
}
