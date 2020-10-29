using System.Collections.Generic;
using System.Net;

namespace Ballchasing.Net
{
    public class GetMapCodeMappingsResult : IResult
    {
        /// <summary>
        /// Key: map_code, Value: map_name
        /// </summary>
        public IDictionary<string, string> Mappings { get; set; }

        public HttpStatusCode StatusCode { get; set; }
        public string Error { get; set; }
        public bool Success => (StatusCode == HttpStatusCode.OK);
    }
}
