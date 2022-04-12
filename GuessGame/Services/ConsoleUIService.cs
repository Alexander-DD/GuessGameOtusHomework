using GuessGame.Contracts;
using System;
using System.Collections.Generic;

namespace GuessGame.Services
{
    public class ConsoleUIService : IUIService
    {
        private readonly IUIErrorsService _uiErrorsService;

        public ConsoleUIService(IUIErrorsService uiErrorsService)
        {
            _uiErrorsService = uiErrorsService;
        }

        public bool Get<T>(IParsingService<T> _parsingService, out T value)
        {
            string input = Console.ReadLine();

            IParsingResult<T> parsingResult = _parsingService.TryParse(input);

            if (parsingResult.IsSuccess)
            {
                value = parsingResult.Value;
                return true;
            }
            else
            {
                value = default(T);
                _uiErrorsService.ShowErrors(parsingResult.Errors);
                return false;
            }

        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowMessages(IList<string> messages)
        {
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
