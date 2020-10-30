using Ballchasing.Net;

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

            runner.BuildNamedArguments += (x => 
            {
                x.Add("replayId", "56889c3e-c420-45db-92fd-47ce2a3604b0");
                x.Add("replayGroupId", "id");
            });

            Console.Write("Enter API Token: ");
            string apiToken = Console.ReadLine();

            runner.BuildServiceProvider += (x =>
            {
                x.AddSingleton<IBallchasingAPI>(new BallchasingClient(apiToken));
            });

            runner.FindSamples(typeof(Program).Assembly);

            runner.Run();
        }
    }
}
