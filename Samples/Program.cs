using Samples.Net;

using System;
using System.Reflection;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleRunnerInfo info = new ConsoleRunnerInfo()
            {

            };

            ConsoleRunner runner = new ConsoleRunner(info);

            runner.FindSamples(typeof(Program).Assembly);

            runner.Run();
        }
    }
}
