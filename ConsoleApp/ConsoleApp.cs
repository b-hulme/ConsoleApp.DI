using ConsoleApp.Options;
using System;

namespace ConsoleApp
{
    internal class ConsoleApp : IApplication
    {
        private ApplicationOptions _appOptions;

        public ConsoleApp(ApplicationOptions appOptions)
        {
            _appOptions = appOptions;
        }

        public int Execute(string[] args)
        {
            Console.WriteLine(_appOptions.Message);

            return 0;
        }
    }
}
