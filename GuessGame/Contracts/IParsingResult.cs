using System.Collections.Generic;

namespace GuessGame.Contracts
{
    public interface IParsingResult<R>
    {
        R Value { get; }
        public void SetResult(R result);
        public IParsingResult<R> AddError(string text);
        public IParsingResult<R> AddErrorRange(List<string> texts);

        public IParsingResult<R> AddWarning(string text);
        public IParsingResult<R> AddWarningRange(List<string> texts);
        public bool IsSuccess { get; }
        public List<string> Errors { get; }
        public List<string> Warnings { get; }
    }
}
