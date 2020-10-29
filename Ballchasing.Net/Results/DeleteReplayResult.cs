using System.Net;

namespace Ballchasing.Net
{
    public class DeleteReplayResult : IResult
    {
        ///<inheritdoc/>
        public HttpStatusCode StatusCode { get; set; }

        ///<inheritdoc/>
        public string Error { get; set; }

        /// <summary>
        /// True if the replay was successfully deleted.
        /// </summary>
        public bool Success => (StatusCode == HttpStatusCode.NoContent);
    }
}
