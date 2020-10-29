using System.Collections.Generic;
using System.Net;

namespace Ballchasing.Net
{
    public class FilterReplayGroupsResult : IResult
    {
        public IEnumerable<FilteredReplayGroup> Groups { get; set; }

        public string Next { get; set; }

        public HttpStatusCode StatusCode { get; set; }
        public string Error { get; set; }
        public bool Success => (StatusCode == HttpStatusCode.OK);
    }
}
