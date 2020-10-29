using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    /// <summary>
    /// https://ballchasing.com/doc/api#replays-replays-get
    /// </summary>
    [DataContract]
    public class FilteredReplaysList
    {

        [DataMember(Name = "count")]
        public int Count { get; set; }

        [DataMember(Name = "list")]
        public IList<FilteredReplay> Replays { get; set; }

        [DataMember(Name = "next")]
        public string Next { get; set; }

    }
}
