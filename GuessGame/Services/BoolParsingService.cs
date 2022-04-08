using GuessGame.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame.Services
{
    internal class BoolParsingService : IParsingService<bool>
    {
        public IParsingResult<bool> TryParse(string input)
        {
            IParsingResult<bool> parsingResult = new ParsingResult<bool>();

            bool result;
            if (bool.TryParse(input, out result))
            {
                parsingResult.SetResult(result);
            }
            else
            {
                parsingResult.AddError("Input is not BOOLEAN!");
            }

            return parsingResult;
        }
    }
}
