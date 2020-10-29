using System.Net;

namespace Ballchasing.Net
{
    public class PatchReplayGroupResult : IResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Error { get; set; }
        public bool Success => (StatusCode == HttpStatusCode.NoContent);
    }
}
