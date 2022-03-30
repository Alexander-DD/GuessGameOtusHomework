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
                    services.AddHostedService<Worker<int>>()
                            .AddScoped<IGameService, GameService<int>>()
                            .AddScoped<ISettingsService<int>, FromUISettingsService<int>>()
                            .AddScoped<IParsingService<int>, IntegerParsingService>()
                            .AddScoped<IValidationService<int>, ValidationService<int>>()
                            .AddScoped<IRandomizer<int>, IntegerRandomizer>()
                            .AddScoped<ICompareService<int>, IntCompareService>()
                            .AddScoped<IUIService, ConsoleUIService>();
                });
    }
}
