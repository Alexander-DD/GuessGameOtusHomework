using GuessGame.Contracts;

namespace GuessGame.Services
{
    public class IntegerParsingService : IParsingService<int>
    {
        public IParsingResult<int> TryParse(string input)
        {
            IParsingResult<int> parsingResult = new ParsingResult<int>();

            int result;
            if (int.TryParse(input, out result))
            {
                parsingResult.SetResult(result);
            }
            else
            {
                parsingResult.AddError("Input is not INTEGER!");
            }

            return parsingResult;
        }
    }
}
