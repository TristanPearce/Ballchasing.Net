using System.Net;

namespace Ballchasing.Net
{
    public class PingResult : IResult
    {
        /// <summary>
        /// Steam display name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Steam numeric ID
        /// </summary>
        public string SteamId { get; set; }

        ///<inheritdoc/>
        public string Error { get; set; }

        ///<inheritdoc/>
        public HttpStatusCode StatusCode { get; set; }
        ///<inheritdoc/>
        public bool Success => (StatusCode == HttpStatusCode.OK);
    }
}
