using System.Net;

namespace Ballchasing.Net
{
    public class CreateReplayGroupResult : IResult
    {
        public ReplayGroupLocationInfo ReplayGroup { get; set; }

        public HttpStatusCode StatusCode { get; set; }
        public string Error { get; set; }
        public bool Success => (StatusCode == HttpStatusCode.Created);
    }
}
