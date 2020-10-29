using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Ballchasing.Net
{
    public class FilteredReplay
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("rocket_league_id")]
        public string RocketLeagueId { get; set; }

        [JsonProperty("replay_title")]
        public string ReplayTitle { get; set; }

        [JsonProperty("map_code")]
        public string MapCode { get; set; }

        [JsonProperty("map_name")]
        public string MapName { get; set; }

        [JsonProperty("playlist_id")]
        public string PlaylistId { get; set; }

        [JsonProperty("playlist_name")]
        public string PlaylistName { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("overtime")]
        public bool Overtime { get; set; }

        [JsonProperty("season")]
        public int Season { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("uploader")]
        public Uploader Uploader { get; set; }

        [JsonProperty("blue")]
        public Team Blue { get; set; }

        [JsonProperty("orange")]
        public Team Orange { get; set; }

        private Rank? maxRank;
        public Rank MaxRank => maxRank ?? (maxRank = FindRankByName(AdditionalData["max_rank"]["id"].ToString())).Value;

        private Rank? minRank;
        public Rank MinRank => minRank ?? (minRank = FindRankByName(AdditionalData["min_rank"]["id"].ToString())).Value;

        /// <summary>
        /// Holds all not-serialized data, used to get the rank.
        /// </summary>
        [JsonExtensionData]
        protected IDictionary<string, JToken> AdditionalData { get; set; }

        private static Rank FindRankByName(string name)
        {
            var fields = (typeof(Rank).GetFields());

            foreach(var field in fields)
            {
                var attributes = field.GetCustomAttributes(typeof(EnumMemberAttribute), false);
                foreach(var attribute in attributes)
                {
                    if(attribute is EnumMemberAttribute member)
                    {
                        if (name.Equals(member.Value))
                            return (Rank)Enum.Parse(typeof(Rank), field.Name);
                    }
                }
            }
            return Rank.Unknown;

        }
    }
}
