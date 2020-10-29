using System.Collections.Generic;
using System.Net;

namespace Ballchasing.Net
{
    public class FilterReplaysResult : IResult
    {

        public IEnumerable<FilteredReplay> Replays { get; set; }

        public string Next { get; set; }

        public HttpStatusCode StatusCode { get; set; }
        public string Error { get; set; }
        public bool Success => (StatusCode == HttpStatusCode.OK);
    }
}
