using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class ReplayGroupPatchInfo
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "link")]
        public string Link { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "created")]
        public DateTime? Created { get; set; }

        [DataMember(Name = "status")]
        public ReplayGroupStatus? Status { get; set; }

        [DataMember(Name = "player_identification")]
        public PlayerIdentification? PlayerIdentification { get; set; }

        [DataMember(Name = "team_identification")]
        public TeamIdentification? TeamIdentification { get; set; }

        [DataMember(Name = "shared")]
        public bool? Shared { get; set; }

        [DataMember(Name = "creator")]
        public Uploader Creator { get; set; }

        [DataMember(Name = "players")]
        public IList<Player> Players { get; set; }

        [DataMember(Name = "teams")]
        public IList<Team> Teams { get; set; }
    }
}
