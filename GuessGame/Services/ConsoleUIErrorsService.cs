using GuessGame.Contracts;
using System;
using System.Collections.Generic;

namespace GuessGame.Services
{
    public class ConsoleUIErrorsService: IUIErrorsService
    {
        public void ShowWarning(string warning)
        {
            Console.WriteLine();
            Console.WriteLine("Warning:");
            Console.WriteLine(warning);
            Console.WriteLine();
        }

        public void ShowWarnings(IList<string> warnings)
        {
            Console.WriteLine();
            Console.WriteLine("Warnings:");

            foreach (string warning in warnings)
            {
                Console.WriteLine(warning);
            }

            Console.WriteLine();
        }

        public void ShowError(string error)
        {
            Console.WriteLine();
            Console.WriteLine("***Error occured:***");
            Console.WriteLine(error);
            Console.WriteLine("********************");
            Console.WriteLine();
        }

        public void ShowErrors(IList<string> errors)
        {
            Console.WriteLine();
            Console.WriteLine("***Errors occured:***");

            foreach (string error in errors)
            {
                Console.WriteLine(error);
            }

            Console.WriteLine("*********************");
            Console.WriteLine();
        }
    }
}
