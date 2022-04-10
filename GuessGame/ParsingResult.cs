using GuessGame.Contracts;
using System.Collections.Generic;

namespace GuessGame
{
    public class ParsingResult<R> : IParsingResult<R>
    {
        public R Value { get; private set; }
        public void SetResult(R result)
        {
            Value = result;
        }

        public bool IsSuccess => Errors.Count == 0;
        public bool IsHaveWarnings => Warnings.Count == 0;


        private List<string> warnings = new List<string>();
        public List<string> Warnings => warnings;

        private List<string> errors = new List<string>();
        public List<string> Errors => errors;


        public IParsingResult<R> AddWarning(string text)
        {
            warnings.Add(text);

            return this;
        }

        public IParsingResult<R> AddWarningRange(List<string> texts)
        {
            warnings.AddRange(texts);

            return this;
        }

        public IParsingResult<R> AddError(string text)
        {
            errors.Add(text);

            return this;
        }

        public IParsingResult<R> AddErrorRange(List<string> texts)
        {
            errors.AddRange(texts);

            return this;
        }
    }
}
