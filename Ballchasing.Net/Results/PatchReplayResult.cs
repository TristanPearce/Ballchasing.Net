using System.Net;

namespace Ballchasing.Net
{
    public class PatchReplayResult : IResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Error { get; set; }
        public bool Success => (StatusCode == HttpStatusCode.NoContent);
    }
}
