using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text;

namespace Ballchasing.Net
{
    public class FilteredReplayGroup
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

        [JsonProperty("overtime_seconds")]
        public int? OvertimeSeconds { get; set; }

    }
}
