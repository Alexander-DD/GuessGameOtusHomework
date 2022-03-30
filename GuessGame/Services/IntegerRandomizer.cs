using GuessGame.Contracts;
using System;

namespace GuessGame.Services
{
    public class IntegerRandomizer : IRandomizer<int>
    {
        public int Random(GameSettings<int> settings)
        {
            Random rnd = new Random();
            return rnd.Next(settings.From, settings.To);
        }
    }
}
