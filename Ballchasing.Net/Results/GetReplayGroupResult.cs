using System.Net;

namespace Ballchasing.Net
{
    public class GetReplayGroupResult : IResult
    {

        public ReplayGroup ReplayGroup { get; set; }

        public HttpStatusCode StatusCode { get; set; }
        public string Error { get; set; }
        public bool Success => (StatusCode == HttpStatusCode.OK);
    }
}
