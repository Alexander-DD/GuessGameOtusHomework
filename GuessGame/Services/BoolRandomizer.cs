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
        public bool Random(GameSettings<bool> settings)
        {
            Random rnd = new Random();
            return rnd.Next(100) < 50 ? settings.From: settings.To;
        }
    }
}
