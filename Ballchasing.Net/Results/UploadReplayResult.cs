using System.Net;
using Ballchasing.Net;

namespace Ballchasing.Net
{
    public class UploadReplayResult : IResult
    {
        public UploadLocationInfo Upload { get; set; }

        public HttpStatusCode StatusCode { get; set; }
        public string Error { get; set; }
        public bool Success => (StatusCode == HttpStatusCode.Created);
        public bool Duplicate => (StatusCode == HttpStatusCode.Conflict);
    }
}
