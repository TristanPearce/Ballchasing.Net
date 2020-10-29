﻿using System.Net;

namespace Ballchasing.Net
{
    public class DeleteReplayGroupResult : IResult
    {
        ///<inheritdoc/>
        public HttpStatusCode StatusCode { get; set; }

        ///<inheritdoc/>
        public string Error { get; set; }

        /// <summary>
        /// True if the replay group was successfully deleted.
        /// </summary>
        public bool Success => (StatusCode == HttpStatusCode.NoContent);
    }
}
