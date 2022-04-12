using GuessGame.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame.Services
{
    internal class BoolRandomizer : IRandomizer<bool>
    {
        private readonly ISettingsService<bool> _settingsService;
        public BoolRandomizer(ISettingsService<bool> settingsService)
        {
            _settingsService = settingsService;
        }

        public bool Random()
        {
            Random rnd = new Random();
            return rnd.Next(100) < 50 ? _settingsService.Settings.From: _settingsService.Settings.To;
        }
    }
}
