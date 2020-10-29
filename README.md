# Ballchasing.Net
.Net wrapper for the ballchasing.com API.

# Disclaimer!!!
Please note that Ballchasing.Net is still VERY alpha. Bugs are everywhere. Some classes need to be tweaked. A lot of documentation is yet to be done. I encourage you to help out where you can!
 
I support getting started on open-source code early in your software career, therefore I welcome new programmers looking for a place to start. 
If you dont have the technical ability to help just yet but want to help and learn you can either: 
- Send me an email at `tristanpearce24@gmail.com`.
- Create a new issue stating what you would like help with.

And I will see what I can do to help!

# How do I get up and running with this?
The `BallchasingClient` will be your bread and butter. It contains functions that mirror `ballchasing.com's` API, e.g. The `ping` endpoint has the URI of `https://ballchasing.com/api/`, to call it with Ballchasing.Net, call `client.PingAsync()`.

Currently, all functions are implemented using the `async/await` pattern of .Net. Some time in the future I might implement synchronous extention methods since some users might find this desirable.

Every function returns a `Result` object that contains information on the HTTP request, whether the request was successful, error text if relevant and then the payload of the request (a replay, a list of replays, a replay group etc).

# Sample
In the future a dedicated `Samples` project will be added to the repositiory.
```csharp
using System.Threading.Tasks;
using Ballchasing.Net;
class Program
{
    public static async Task Main(string[] args)
    {
        // Create the client.
        string token = "Enter your token here!";
        using BallchasingClient client = new BallchasingClient(token);

        // Ping the API.
        var pingResult = await client.PingAsync();

        // Set title of a replay.
        string replayId = "Id of a replay.";
        ReplayPatchInfo patchInfo = new ReplayPatchInfo()
        {
            Title = "My new title!"
        };
        var patchResult = await client.PatchReplayAsync(replayId, patchInfo);

        // Delete Replay Group.
        string replayGroupId = "Id of a replay group.";
        var deleteResult = await client.DeleteReplayGroupAsync(replayGroupId);
    }
}
```
