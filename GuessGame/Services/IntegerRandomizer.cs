using GuessGame.Contracts;
using System;

namespace GuessGame.Services
{
    public class IntegerRandomizer : IRandomizer<int>
    {
        private readonly ISettingsService<int> _settingsService;
        public IntegerRandomizer(ISettingsService<int> settingsService)
        {
            _settingsService = settingsService;
        }

        public int Random()
        {
            Random rnd = new Random();
            return rnd.Next(_settingsService.Settings.From, _settingsService.Settings.To);
        }
    }
}
