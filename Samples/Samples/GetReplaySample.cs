using Ballchasing.Net;

using Samples.Net;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Samples
{
    [Sample]
    public class GetReplaySample
    {


        [Run]
        public async Task<Replay> GetReplay(IBallchasingAPI api, string replayId)
        {
            var result = await api.GetReplayAsync(replayId);
            var replay = result.Replay;

            Console.WriteLine($"Title: {replay.Title}");
            Console.WriteLine($"Duration: {replay.Duration}");

            return replay;
        }


    }
}
