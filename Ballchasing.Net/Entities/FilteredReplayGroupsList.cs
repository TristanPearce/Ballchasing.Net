using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    /// <summary>
    /// https://ballchasing.com/doc/api#replays-replays-get
    /// </summary>
    [DataContract]
    public class FilteredReplayGroupsList
    {
        [DataMember(Name = "list")]
        public IList<FilteredReplayGroup> Groups { get; set; }

        [DataMember(Name = "next")]
        public string Next { get; set; }

    }
}
