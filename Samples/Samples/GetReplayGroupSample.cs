using Ballchasing.Net;

using Samples.Net;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Samples
{
    [Sample]
    public class GetReplayGroupSample
    {
        public async Task<ReplayGroup> GetReplayGroup(IBallchasingAPI api, string replayGroupId)
        {

            var result = await api.GetReplayGroupAsync(replayGroupId);
            var replayGroup = result.ReplayGroup;

            Console.WriteLine($"Creator: {replayGroup.Creator}");

            return replayGroup;
        }
    }
}
