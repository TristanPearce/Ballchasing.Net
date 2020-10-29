using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class Core
    {

        [DataMember(Name = "shots")]
        public int Shots { get; set; }

        [DataMember(Name = "shots_against")]
        public int ShotsAgainst { get; set; }

        [DataMember(Name = "goals")]
        public int Goals { get; set; }

        [DataMember(Name = "goals_against")]
        public int GoalsAgainst { get; set; }

        [DataMember(Name = "saves")]
        public int Saves { get; set; }

        [DataMember(Name = "assists")]
        public int Assists { get; set; }

        [DataMember(Name = "score")]
        public int Score { get; set; }

        [DataMember(Name = "mvp")]
        public bool Mvp { get; set; }

        [DataMember(Name = "shooting_percentage")]
        public double ShootingPercentage { get; set; }
    }
}
