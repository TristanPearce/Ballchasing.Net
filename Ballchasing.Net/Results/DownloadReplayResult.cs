using System.IO;
using System.Net;

namespace Ballchasing.Net
{
    public class DownloadReplayResult : IResult
    {

        public Stream Stream;

        ///<inheritdoc/>
        public HttpStatusCode StatusCode { get; set; }
        ///<inheritdoc/>
        public string Error { get; set; }
        ///<inheritdoc/>
        public bool Success => (StatusCode == HttpStatusCode.OK);
    }
}
