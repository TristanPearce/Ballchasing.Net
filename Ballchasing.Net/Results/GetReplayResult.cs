using System.Net;

namespace Ballchasing.Net
{
    public class GetReplayResult : IResult
    {
        public Replay Replay { get; set; }

        ///<inheritdoc/>
        public string Error { get; set; }

        ///<inheritdoc/>
        public HttpStatusCode StatusCode { get; set; }

        ///<inheritdoc/>
        public bool Success => (StatusCode == HttpStatusCode.OK);
    }
}
