using Ballchasing.Net;

using Samples.Net;
using Samples.Utils;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Samples
{

    [Sample]
    public class UploadReplaySample
    {

        [Run]
        public async Task UploadReplay(IBallchasingAPI api)
        {
            // This loads an example replay from embedded data
            EmbeddedResourceLoader loader = new EmbeddedResourceLoader(typeof(UploadReplaySample).Assembly, "Samples.Data.");

            string replayFileName = "my_2v2.replay";

            // This gets the stream to the replay file. You would probably use File.Open to read a real replay from disk.
            using Stream replay = loader.GetResource(replayFileName);

            // this uploads the replay
            var result = await api.UploadReplayAsync(replay, replayFileName, Privacy.Private);

            if (result.Success)
            {
                Console.WriteLine($"ID: {result.Upload.Id}");
                Console.WriteLine($"Location: {result.Upload.Location}");
            }
            else
            {
                Console.WriteLine("Replay failed to upload");
                Console.WriteLine(result.Error);
            }
        }
    }
}
