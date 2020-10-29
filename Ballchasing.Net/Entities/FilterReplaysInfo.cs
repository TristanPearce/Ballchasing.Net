using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ballchasing.Net
{
    [DataContract]
    public class FilterReplaysInfo
    {

        [DataMember(Name = "title", IsRequired = false)]
        public string Title { get; set; }

        [DataMember(Name = "player-name", IsRequired = false)]
        public string PlayerName { get; set; }

        [DataMember(Name = "player-id", IsRequired = false)]
        public string PlayerId { get; set; }

        [DataMember(Name = "playlist", IsRequired = false)]
        public Playlist? Playlist { get; set; }

        [DataMember(Name = "season", IsRequired = false)]
        public int? Season { get; set; }

        [DataMember(Name = "match-result", IsRequired = false)]
        public MatchResult? MatchResult { get; set; }

        [DataMember(Name = "min-rank", IsRequired = false)]
        public Rank? MinimumRank { get; set; }

        [DataMember(Name = "max-rank", IsRequired = false)]
        public Rank? MaximumRank { get; set; }

        [DataMember(Name = "pro", IsRequired = false)]
        public bool? Pro { get; set; }

        [DataMember(Name = "uploader", IsRequired = false)]
        public string Uploader { get; set; }

        [DataMember(Name = "group", IsRequired = false)]
        public string Group { get; set; }

        [DataMember(Name = "map", IsRequired = false)]
        public string Map { get; set; }

        [DataMember(Name = "created-before", IsRequired = false)]
        public DateTime? CreatedBefore { get; set; }

        [DataMember(Name = "created-after", IsRequired = false)]
        public DateTime? CreatedAfter { get; set; }

        [DataMember(Name = "replay-date-after", IsRequired = false)]
        public DateTime? ReplayDateAfter { get; set; }

        [DataMember(Name = "replay-date-before", IsRequired = false)]
        public DateTime? ReplayDateBefore { get; set; }

        [DataMember(Name = "count", IsRequired = false)]
        public int? Count { get; set; }

        [DataMember(Name = "sort-by", IsRequired = false)]
        public SortBy? SortBy { get; set; }

        [DataMember(Name = "sort-dir", IsRequired = false)]
        public SortDirection? SortDirection { get; set; }

        /// <summary>
        /// Returns the contents of this object as a url-parameter compiant string.
        /// </summary>
        /// <returns></returns>
        public string ToUrlParameters()
        {
            string json = JsonConvert.SerializeObject(this,
                            Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });

            IDictionary<string, string> parameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, string> pair in parameters)
            {
                sb.Append($"{pair.Key}={pair.Value}&");
            }

            if (sb.Length > 0)
                return sb.ToString(0, sb.Length - 1);
            else
                return "";
        }
    }
}
