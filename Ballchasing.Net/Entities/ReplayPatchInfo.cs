using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ballchasing.Net
{

    [DataContract]
    public class ReplayPatchInfo
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "link")]
        public string Link { get; set; }

        [DataMember(Name = "created")]
        public DateTime Created { get; set; }

        [DataMember(Name = "uploader")]
        public Uploader Uploader { get; set; }

        [DataMember(Name = "status")]
        public ReplayStatus Status { get; set; }

        [DataMember(Name = "rocket_league_id")]
        public string RocketLeagueId { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "recorder")]
        public string Recorder { get; set; }

        [DataMember(Name = "map_code")]
        public string MapCode { get; set; }

        // Potential enum type
        [DataMember(Name = "match_type")]
        public string MatchType { get; set; }

        [DataMember(Name = "team_size")]
        public int TeamSize { get; set; }

        [DataMember(Name = "playlist_id")]
        public Playlist PlaylistId { get; set; }

        [DataMember(Name = "duration")]
        public int Duration { get; set; }

        [DataMember(Name = "overtime")]
        public bool Overtime { get; set; }

        [DataMember(Name = "season")]
        public int Season { get; set; }

        [DataMember(Name = "date")]
        public DateTime Date { get; set; }

        [DataMember(Name = "visibility")]
        public Visibility Visibility { get; set; }

        [DataMember(Name = "groups")]
        public IList<Group> Groups { get; set; }

        [DataMember(Name = "blue")]
        public Team Blue { get; set; }

        [DataMember(Name = "orange")]
        public Team Orange { get; set; }

        [DataMember(Name = "playlist_name")]
        public string PlaylistName { get; set; }

        [DataMember(Name = "map_name")]
        public string MapName { get; set; }
    }
}
